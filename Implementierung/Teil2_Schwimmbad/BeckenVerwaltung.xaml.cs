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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Teil2_Schwimmbad
{
    /// <summary>
    /// Interaktionslogik für BeckenVerwaltung.xaml
    /// </summary>
    public partial class BeckenVerwaltung : UserControl
    {
        MainWindow wnd = null;
        public BeckenVerwaltung(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
        }



        private void Button_Click_Hinzufügen(object sender, RoutedEventArgs e)
        {
            BeckenController.Content = wnd.hinzufügenBeckenV;
        }


        private void Button_Click_Löschen(object sender, RoutedEventArgs e)
        {
            BeckenController.Content = wnd.löschenBeckenV;
        }
    }
}
