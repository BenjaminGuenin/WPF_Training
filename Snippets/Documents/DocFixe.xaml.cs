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
using System.Windows.Shapes;

using Microsoft.Win32;
using System.Windows.Xps.Packaging; // Ref sur ReachFramework

namespace Documents
{
    /// <summary>
    /// Logique d'interaction pour DocFixe.xaml
    /// </summary>
    public partial class DocFixe : Window
    {
        public DocFixe()
        {
            InitializeComponent();
        }

        private void btnOuvrirDoc_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fichiers XPS|*.xps";

            if (dialog.ShowDialog() == false) return;

            var xps = new XpsDocument(dialog.FileName, System.IO.FileAccess.Read);
            docViewer.Document = xps.GetFixedDocumentSequence();
            xps.Close();
        }
    }
}
