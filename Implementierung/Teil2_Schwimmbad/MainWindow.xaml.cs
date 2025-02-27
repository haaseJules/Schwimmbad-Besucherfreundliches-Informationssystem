using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Teil2_Schwimmbad;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MenüController menü;
    public BeckenVerwaltung beckenV;
    public KursVerwaltung kursV;
    public EventVerwaltung eventV;
    public Besuchertipps besucherT;
    public Öffnungszeiten öffnungszeiten;


    public HinzufügenBeckenV hinzufügenBeckenV;
    public LöschenBeckenV löschenBeckenV;


    public HinzufügenKursV hinzufügenKursV;
    public LöschenKursV löschenKursV;


    public HinzufügenEventV hinzufügenEventV;
    public LöschenEventV löschenEventV;


    public MainWindow()
    {
        InitializeComponent();
        menü = new MenüController(this);
        beckenV = new BeckenVerwaltung(this);
        kursV = new KursVerwaltung(this);
        eventV = new EventVerwaltung(this);
        besucherT = new Besuchertipps(this);
        öffnungszeiten = new Öffnungszeiten(this);


        hinzufügenBeckenV = new HinzufügenBeckenV(this);
        löschenBeckenV = new LöschenBeckenV(this);


        hinzufügenKursV = new HinzufügenKursV(this);
        löschenKursV = new LöschenKursV(this);


        hinzufügenEventV = new HinzufügenEventV(this);
        löschenEventV = new LöschenEventV(this);
    }

    private void Button_Click_Menü(object sender, RoutedEventArgs e)
    {
        contentcontroller.Content = menü;

    }

    private void Button_Click_Becken(object sender, RoutedEventArgs e)
    {
        contentcontroller.Content = beckenV;
    }

    private void Button_Click_Kurs(object sender, RoutedEventArgs e)
    {
        contentcontroller.Content = kursV;
    }

    private void Button_Click_Event(object sender, RoutedEventArgs e)
    {
        contentcontroller.Content = eventV;
    }

    private void Button_Click_Tipps(object sender, RoutedEventArgs e)
    {
        contentcontroller.Content = besucherT;
    }

    private void Button_Click_Öffnungszeit(object sender, RoutedEventArgs e)
    {
        contentcontroller.Content = öffnungszeiten;
    }


}