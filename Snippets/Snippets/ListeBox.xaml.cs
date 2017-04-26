using System;
using System.Windows;
using System.Windows.Controls;

namespace Snippets
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

        private void Liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lbi = Liste.SelectedItem as ListBoxItem;
            lblMsg.Text = lbi.Content.ToString();
        }

        private void BtnSelection_OnClick(object sender, RoutedEventArgs e)
        {
            lblMsg.Text = string.Empty;
            foreach (ListBoxItem lbi in Liste.SelectedItems)
            {
                lblMsg.Text += lbi.Content.ToString() + Environment.NewLine; 
            }
        }

        private void BtnSelectionCheckbox_OnClick(object sender, RoutedEventArgs e)
        {
            lblMsgCheckbox.Text = string.Empty;
            foreach (CheckBox cb in Liste.Items)
            {
                if (cb.IsChecked == true)
                    lblMsgCheckbox.Text += cb.Content.ToString() + Environment.NewLine;
            }
        }

        private void ListeCheckbox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckBox cb = Liste.SelectedItem as CheckBox;
            lblMsgCheckbox.Text = cb.Content.ToString();
        }
    }
}
