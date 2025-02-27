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
    /// Interaktionslogik für LöschenKursV.xaml
    /// </summary>
    public partial class LöschenKursV : UserControl
    {
        MainWindow wnd = null;
        BesucherfreundlichesInformationssystemContext ctx = new BesucherfreundlichesInformationssystemContext();
        public ICollectionView DisplayView;


        public LöschenKursV(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
            ctx.Kurszeitens.Load();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Kurszeitens.Local.ToObservableCollection());
            DataContext = DisplayView;
        }




        private void Button_Click_Löschen(object sender, RoutedEventArgs e)
        {
            int kursID = Convert.ToInt32(idkurs.Text);

            Kurszeiten dataGridKurs = ctx.Kurszeitens.FirstOrDefault(x => kursID.Equals(x.KursId));



            if (Name != null)
            {
                // Entfernen des Elements aus dem DbSet.
                ctx.Kurszeitens.Remove(dataGridKurs);
                // Übertragen der Änderungen an die Datenbank.
                ctx.SaveChanges();
            }
        }
    }
}
