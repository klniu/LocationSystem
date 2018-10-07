﻿using BLL;
using DbModel.LocationHistory.Data;
using Location.BLL.Tool;
using LocationServices.LocationCallbacks;
using LocationWCFServer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LocationServices.Tools
{
    public class PositionEngineClient
    {
        public PositionEngineLog Logs { get; set; }

        public void WriteLogLeft(string txt)
        {
            if (Logs == null)
            {
                Logs = new PositionEngineLog();
            }
            Logs.WriteLogLeft(txt);
        }

        public void WriteLogRight(string txt)
        {
            if (Logs == null)
            {
                Logs = new PositionEngineLog();
            }
            Logs.WriteLogRight(txt);
        }

        public PositionEngineDA engineDa;


        public List<Position> Positions = new List<Position>();

        public void StartConnectEngine(int mockCount,string engineIp, string localIp)
        {
            Log.Info("开始连接定位引擎");
            //int mockCount = int.Parse(TbMockTagPowerCount0.Text);
            if (engineDa == null)
            {
                //engineDa = new PositionEngineDA("192.168.10.155", "192.168.10.19");//todo:ip写到配置文件中
                engineDa = new PositionEngineDA(engineIp, localIp);//todo:ip写到配置文件中
                engineDa.MockCount = mockCount;
                //engineDa.MessageReceived += EngineDa_MessageReceived;
                engineDa.MessageReceived += (obj) =>
                {
                    Logs.WriteLogLeft(GetLogText(obj));
                };
                //engineDa.PositionRecived += EngineDa_PositionRecived;
                engineDa.PositionListRecived += EngineDa_PositionListRecived;
            }

            using (var positionBll = GetLocationBll())
            {
                positionBll.InitTagPosition(mockCount);
            }

            engineDa.Start();

            StartInsertPositionTimer();
        }

        private Thread insertThread;

        public bool isBusy = false;//没有这个标志位的话，很容易导致子线程间干扰

        public void StartInsertPositionTimer()
        {
            insertThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(100);
                    InsertPostions();
                }
            });
            insertThread.Start();
        }



        private string GetLogText(string msg)
        {
            return DateTime.Now.ToString("HH:mm:ss.fff") + ":" + msg;
        }


        private void InsertPostions()
        {
            lock (Positions)
            {
                if (!isBusy && Positions.Count > 0)
                {
                    isBusy = true;
                    WriteLogRight(GetLogText(string.Format("写入{0}条数据 Start", Positions.Count)));
                    try
                    {
                        List<Position> posList2 = new List<Position>();
                        posList2.AddRange(Positions);
                        if (InsertPostions(posList2))
                        {
                            Positions.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error("InsertPostions", ex);
                    }

                    isBusy = false;
                }
                else
                {
                    if (Positions.Count > 0)
                        WriteLogRight(GetLogText(string.Format("等待 当前{0}条数据", Positions.Count)));
                }
            }
        }

        private bool InsertPostions(List<Position> posList2)
        {
            bool r = false;
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();

            using (var positionBll = GetLocationBll())
            {
                var personnels = positionBll.Personnels.ToList();
                var tagToPersons = positionBll.LocationCardToPersonnels.ToList();
                var tags = positionBll.LocationCards.ToList();
                //List<Tag> tagList = positionBll.Db.Tags.ToList();

                //foreach (Personnel item in personnels)
                //{
                //    item.Tag = tagList.Find(i => i.Id == item.TagId);
                //}

                foreach (Position pos in posList2)
                {
                    if (pos == null) continue;
                    try
                    {
                        var tag = tags.Find(i => i.Code == pos.Code);
                        var ttp = tagToPersons.Find(i => i.LocationCardId == tag.Id);
                        var personnelT = personnels.Find(i => i.Id == ttp.PersonnelId);
                        if (personnelT != null)
                        {
                            pos.PersonnelID = personnelT.Id;
                        }
                    }
                    catch
                    {
                        int i = 0;
                    }
                }

                r = positionBll.AddPositions(posList2);
                if (r)
                {
                    foreach (Position p in posList2)
                    {
                        if (p == null) continue;
                        if (p.X >= 10 && p.X <= 30 && p.Y >= 50 && p.Y <= 70 && p.Z >= 80 && p.Z <= 100)
                        {
                            LocationCallbackService.NotifyServiceStop();
                        }
                    }

                }
            }

            watch1.Stop();
            WriteLogRight(GetLogText(string.Format("写入{0}条数据 End 用时:{1}", posList2.Count, watch1.Elapsed)));
            return r;
        }

        private async void InsertPostionsAsync()
        {
            if (!isBusy && Positions.Count > 0)
            {
                isBusy = true;

                WriteLogRight(GetLogText(string.Format("写入{0}条数据 Start", Positions.Count)));
                List<Position> posList2 = new List<Position>();
                posList2.AddRange(Positions);
                Positions.Clear();

                InsertPostionsAsync(posList2);

                isBusy = false;
            }
            else
            {
                if (Positions.Count > 0)
                    WriteLogRight(GetLogText(string.Format("等待 当前{0}条数据", Positions.Count)));
            }
        }

        private async void InsertPostionsAsync(List<Position> posList)
        {
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();

            using (var positionBll = GetLocationBll())
            {
                await positionBll.AddPositionsAsyc(posList);
            }

            watch1.Stop();
            WriteLogRight(GetLogText(string.Format("写入{0}条数据 End 用时:{1}", posList.Count, watch1.Elapsed)));
        }

        public bool Stop()
        {
            try
            {
                if (engineDa != null)
                {
                    engineDa.Stop();
                }
                if (insertThread != null)
                {
                    insertThread.Abort();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return false;
            }
        }

        private void EngineDa_PositionListRecived(List<Position> posList)
        {
            foreach (var item in posList)
            {
                if (item != null)
                {
                    Positions.Add(item);
                }
                else
                {
                    Log.Warn("EngineDa_PositionListRecived item==null");
                }
            }
        }

        private Bll GetLocationBll()
        {
            return new Bll(false, true, false);
        }
    }
}
