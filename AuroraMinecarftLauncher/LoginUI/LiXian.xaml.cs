﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuroraMinecarftLauncher.LoginUI
{
    /// <summary>
    /// LiXian.xaml 的交互逻辑
    /// </summary>
    public partial class LiXian : Page
    {
        public static TextBox OfflineID {get; set;}
        public LiXian()
        {
            InitializeComponent();
            OfflineID = IDTextbox;
        }


        private void IDT(object sender, TextChangedEventArgs e)
        {

        }
    }
}
