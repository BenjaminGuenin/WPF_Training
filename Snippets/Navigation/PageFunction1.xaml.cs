﻿using System;
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
    /// Logique d'interaction pour PageFunction1.xaml
    /// </summary>
    public partial class PageFunction1 : PageFunction<String>
    {
        public PageFunction1()
        {
            InitializeComponent();
        }

        private void lienOk_Click(object sender, RoutedEventArgs e)
        {
            this.OnReturn(new ReturnEventArgs<string>(txtValeur.Text));
        }

        private void lienAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.OnReturn(null);
        }
    }
}
