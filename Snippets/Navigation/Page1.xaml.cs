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

using System.Diagnostics;
namespace Navigation
{
    /// <summary>
    /// Logique d'interaction pour Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            this.Initialized += new EventHandler(Page1_Initialized);
            InitializeComponent();
        }

        void Page1_Initialized(object sender, EventArgs e)
        {
            Debug.WriteLine("Instanciation de Page1");
        }

        private void btnAfficherMsg_Click(object sender, RoutedEventArgs e)
        {
            lblMsg.Text = "Un message";
        }

        private void btnNaviguerVersUriPage2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }

        private void btnNaviguerVersObjetPage2_Click(object sender, RoutedEventArgs e)
        {
            var p2 = new Page2(12);
            this.NavigationService.Navigate(p2);
        }

        private void btnFonctionPage_Click(object sender, RoutedEventArgs e)
        {
            var pageFonction = new PageFunction1();
            pageFonction.Return += new ReturnEventHandler<string>(pageFonction_Return);
            this.NavigationService.Navigate(pageFonction);
        }

        void pageFonction_Return(object sender, ReturnEventArgs<string> e)
        {
            if (e != null)
            {
                lblMsg.Text = "Valeur de retour : " + e.Result;
            }
        }

    }
}
