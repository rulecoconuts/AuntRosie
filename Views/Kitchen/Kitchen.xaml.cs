using System;
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

namespace AuntRosieUserInterface.Views.Kitchen
{
    /// <summary>
    /// Interaction logic for Kitchen.xaml
    /// </summary>
    public partial class Kitchen : Page
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to addProduct Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void addProduct_Click (object sender, RoutedEventArgs e)
        {
            btnAddProduct.Background = new SolidColorBrush(Colors.Red);
            btnManageProducts.Background = null;
            btnProduction.Background = null;

            HomeScreen.Content = null;
            HomeScreen.Content = new AddProduct();
        }

        /// <summary>
        /// Navigates to ProductManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenProductManager_Click(object sender, RoutedEventArgs e)
        {

            btnAddProduct.Background = null;
            btnManageProducts.Background = new SolidColorBrush(Colors.Red);
            btnProduction.Background = null;

            HomeScreen.Content = null;
            HomeScreen.Content = new ProductManager();
        }

        /// <summary>
        /// Navigates to Production page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenProduction_Click(object sender, RoutedEventArgs e)
        {
            btnAddProduct.Background = null;
            btnManageProducts.Background = null;
            btnProduction.Background = new SolidColorBrush(Colors.Red);

            HomeScreen.Content = null;
            HomeScreen.Content = new AddProduction();
        }
    }


}
