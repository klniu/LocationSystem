﻿using BLL;
using DbModel.Location.Work;
using LocationServer;
using LocationServices.Locations.Interfaces;
using LocationServices.Locations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LocationServices.Locations
{
    //岗位相关的接口
    public partial class LocationService : ILocationService, IDisposable
    {
        public List<int> GetCardRoleAccessAreas(int role)
        {
            var bll = AppContext.GetLocationBll();
            var aarService = new AreaAuthorizationRecordService(bll);
            var list1 = aarService.GetAccessListByRole(role + "");
            List<int> areas = new List<int>();
            foreach (var item in list1)
            {
                if (item.Area != null)
                {
                    areas.Add(item.Area.Id);
                }
            }
            if (areas.Count == 0)
            {
                return null;
            }
            return areas;
        }

        public bool SetCardRoleAccessAreas(int roleId,List<int> areaIds)
        {
            
            try
            {
                var bll = AppContext.GetLocationBll();
                var aarService = new AreaAuthorizationRecordService(bll);
                var aaService = new AreaAuthorizationService(bll);
                var roleService = new TagRoleService(bll);
                var role = roleService.GetEntity(roleId + "");

                var aarList = aarService.GetListByRole(roleId + "");


                List<int> removeList = new List<int>();
                List<int> newList = new List<int>();

                for (int i = 0; i < aarList.Count; i++)
                {
                    var aar = aarList[i];
                    if (aar.AccessType== AreaAccessType.不能进入)//设置的是可以进入的权限，同时要把不能进入的权限都删了
                    {
                        //removeList.Add(aarList[i].Id);
                        var r = aarService.Delete(aar.Id + "");
                        aarList.RemoveAt(i);
                        i--;
                    }
                }

                List<int> areasIds = new List<int>();
                foreach (var item in aarList)
                {
                    if (item.Area != null)
                    {
                        areasIds.Add(item.Area.Id);
                    }
                }

                foreach (var item in areaIds)
                {
                    if (areasIds.Contains(item))
                    {
                        areasIds.Remove(item);
                    }
                    else
                    {
                        newList.Add(item);
                    }
                }
                removeList.AddRange(areasIds);

                foreach (var areaId in removeList)
                {
                    var aar = aarList.FirstOrDefault(i => i.Area.Id == areaId);
                    if (aar != null)
                    {
                        var r = aarService.Delete(aar.Id + "");
                    }
                    else
                    {

                    }
                }

                foreach (var areaId in newList)
                {
                    var list=aaService.GetListByArea(areaId + "");
                    var aa = list.FirstOrDefault(i => i.AccessType == AreaAccessType.可以进出);
                    if (aa != null)
                    {
                        var aar = new AreaAuthorizationRecord(aa, role);
                        var r = aarService.Post(aar);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}