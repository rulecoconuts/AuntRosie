﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuntRosieUserInterface.Views.Inventory
{
    /// <summary>
    /// Interaction logic for Supplier.xaml
    /// </summary>
    public partial class Supplier : Page
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void submitSupplier_Click(object sender, RoutedEventArgs e)
        {
            ///
        }

        private void return_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.GoBack();
        }
    }
}
