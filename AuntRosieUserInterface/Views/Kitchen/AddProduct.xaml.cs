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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        public AddProduct()
        {
            InitializeComponent();

            sp_CreateSize.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Adds Product to Product Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Checks to validate quantities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstIngredients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check validity of quantities
        }

        /// <summary>
        /// Opens the new size window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSize_Click(object sender, RoutedEventArgs e)
        {
            sp_CreateSize.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSize_Click(object sender, RoutedEventArgs e)
        {
            //Send information to database

            sp_CreateSize.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseSizeCreate_Click(object sender, RoutedEventArgs e)
        {
            sp_CreateSize.Visibility = Visibility.Hidden;
        }
    }
}
