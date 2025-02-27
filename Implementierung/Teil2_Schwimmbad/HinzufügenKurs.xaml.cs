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
    /// Interaktionslogik für HinzufügenKurs.xaml
    /// </summary>
    public partial class HinzufügenKursV : UserControl
    {
        MainWindow wnd = null;
        BesucherfreundlichesInformationssystemContext ctx = new BesucherfreundlichesInformationssystemContext();
        public ICollectionView DisplayView;
        public HinzufügenKursV(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Kurszeitens.Local.ToObservableCollection());
            DataContext = DisplayView;
        }

        private void Button_Click_Hinzufügen(object sender, RoutedEventArgs e)
        {
            Kurszeiten k = new Kurszeiten
            {
                Text = nameKurs.Text,
                Uhrzeit = TimeSpan.Parse(uhrzeit.Text),
                Kursleiter = kursleitung.Text
            };

            ctx.Kurszeitens.Add(k);

            ctx.SaveChanges();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Kurszeitens.Local.ToObservableCollection());
            DataContext = DisplayView;

        }
    }
}
