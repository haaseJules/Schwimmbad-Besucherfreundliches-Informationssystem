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

namespace Teil2_Schwimmbad
{
    /// <summary>
    /// Interaktionslogik für Besuchertipps.xaml
    /// </summary>
    public partial class Besuchertipps : UserControl
    {
        MainWindow wnd = null;
        public Besuchertipps(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
        }
    }
}
