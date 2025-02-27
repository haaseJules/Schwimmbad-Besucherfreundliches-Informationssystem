using Microsoft.EntityFrameworkCore;
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
            ctx.Kurszeitens.Load();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Kurszeitens.Local.ToObservableCollection());
            DataContext = DisplayView;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_Click_Hinzufügen(object sender, RoutedEventArgs e)
        {
            // Anlegen eines neuen Objekts.
            Kurszeiten k = new Kurszeiten
            {
                Text = nameKurs.Text,
                Uhrzeit = TimeSpan.Parse(uhrzeit.Text),
                Kursleiter = Kursleitung.Text

            };


            // Hinzufügen des neuen Objekts zum Kontext.
            ctx.Kurszeitens.Add(k);
            // Übertragen der Änderungen an die Datenbank.
            ctx.SaveChanges();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Kurszeitens.Local.ToObservableCollection());
            DataContext = DisplayView;

        }
    }
}
