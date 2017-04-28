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
using System.IO;

using System.Windows.Markup;
namespace Documents
{
    /// <summary>
    /// Logique d'interaction pour EditionDoc.xaml
    /// </summary>
    public partial class EditionDoc : Window
    {
        public EditionDoc()
        {
            InitializeComponent();
        }

        private void btnOuvrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fichiers XAML|*.xaml|Fichiers RTF|*.rtf";

            if (dialog.ShowDialog() == false) return;

            TextRange range = new TextRange(txtEdition.Selection.Start, txtEdition.Selection.End);

            using (FileStream fs = File.Open(dialog.FileName, FileMode.Open))
            {
                if (System.IO.Path.GetExtension(dialog.FileName).ToLower() == ".rtf")
                {
                    range.Load(fs, DataFormats.Rtf);
                }
                else
                {
                    range.Load(fs, DataFormats.Xaml);
                }
            }
        }

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Fichiers XAML|*.xaml|Fichiers RTF|*.rtf";

            if (dialog.ShowDialog() == false) return;

            // Créer le TextRange pour l'ensemble du document
            TextRange range = new TextRange(txtEdition.Document.ContentStart, txtEdition.Document.ContentEnd);

            using (FileStream fs = File.Create(dialog.FileName))
            {
                if (System.IO.Path.GetExtension(dialog.FileName).ToLower() == ".rtf")
                    range.Save(fs, DataFormats.Rtf);
                else
                    range.Save(fs, DataFormats.Xaml);
            }

            txtEdition.Document.Blocks.Clear();
        }
    }
}
