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
    /// Interaktionslogik für LöschenEventV.xaml
    /// </summary>
    public partial class LöschenEventV : UserControl
    {
        MainWindow wnd = null;
        BesucherfreundlichesInformationssystemContext ctx = new BesucherfreundlichesInformationssystemContext();
        public ICollectionView DisplayView;

        public LöschenEventV(MainWindow mainWindow)
        {
            InitializeComponent();
            this.wnd = wnd;
            ctx.Events.Load();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Events.Local.ToObservableCollection());
            DataContext = DisplayView;
        }

        private void Button_Click_Löschen(object sender, RoutedEventArgs e)
        {
            int eventID = Convert.ToInt32(idevent.Text);

            Event dataGridEvent = ctx.Events.FirstOrDefault(x => eventID.Equals(x.EventId));



            if (Name != null)
            {
                // Entfernen des Elements aus dem DbSet.
                ctx.Events.Remove(dataGridEvent);
                // Übertragen der Änderungen an die Datenbank.
                ctx.SaveChanges();
            }

        }
    }
}
