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

namespace Navigation
{
    /// <summary>
    /// Logique d'interaction pour Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private int _donneePage2 = 0;
        public Page2()
        {
            InitializeComponent();
        }

        // Ctor avec argument, avec appel du Ctor par défaut pour appeler InitializeComponent
        public Page2(int Donnee)
            : this()
        {
            _donneePage2 = Donnee;
            lblMsg.Text = "Donnée reçu : " + _donneePage2.ToString();
        }

        private void btnRetourVersPage1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();            
        }

    }
}
