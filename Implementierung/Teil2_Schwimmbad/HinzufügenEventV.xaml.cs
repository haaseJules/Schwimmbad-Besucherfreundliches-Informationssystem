using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaktionslogik für HinzufügenEventV.xaml
    /// </summary>
    public partial class HinzufügenEventV : UserControl
    {
        MainWindow wnd = null;
        BesucherfreundlichesInformationssystemContext ctx = new BesucherfreundlichesInformationssystemContext();
        public ICollectionView DisplayView;
        public HinzufügenEventV(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Events.Local.ToObservableCollection());
            DataContext = DisplayView;
        }

        private void Button_Click_Hinzufügen(object sender, RoutedEventArgs e)
        {
            Event j = new Event
            {
                Name = nameEvent.Text,
                Uhrzeit = TimeSpan.Parse(uhrzeit.Text),
                Kursleiter = Eventleitung.Text
            };

            ctx.Events.Add(j);

            ctx.SaveChanges();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Events.Local.ToObservableCollection());
            DataContext = DisplayView;

        }
    }
}
