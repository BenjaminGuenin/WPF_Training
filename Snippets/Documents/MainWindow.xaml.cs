using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Documents
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDocStatique_Click(object sender, RoutedEventArgs e)
        {
            var win = new DocStatique();
            win.ShowDialog();
        }

        private void btnDocDynamique_Click(object sender, RoutedEventArgs e)
        {
            var win = new DocDynamique();
            win.ShowDialog();
        }

        private void btnEditionDoc_Click(object sender, RoutedEventArgs e)
        {
            var win = new EditionDoc();
            win.ShowDialog();
        }

        private void btnDocReader_Click(object sender, RoutedEventArgs e)
        {
            var win = new DocReader();
            win.ShowDialog();
        }

        private void btnDocFixe_Click(object sender, RoutedEventArgs e)
        {
            var win = new DocFixe();
            win.ShowDialog();
        }       
    }
}
