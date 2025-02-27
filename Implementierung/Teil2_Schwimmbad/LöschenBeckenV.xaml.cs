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
    /// Interaktionslogik für LöschenBeckenV.xaml
    /// </summary>
    public partial class LöschenBeckenV : UserControl
    {
        MainWindow wnd = null;
        BesucherfreundlichesInformationssystemContext ctx = new BesucherfreundlichesInformationssystemContext();
        public ICollectionView DisplayView;


        public LöschenBeckenV(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
            ctx.Beckens.Load();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Beckens.Local.ToObservableCollection());
            DataContext = DisplayView;
        }




        private void Button_Click_Löschen(object sender, RoutedEventArgs e)
        {
            int beckenID = Convert.ToInt32(idbecken.Text);

            Becken dataGridBecken = ctx.Beckens.FirstOrDefault(x => beckenID.Equals(x.BeckenId));



            if (Name != null)
            {
                // Entfernen des Elements aus dem DbSet.
                ctx.Beckens.Remove(dataGridBecken);
                // Übertragen der Änderungen an die Datenbank.
                ctx.SaveChanges();
            }
        }
    }
}
