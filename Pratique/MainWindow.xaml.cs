using System.Windows;

namespace Pratique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTerrainSansServiceClick(object sender, RoutedEventArgs e)
        {
            Service[] services = GetServicesFromWpfInterface();
            var terrainSauvage = new TerrainSauvage(services);
            TbCoutEstime.Text = terrainSauvage.CalculerCout().ToString("0.00$");
        }

        public void OnTerrainAvecServicesClick(object sender, RoutedEventArgs e)
        {
            Service[] services = GetServicesFromWpfInterface();
            var terrainAvecServices = new TerrainAvecServices(services);
            TbCoutEstime.Text = terrainAvecServices.CalculerCout().ToString("0.00$");
        }

        private Service[] GetServicesFromWpfInterface()
        {
            return [
                new Service(10, CkBxAvec20A.IsChecked.Value),
                new Service(15, CkBxAvecEgouts.IsChecked.Value)
            ];
        }
    }
}