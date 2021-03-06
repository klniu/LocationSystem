﻿using DbModel.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LocationServer.Windows
{
    /// <summary>
    /// BusAnchorConfigWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BusAnchorConfigWindow : Window
    {
        public BusAnchorConfigWindow()
        {
            InitializeComponent();
        }

        public void LoadData(bus_anchor_config config)
        {
            TbId.Text = config.anchor_id;
            TbType.Text = config.type+"";
            TbIp.Text = config.anchor_ip;

        }
    }
}
