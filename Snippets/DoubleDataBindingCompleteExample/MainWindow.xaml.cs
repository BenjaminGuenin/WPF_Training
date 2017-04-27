using System.Windows;
using DoubleDataBindingCompleteExample.BLL;

namespace DoubleDataBindingCompleteExample
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Articles _articles = new Articles();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAfficherArticle_Click(object sender, RoutedEventArgs e)
        {
            panelContexte.DataContext = _articles.Australie;
        }

        private void btnModifierArticle_Click(object sender, RoutedEventArgs e)
        {
            _articles.Australie.Description += "Maj";
            _articles.Australie.Destination += "Maj";
            _articles.Australie.CodeVoyage += "Maj";
            _articles.Australie.Duree += 10;
            _articles.Australie.Description += "Maj";
            _articles.Australie.Prix += 10;
        }

        private void btnAfficherCollection_Click(object sender, RoutedEventArgs e)
        {
            ListeArt.ItemsSource = _articles.ListeArticles;
        }

        private void btnModifierCollection_Click(object sender, RoutedEventArgs e)
        {
            //ListeArt.ItemsSource = _articles.ListeArticles;
            //ListeArt.SelectedIndex = 0;
            //ListeArt.Focus();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            ListeArt.ItemsSource = _articles.ListeArticles;
            ListeArt.SelectedIndex = 0;
            ListeArt.Focus();
        }
    }
}
