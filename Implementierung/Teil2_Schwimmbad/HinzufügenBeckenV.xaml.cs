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
    /// Interaktionslogik für HinzufügenBeckenV.xaml
    /// </summary>
    public partial class HinzufügenBeckenV : UserControl
    {
        MainWindow wnd = null;
        BesucherfreundlichesInformationssystemContext ctx = new BesucherfreundlichesInformationssystemContext();
        public ICollectionView DisplayView;



        public HinzufügenBeckenV(MainWindow wnd)
        {
            InitializeComponent();
            this.wnd = wnd;
            ctx.Beckens.Load();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Beckens.Local.ToObservableCollection());
            DataContext = DisplayView;
        }

        private void Button_Click_Hinzufügen(object sender, RoutedEventArgs e)
        {
            // Anlegen eines neuen Objekts.
            Becken n = new Becken
            {
                Name = nameTextBox.Text
            };


            // Hinzufügen des neuen Objekts zum Kontext.
            ctx.Beckens.Add(n);
            // Übertragen der Änderungen an die Datenbank.
            ctx.SaveChanges();
            DisplayView = CollectionViewSource.GetDefaultView(ctx.Beckens.Local.ToObservableCollection());
            DataContext = DisplayView;

        }
    }
}
