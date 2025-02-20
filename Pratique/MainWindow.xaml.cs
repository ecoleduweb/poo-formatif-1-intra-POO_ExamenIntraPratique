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
            // La variable services est un tableau de deux services. Simplement enlever les commentaires pour que le code fonctionne.
            //Service[] services = GetServicesFromWpfInterface();

            // crée l'objet terrainSauvage.
            // modifie la valeur du TextBock à partir du résultat de la méthode CalculerCout() de terrainSauvage.
        }

        public void OnTerrainAvecServicesClick(object sender, RoutedEventArgs e)
        {
            // La variable services est un tableau de deux services. Simplement enlever les commentaires pour que le code fonctionne.
            //Service[] services = GetServicesFromWpfInterface();

            // crée l'objet terrainAvecServices.
            // modifie la valeur du TextBock à partir du résultat de la méthode CalculerCout() de terrainAvecServices.
        }

        // J'ai mis la métode ici en commentaire. En ajoutant ta classe Service, le code que j'ai ici ne devrait plus être en erreur.
        // Assures-toi de mettre la coût et ensuite le boolean dans le constructeur de Service.
        //private Service[] GetServicesFromWpfInterface()
        //{
        //    return [
        //        new Service(10, CkBxAvec20A.IsChecked.Value),
        //        new Service(15, CkBxAvecEgouts.IsChecked.Value)
        //    ];
        //}
    }
}