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

namespace Documents
{
    /// <summary>
    /// Logique d'interaction pour DocumentDynamique.xaml
    /// </summary>
    public partial class DocDynamique : Window
    {
        public DocDynamique()
        {
            InitializeComponent();
        }

        private void btnCreerDoc_Click(object sender, RoutedEventArgs e)
        {
            // Créer le début du paragraphe
            Run runTexteDebut = new Run();
            runTexteDebut.Text = "Début du paragraphe ";

            // Portion de texte en gras
            Bold bold = new Bold();
            Run runTexteGras = new Run();
            runTexteGras.Text = "texte en gras";
            bold.Inlines.Add(runTexteGras);

            // Créer la fin du paragraphe
            Run runTexteFin = new Run();
            runTexteFin.Text = " Fin du paragraphe.";

            // Assembler les parties dans le paragraphe
            Paragraph p = new Paragraph();
            p.Inlines.Add(runTexteDebut);
            p.Inlines.Add(bold);
            p.Inlines.Add(runTexteFin);

            // Ajouter le paragraphe au document
            docViewer.Document.Blocks.Add(p);
        }
    }
}
