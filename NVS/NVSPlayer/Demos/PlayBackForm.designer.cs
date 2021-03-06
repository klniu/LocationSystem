﻿namespace PlaybackDemo
{
    partial class PlayBackForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.cboChanList = new System.Windows.Forms.ComboBox();
            this.textPort = new System.Windows.Forms.MaskedTextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.btnLogon = new System.Windows.Forms.Button();
            this.panelVideoShow = new System.Windows.Forms.Panel();
            this.tabPlayBack = new System.Windows.Forms.TabControl();
            this.tabByTime = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cboTimeDataMode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTimeSaveFormat = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDownloadStatusTime = new System.Windows.Forms.Label();
            this.cboFileSaveFlag = new System.Windows.Forms.ComboBox();
            this.pbDownloadTime = new System.Windows.Forms.ProgressBar();
            this.btnPlayByTime = new System.Windows.Forms.Button();
            this.btnDLTimeStop = new System.Windows.Forms.Button();
            this.btnDLTimeStart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tabByFile = new System.Windows.Forms.TabPage();
            this.cboFileDataMode = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboFileSaveFormat = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lableFileCount = new System.Windows.Forms.Label();
            this.btnPlayByFile = new System.Windows.Forms.Button();
            this.cboTotolPage = new System.Windows.Forms.ComboBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.butNextPage = new System.Windows.Forms.Button();
            this.btnUpPage = new System.Windows.Forms.Button();
            this.btnDLFileContinue = new System.Windows.Forms.Button();
            this.btnDLFilePause = new System.Windows.Forms.Button();
            this.btnDLFileStop = new System.Windows.Forms.Button();
            this.btnDLFileStart = new System.Windows.Forms.Button();
            this.lvFileData = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VideoType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DownLoadPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtStartFile = new System.Windows.Forms.DateTimePicker();
            this.dtEndFile = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboInputPort = new System.Windows.Forms.ComboBox();
            this.cboAlarmType = new System.Windows.Forms.ComboBox();
            this.cboVideoType = new System.Windows.Forms.ComboBox();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboStreamNo = new System.Windows.Forms.ComboBox();
            this.btnPlayPlay = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.btnPlayFast = new System.Windows.Forms.Button();
            this.btnPlaySlow = new System.Windows.Forms.Button();
            this.btnPlayStep = new System.Windows.Forms.Button();
            this.timerDLFilePos = new System.Windows.Forms.Timer(this.components);
            this.lablePlayProcess = new System.Windows.Forms.Label();
            this.textSeekPos = new System.Windows.Forms.MaskedTextBox();
            this.btnPlaySeek = new System.Windows.Forms.Button();
            this.timerDLTimePos = new System.Windows.Forms.Timer(this.components);
            this.timerPlayPos = new System.Windows.Forms.Timer(this.components);
            this.cboSnapPicType = new System.Windows.Forms.ComboBox();
            this.btnSnapShot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPlayBack.SuspendLayout();
            this.tabByTime.SuspendLayout();
            this.tabByFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1140, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "ChannelNo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboChanList
            // 
            this.cboChanList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChanList.FormattingEnabled = true;
            this.cboChanList.Location = new System.Drawing.Point(1235, 18);
            this.cboChanList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboChanList.Name = "cboChanList";
            this.cboChanList.Size = new System.Drawing.Size(99, 23);
            this.cboChanList.TabIndex = 46;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(381, 15);
            this.textPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPort.Mask = "99999";
            this.textPort.Name = "textPort";
            this.textPort.PromptChar = ' ';
            this.textPort.Size = new System.Drawing.Size(129, 25);
            this.textPort.SkipLiterals = false;
            this.textPort.TabIndex = 45;
            this.textPort.Text = "3000";
            this.textPort.ValidatingType = typeof(int);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(119, 15);
            this.textIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(131, 25);
            this.textIP.TabIndex = 44;
            this.textIP.Text = "192.168.1.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "UserName:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "ServerPort:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "ServerIP:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(620, 15);
            this.textUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(131, 25);
            this.textUser.TabIndex = 38;
            this.textUser.Text = "Admin";
            // 
            // textPwd
            // 
            this.textPwd.AcceptsReturn = true;
            this.textPwd.Location = new System.Drawing.Point(883, 15);
            this.textPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '*';
            this.textPwd.Size = new System.Drawing.Size(129, 25);
            this.textPwd.TabIndex = 39;
            this.textPwd.Text = "1111";
            // 
            // btnLogon
            // 
            this.btnLogon.Location = new System.Drawing.Point(1021, 15);
            this.btnLogon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(100, 29);
            this.btnLogon.TabIndex = 37;
            this.btnLogon.Text = "Logon";
            this.btnLogon.UseVisualStyleBackColor = true;
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // panelVideoShow
            // 
            this.panelVideoShow.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelVideoShow.Location = new System.Drawing.Point(13, 102);
            this.panelVideoShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVideoShow.Name = "panelVideoShow";
            this.panelVideoShow.Size = new System.Drawing.Size(553, 498);
            this.panelVideoShow.TabIndex = 48;
            // 
            // tabPlayBack
            // 
            this.tabPlayBack.Controls.Add(this.tabByTime);
            this.tabPlayBack.Controls.Add(this.tabByFile);
            this.tabPlayBack.Location = new System.Drawing.Point(575, 75);
            this.tabPlayBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPlayBack.Name = "tabPlayBack";
            this.tabPlayBack.SelectedIndex = 0;
            this.tabPlayBack.Size = new System.Drawing.Size(968, 809);
            this.tabPlayBack.TabIndex = 49;
            // 
            // tabByTime
            // 
            this.tabByTime.BackColor = System.Drawing.SystemColors.Control;
            this.tabByTime.Controls.Add(this.button2);
            this.tabByTime.Controls.Add(this.button1);
            this.tabByTime.Controls.Add(this.richTextBox1);
            this.tabByTime.Controls.Add(this.cboTimeDataMode);
            this.tabByTime.Controls.Add(this.label15);
            this.tabByTime.Controls.Add(this.cboTimeSaveFormat);
            this.tabByTime.Controls.Add(this.label18);
            this.tabByTime.Controls.Add(this.label14);
            this.tabByTime.Controls.Add(this.lbDownloadStatusTime);
            this.tabByTime.Controls.Add(this.cboFileSaveFlag);
            this.tabByTime.Controls.Add(this.pbDownloadTime);
            this.tabByTime.Controls.Add(this.btnPlayByTime);
            this.tabByTime.Controls.Add(this.btnDLTimeStop);
            this.tabByTime.Controls.Add(this.btnDLTimeStart);
            this.tabByTime.Controls.Add(this.label8);
            this.tabByTime.Controls.Add(this.dtEndTime);
            this.tabByTime.Controls.Add(this.dtStartTime);
            this.tabByTime.Controls.Add(this.label13);
            this.tabByTime.Location = new System.Drawing.Point(4, 25);
            this.tabByTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabByTime.Name = "tabByTime";
            this.tabByTime.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabByTime.Size = new System.Drawing.Size(960, 780);
            this.tabByTime.TabIndex = 1;
            this.tabByTime.Text = "By Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 63;
            this.button1.Text = "ClearLog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(64, 470);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(827, 278);
            this.richTextBox1.TabIndex = 62;
            this.richTextBox1.Text = "";
            // 
            // cboTimeDataMode
            // 
            this.cboTimeDataMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeDataMode.FormattingEnabled = true;
            this.cboTimeDataMode.Location = new System.Drawing.Point(337, 256);
            this.cboTimeDataMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTimeDataMode.Name = "cboTimeDataMode";
            this.cboTimeDataMode.Size = new System.Drawing.Size(203, 23);
            this.cboTimeDataMode.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 264);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 59;
            this.label15.Text = "Data Mode:";
            // 
            // cboTimeSaveFormat
            // 
            this.cboTimeSaveFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeSaveFormat.FormattingEnabled = true;
            this.cboTimeSaveFormat.Location = new System.Drawing.Point(337, 208);
            this.cboTimeSaveFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTimeSaveFormat.Name = "cboTimeSaveFormat";
            this.cboTimeSaveFormat.Size = new System.Drawing.Size(203, 23);
            this.cboTimeSaveFormat.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(168, 218);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 15);
            this.label18.TabIndex = 60;
            this.label18.Text = "File Save Format :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(208, 164);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 15);
            this.label14.TabIndex = 59;
            this.label14.Text = "FileSaveFlag:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDownloadStatusTime
            // 
            this.lbDownloadStatusTime.AutoSize = true;
            this.lbDownloadStatusTime.Location = new System.Drawing.Point(436, 420);
            this.lbDownloadStatusTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDownloadStatusTime.Name = "lbDownloadStatusTime";
            this.lbDownloadStatusTime.Size = new System.Drawing.Size(127, 15);
            this.lbDownloadStatusTime.TabIndex = 28;
            this.lbDownloadStatusTime.Text = "Download Status";
            // 
            // cboFileSaveFlag
            // 
            this.cboFileSaveFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileSaveFlag.FormattingEnabled = true;
            this.cboFileSaveFlag.Items.AddRange(new object[] {
            "Multi File",
            "Single file"});
            this.cboFileSaveFlag.Location = new System.Drawing.Point(337, 159);
            this.cboFileSaveFlag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFileSaveFlag.Name = "cboFileSaveFlag";
            this.cboFileSaveFlag.Size = new System.Drawing.Size(203, 23);
            this.cboFileSaveFlag.TabIndex = 58;
            // 
            // pbDownloadTime
            // 
            this.pbDownloadTime.Location = new System.Drawing.Point(64, 371);
            this.pbDownloadTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDownloadTime.Name = "pbDownloadTime";
            this.pbDownloadTime.Size = new System.Drawing.Size(828, 29);
            this.pbDownloadTime.TabIndex = 27;
            // 
            // btnPlayByTime
            // 
            this.btnPlayByTime.Location = new System.Drawing.Point(563, 104);
            this.btnPlayByTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayByTime.Name = "btnPlayByTime";
            this.btnPlayByTime.Size = new System.Drawing.Size(100, 29);
            this.btnPlayByTime.TabIndex = 26;
            this.btnPlayByTime.Text = "Play";
            this.btnPlayByTime.UseVisualStyleBackColor = true;
            this.btnPlayByTime.Click += new System.EventHandler(this.btnPlayByTime_Click);
            // 
            // btnDLTimeStop
            // 
            this.btnDLTimeStop.Location = new System.Drawing.Point(442, 321);
            this.btnDLTimeStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDLTimeStop.Name = "btnDLTimeStop";
            this.btnDLTimeStop.Size = new System.Drawing.Size(136, 29);
            this.btnDLTimeStop.TabIndex = 25;
            this.btnDLTimeStop.Text = "Stop Download";
            this.btnDLTimeStop.UseVisualStyleBackColor = true;
            this.btnDLTimeStop.Click += new System.EventHandler(this.btnDLTimeStop_Click);
            // 
            // btnDLTimeStart
            // 
            this.btnDLTimeStart.Location = new System.Drawing.Point(276, 321);
            this.btnDLTimeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDLTimeStart.Name = "btnDLTimeStart";
            this.btnDLTimeStart.Size = new System.Drawing.Size(136, 29);
            this.btnDLTimeStart.TabIndex = 24;
            this.btnDLTimeStart.Text = "Start Download";
            this.btnDLTimeStart.UseVisualStyleBackColor = true;
            this.btnDLTimeStart.Click += new System.EventHandler(this.btnDLTimeStart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "End Time:";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(337, 104);
            this.dtEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.ShowUpDown = true;
            this.dtEndTime.Size = new System.Drawing.Size(203, 25);
            this.dtEndTime.TabIndex = 19;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtStartTime.Location = new System.Drawing.Point(337, 59);
            this.dtStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(203, 25);
            this.dtStartTime.TabIndex = 18;
            this.dtStartTime.Value = new System.DateTime(2015, 7, 4, 11, 59, 53, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Start Time:";
            // 
            // tabByFile
            // 
            this.tabByFile.BackColor = System.Drawing.SystemColors.Control;
            this.tabByFile.Controls.Add(this.cboFileDataMode);
            this.tabByFile.Controls.Add(this.label17);
            this.tabByFile.Controls.Add(this.cboFileSaveFormat);
            this.tabByFile.Controls.Add(this.label16);
            this.tabByFile.Controls.Add(this.lableFileCount);
            this.tabByFile.Controls.Add(this.btnPlayByFile);
            this.tabByFile.Controls.Add(this.cboTotolPage);
            this.tabByFile.Controls.Add(this.btnLastPage);
            this.tabByFile.Controls.Add(this.btnFirstPage);
            this.tabByFile.Controls.Add(this.butNextPage);
            this.tabByFile.Controls.Add(this.btnUpPage);
            this.tabByFile.Controls.Add(this.btnDLFileContinue);
            this.tabByFile.Controls.Add(this.btnDLFilePause);
            this.tabByFile.Controls.Add(this.btnDLFileStop);
            this.tabByFile.Controls.Add(this.btnDLFileStart);
            this.tabByFile.Controls.Add(this.lvFileData);
            this.tabByFile.Controls.Add(this.groupBox1);
            this.tabByFile.Location = new System.Drawing.Point(4, 25);
            this.tabByFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabByFile.Name = "tabByFile";
            this.tabByFile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabByFile.Size = new System.Drawing.Size(960, 780);
            this.tabByFile.TabIndex = 0;
            this.tabByFile.Text = "By File";
            // 
            // cboFileDataMode
            // 
            this.cboFileDataMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileDataMode.FormattingEnabled = true;
            this.cboFileDataMode.Location = new System.Drawing.Point(657, 160);
            this.cboFileDataMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFileDataMode.Name = "cboFileDataMode";
            this.cboFileDataMode.Size = new System.Drawing.Size(120, 23);
            this.cboFileDataMode.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(560, 165);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "Data Mode:";
            // 
            // cboFileSaveFormat
            // 
            this.cboFileSaveFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileSaveFormat.FormattingEnabled = true;
            this.cboFileSaveFormat.Location = new System.Drawing.Point(421, 160);
            this.cboFileSaveFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFileSaveFormat.Name = "cboFileSaveFormat";
            this.cboFileSaveFormat.Size = new System.Drawing.Size(120, 23);
            this.cboFileSaveFormat.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 165);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "File Save Format :";
            // 
            // lableFileCount
            // 
            this.lableFileCount.AutoSize = true;
            this.lableFileCount.Location = new System.Drawing.Point(791, 164);
            this.lableFileCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableFileCount.Name = "lableFileCount";
            this.lableFileCount.Size = new System.Drawing.Size(103, 15);
            this.lableFileCount.TabIndex = 27;
            this.lableFileCount.Text = "Total File :";
            // 
            // btnPlayByFile
            // 
            this.btnPlayByFile.Location = new System.Drawing.Point(8, 701);
            this.btnPlayByFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayByFile.Name = "btnPlayByFile";
            this.btnPlayByFile.Size = new System.Drawing.Size(83, 29);
            this.btnPlayByFile.TabIndex = 26;
            this.btnPlayByFile.Text = "Play";
            this.btnPlayByFile.UseVisualStyleBackColor = true;
            this.btnPlayByFile.Click += new System.EventHandler(this.btnPlayByFile_Click);
            // 
            // cboTotolPage
            // 
            this.cboTotolPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTotolPage.FormattingEnabled = true;
            this.cboTotolPage.Location = new System.Drawing.Point(881, 702);
            this.cboTotolPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTotolPage.Name = "cboTotolPage";
            this.cboTotolPage.Size = new System.Drawing.Size(67, 23);
            this.cboTotolPage.TabIndex = 25;
            this.cboTotolPage.SelectedIndexChanged += new System.EventHandler(this.cboTotolPage_SelectedIndexChanged);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(776, 701);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(100, 29);
            this.btnLastPage.TabIndex = 24;
            this.btnLastPage.Text = "Last Page";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(468, 701);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(100, 29);
            this.btnFirstPage.TabIndex = 23;
            this.btnFirstPage.Text = "First Page";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // butNextPage
            // 
            this.butNextPage.Location = new System.Drawing.Point(673, 701);
            this.butNextPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butNextPage.Name = "butNextPage";
            this.butNextPage.Size = new System.Drawing.Size(100, 29);
            this.butNextPage.TabIndex = 22;
            this.butNextPage.Text = "Next Page";
            this.butNextPage.UseVisualStyleBackColor = true;
            this.butNextPage.Click += new System.EventHandler(this.butNextPage_Click);
            // 
            // btnUpPage
            // 
            this.btnUpPage.Location = new System.Drawing.Point(571, 701);
            this.btnUpPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpPage.Name = "btnUpPage";
            this.btnUpPage.Size = new System.Drawing.Size(100, 29);
            this.btnUpPage.TabIndex = 21;
            this.btnUpPage.Text = "Pre Page";
            this.btnUpPage.UseVisualStyleBackColor = true;
            this.btnUpPage.Click += new System.EventHandler(this.btnUpPage_Click);
            // 
            // btnDLFileContinue
            // 
            this.btnDLFileContinue.Location = new System.Drawing.Point(344, 701);
            this.btnDLFileContinue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDLFileContinue.Name = "btnDLFileContinue";
            this.btnDLFileContinue.Size = new System.Drawing.Size(119, 29);
            this.btnDLFileContinue.TabIndex = 20;
            this.btnDLFileContinue.Text = "DL Continue";
            this.btnDLFileContinue.UseVisualStyleBackColor = true;
            this.btnDLFileContinue.Click += new System.EventHandler(this.btnDLFileContinue_Click);
            // 
            // btnDLFilePause
            // 
            this.btnDLFilePause.Location = new System.Drawing.Point(259, 701);
            this.btnDLFilePause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDLFilePause.Name = "btnDLFilePause";
            this.btnDLFilePause.Size = new System.Drawing.Size(83, 29);
            this.btnDLFilePause.TabIndex = 19;
            this.btnDLFilePause.Text = "DL Pause";
            this.btnDLFilePause.UseVisualStyleBackColor = true;
            this.btnDLFilePause.Click += new System.EventHandler(this.btnDLFilePause_Click);
            // 
            // btnDLFileStop
            // 
            this.btnDLFileStop.Location = new System.Drawing.Point(172, 701);
            this.btnDLFileStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDLFileStop.Name = "btnDLFileStop";
            this.btnDLFileStop.Size = new System.Drawing.Size(83, 29);
            this.btnDLFileStop.TabIndex = 18;
            this.btnDLFileStop.Text = "DL Stop";
            this.btnDLFileStop.UseVisualStyleBackColor = true;
            this.btnDLFileStop.Click += new System.EventHandler(this.btnDLFileStop_Click);
            // 
            // btnDLFileStart
            // 
            this.btnDLFileStart.Location = new System.Drawing.Point(89, 701);
            this.btnDLFileStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDLFileStart.Name = "btnDLFileStart";
            this.btnDLFileStart.Size = new System.Drawing.Size(83, 29);
            this.btnDLFileStart.TabIndex = 17;
            this.btnDLFileStart.Text = "DL Start";
            this.btnDLFileStart.UseVisualStyleBackColor = true;
            this.btnDLFileStart.Click += new System.EventHandler(this.btnDLFileStart_Click);
            // 
            // lvFileData
            // 
            this.lvFileData.CheckBoxes = true;
            this.lvFileData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FileName,
            this.VideoType,
            this.FileSize,
            this.StartTime,
            this.EndTime,
            this.DownLoadPos});
            this.lvFileData.FullRowSelect = true;
            this.lvFileData.GridLines = true;
            this.lvFileData.HideSelection = false;
            this.lvFileData.Location = new System.Drawing.Point(8, 191);
            this.lvFileData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvFileData.MultiSelect = false;
            this.lvFileData.Name = "lvFileData";
            this.lvFileData.Size = new System.Drawing.Size(940, 485);
            this.lvFileData.TabIndex = 2;
            this.lvFileData.UseCompatibleStateImageBehavior = false;
            this.lvFileData.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 39;
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 175;
            // 
            // VideoType
            // 
            this.VideoType.Text = "Video Type";
            this.VideoType.Width = 91;
            // 
            // FileSize
            // 
            this.FileSize.Text = "FileSize";
            this.FileSize.Width = 80;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Start Time";
            this.StartTime.Width = 127;
            // 
            // EndTime
            // 
            this.EndTime.Text = "End Time";
            this.EndTime.Width = 127;
            // 
            // DownLoadPos
            // 
            this.DownLoadPos.Text = "DownLoad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtStartFile);
            this.groupBox1.Controls.Add(this.dtEndFile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboInputPort);
            this.groupBox1.Controls.Add(this.cboAlarmType);
            this.groupBox1.Controls.Add(this.cboVideoType);
            this.groupBox1.Controls.Add(this.cboFileType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Location = new System.Drawing.Point(8, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(941, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query terms";
            // 
            // dtStartFile
            // 
            this.dtStartFile.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStartFile.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartFile.Location = new System.Drawing.Point(347, 76);
            this.dtStartFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtStartFile.Name = "dtStartFile";
            this.dtStartFile.ShowUpDown = true;
            this.dtStartFile.Size = new System.Drawing.Size(185, 25);
            this.dtStartFile.TabIndex = 17;
            // 
            // dtEndFile
            // 
            this.dtEndFile.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEndFile.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndFile.Location = new System.Drawing.Point(548, 76);
            this.dtEndFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtEndFile.Name = "dtEndFile";
            this.dtEndFile.ShowUpDown = true;
            this.dtEndFile.Size = new System.Drawing.Size(181, 25);
            this.dtEndFile.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time range:";
            // 
            // cboInputPort
            // 
            this.cboInputPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInputPort.FormattingEnabled = true;
            this.cboInputPort.Location = new System.Drawing.Point(609, 31);
            this.cboInputPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboInputPort.Name = "cboInputPort";
            this.cboInputPort.Size = new System.Drawing.Size(120, 23);
            this.cboInputPort.TabIndex = 8;
            this.cboInputPort.Visible = false;
            // 
            // cboAlarmType
            // 
            this.cboAlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlarmType.FormattingEnabled = true;
            this.cboAlarmType.Location = new System.Drawing.Point(347, 32);
            this.cboAlarmType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAlarmType.Name = "cboAlarmType";
            this.cboAlarmType.Size = new System.Drawing.Size(120, 23);
            this.cboAlarmType.TabIndex = 7;
            // 
            // cboVideoType
            // 
            this.cboVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoType.FormattingEnabled = true;
            this.cboVideoType.Location = new System.Drawing.Point(108, 76);
            this.cboVideoType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboVideoType.Name = "cboVideoType";
            this.cboVideoType.Size = new System.Drawing.Size(120, 23);
            this.cboVideoType.TabIndex = 6;
            // 
            // cboFileType
            // 
            this.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Location = new System.Drawing.Point(108, 31);
            this.cboFileType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(120, 23);
            this.cboFileType.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Input port:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Alarm type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Video type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "File type:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(756, 75);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 29);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1343, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "StreamNo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboStreamNo
            // 
            this.cboStreamNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreamNo.FormattingEnabled = true;
            this.cboStreamNo.Location = new System.Drawing.Point(1437, 19);
            this.cboStreamNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboStreamNo.Name = "cboStreamNo";
            this.cboStreamNo.Size = new System.Drawing.Size(99, 23);
            this.cboStreamNo.TabIndex = 50;
            this.cboStreamNo.SelectedIndexChanged += new System.EventHandler(this.cboStreamNo_SelectedIndexChanged);
            // 
            // btnPlayPlay
            // 
            this.btnPlayPlay.Location = new System.Drawing.Point(12, 644);
            this.btnPlayPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayPlay.Name = "btnPlayPlay";
            this.btnPlayPlay.Size = new System.Drawing.Size(57, 29);
            this.btnPlayPlay.TabIndex = 52;
            this.btnPlayPlay.Text = "Play";
            this.btnPlayPlay.UseVisualStyleBackColor = true;
            this.btnPlayPlay.Click += new System.EventHandler(this.btnPlayPlay_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(76, 644);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(69, 29);
            this.btnPlayPause.TabIndex = 53;
            this.btnPlayPause.Text = "Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.Location = new System.Drawing.Point(152, 644);
            this.btnPlayStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(69, 29);
            this.btnPlayStop.TabIndex = 54;
            this.btnPlayStop.Text = "Stop";
            this.btnPlayStop.UseVisualStyleBackColor = true;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // btnPlayFast
            // 
            this.btnPlayFast.Location = new System.Drawing.Point(303, 644);
            this.btnPlayFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayFast.Name = "btnPlayFast";
            this.btnPlayFast.Size = new System.Drawing.Size(69, 29);
            this.btnPlayFast.TabIndex = 55;
            this.btnPlayFast.Text = "Fast";
            this.btnPlayFast.UseVisualStyleBackColor = true;
            this.btnPlayFast.Click += new System.EventHandler(this.btnPlayFast_Click);
            // 
            // btnPlaySlow
            // 
            this.btnPlaySlow.Location = new System.Drawing.Point(229, 644);
            this.btnPlaySlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaySlow.Name = "btnPlaySlow";
            this.btnPlaySlow.Size = new System.Drawing.Size(69, 29);
            this.btnPlaySlow.TabIndex = 56;
            this.btnPlaySlow.Text = "Slow";
            this.btnPlaySlow.UseVisualStyleBackColor = true;
            this.btnPlaySlow.Click += new System.EventHandler(this.btnPlaySlow_Click);
            // 
            // btnPlayStep
            // 
            this.btnPlayStep.Location = new System.Drawing.Point(380, 644);
            this.btnPlayStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayStep.Name = "btnPlayStep";
            this.btnPlayStep.Size = new System.Drawing.Size(69, 29);
            this.btnPlayStep.TabIndex = 57;
            this.btnPlayStep.Text = "Step";
            this.btnPlayStep.UseVisualStyleBackColor = true;
            this.btnPlayStep.Click += new System.EventHandler(this.btnPlayStep_Click);
            // 
            // timerDLFilePos
            // 
            this.timerDLFilePos.Tick += new System.EventHandler(this.timerDownloadPos_Tick);
            // 
            // lablePlayProcess
            // 
            this.lablePlayProcess.AutoSize = true;
            this.lablePlayProcess.Location = new System.Drawing.Point(383, 612);
            this.lablePlayProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lablePlayProcess.Name = "lablePlayProcess";
            this.lablePlayProcess.Size = new System.Drawing.Size(71, 15);
            this.lablePlayProcess.TabIndex = 58;
            this.lablePlayProcess.Text = "00:00:00";
            // 
            // textSeekPos
            // 
            this.textSeekPos.Location = new System.Drawing.Point(455, 645);
            this.textSeekPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSeekPos.Mask = "99999";
            this.textSeekPos.Name = "textSeekPos";
            this.textSeekPos.PromptChar = ' ';
            this.textSeekPos.Size = new System.Drawing.Size(31, 25);
            this.textSeekPos.SkipLiterals = false;
            this.textSeekPos.TabIndex = 59;
            this.textSeekPos.Text = "50";
            this.textSeekPos.ValidatingType = typeof(int);
            // 
            // btnPlaySeek
            // 
            this.btnPlaySeek.Location = new System.Drawing.Point(495, 642);
            this.btnPlaySeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaySeek.Name = "btnPlaySeek";
            this.btnPlaySeek.Size = new System.Drawing.Size(72, 29);
            this.btnPlaySeek.TabIndex = 60;
            this.btnPlaySeek.Text = "Seek";
            this.btnPlaySeek.UseVisualStyleBackColor = true;
            this.btnPlaySeek.Click += new System.EventHandler(this.btnPlaySeek_Click);
            // 
            // timerDLTimePos
            // 
            this.timerDLTimePos.Tick += new System.EventHandler(this.timerDLTimePos_Tick);
            // 
            // timerPlayPos
            // 
            this.timerPlayPos.Tick += new System.EventHandler(this.timerPlayPos_Tick);
            // 
            // cboSnapPicType
            // 
            this.cboSnapPicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSnapPicType.FormattingEnabled = true;
            this.cboSnapPicType.Location = new System.Drawing.Point(12, 698);
            this.cboSnapPicType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSnapPicType.Name = "cboSnapPicType";
            this.cboSnapPicType.Size = new System.Drawing.Size(56, 23);
            this.cboSnapPicType.TabIndex = 62;
            // 
            // btnSnapShot
            // 
            this.btnSnapShot.Location = new System.Drawing.Point(76, 695);
            this.btnSnapShot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSnapShot.Name = "btnSnapShot";
            this.btnSnapShot.Size = new System.Drawing.Size(69, 29);
            this.btnSnapShot.TabIndex = 61;
            this.btnSnapShot.Text = "Snap";
            this.btnSnapShot.UseVisualStyleBackColor = true;
            this.btnSnapShot.Click += new System.EventHandler(this.btnSnapShot_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 29);
            this.button2.TabIndex = 64;
            this.button2.Text = "Open Directory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlayBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 899);
            this.Controls.Add(this.cboSnapPicType);
            this.Controls.Add(this.btnSnapShot);
            this.Controls.Add(this.btnPlaySeek);
            this.Controls.Add(this.textSeekPos);
            this.Controls.Add(this.lablePlayProcess);
            this.Controls.Add(this.btnPlayStep);
            this.Controls.Add(this.btnPlaySlow);
            this.Controls.Add(this.btnPlayFast);
            this.Controls.Add(this.btnPlayStop);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnPlayPlay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboStreamNo);
            this.Controls.Add(this.tabPlayBack);
            this.Controls.Add(this.panelVideoShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboChanList);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.btnLogon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayBackForm";
            this.Text = "视频对接";
            this.Load += new System.EventHandler(this.PlayBackForm_Load);
            this.tabPlayBack.ResumeLayout(false);
            this.tabByTime.ResumeLayout(false);
            this.tabByTime.PerformLayout();
            this.tabByFile.ResumeLayout(false);
            this.tabByFile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboChanList;
        private System.Windows.Forms.MaskedTextBox textPort;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.Panel panelVideoShow;
        private System.Windows.Forms.TabControl tabPlayBack;
        private System.Windows.Forms.TabPage tabByFile;
        private System.Windows.Forms.TabPage tabByTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtStartFile;
        private System.Windows.Forms.DateTimePicker dtEndFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboInputPort;
        private System.Windows.Forms.ComboBox cboAlarmType;
        private System.Windows.Forms.ComboBox cboVideoType;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ListView lvFileData;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader VideoType;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader DownLoadPos;
        private System.Windows.Forms.ComboBox cboTotolPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button butNextPage;
        private System.Windows.Forms.Button btnUpPage;
        private System.Windows.Forms.Button btnDLFileContinue;
        private System.Windows.Forms.Button btnDLFilePause;
        private System.Windows.Forms.Button btnDLFileStop;
        private System.Windows.Forms.Button btnDLFileStart;
        private System.Windows.Forms.Button btnPlayByFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStreamNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbDownloadStatusTime;
        private System.Windows.Forms.ProgressBar pbDownloadTime;
        private System.Windows.Forms.Button btnPlayByTime;
        private System.Windows.Forms.Button btnDLTimeStop;
        private System.Windows.Forms.Button btnDLTimeStart;
        private System.Windows.Forms.Button btnPlayPlay;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.Button btnPlayFast;
        private System.Windows.Forms.Button btnPlaySlow;
        private System.Windows.Forms.Button btnPlayStep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboFileSaveFlag;
        private System.Windows.Forms.Timer timerDLFilePos;
        private System.Windows.Forms.Label lablePlayProcess;
        private System.Windows.Forms.Label lableFileCount;
        private System.Windows.Forms.ComboBox cboFileDataMode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboFileSaveFormat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboTimeSaveFormat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboTimeDataMode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox textSeekPos;
        private System.Windows.Forms.Button btnPlaySeek;
        private System.Windows.Forms.Timer timerDLTimePos;
        private System.Windows.Forms.Timer timerPlayPos;
        private System.Windows.Forms.ComboBox cboSnapPicType;
        private System.Windows.Forms.Button btnSnapShot;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

