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
    /// Interaktionslogik für EventVerwaltung.xaml
    /// </summary>
    public partial class EventVerwaltung : UserControl
    {
        MainWindow wnd = null;
        public EventVerwaltung(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
        }



        private void Button_Click_Hinzufügen(object sender, RoutedEventArgs e)
        {
            EventController.Content = wnd.hinzufügenEventV;
        }

        private void Button_Click_Löschen(object sender, RoutedEventArgs e)
        {
            EventController.Content = wnd.löschenEventV;
        }
    }
}
