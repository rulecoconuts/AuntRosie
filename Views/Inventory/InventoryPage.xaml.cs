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

namespace AuntRosieUserInterface.Views.Inventory
{
    /// <summary>
    /// Interaction logic for InventoryPage.xaml
    /// </summary>
    public partial class InventoryPage : Page
    {
        public InventoryPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the Inventory In page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenInventoryIn_Click(object sender, RoutedEventArgs e)
        {
            btnInventoryIn.Background = new SolidColorBrush(Colors.Red);
            btnInventoryOut.Background = null;
            btnExpiredItems.Background = null;


            HomeScreen.Content = null;
            HomeScreen.Content = new InventoryIn();
        }

        /// <summary>
        /// Opens the inventory out page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenInventoryOut_Click(object sender, RoutedEventArgs e)
        {
            btnInventoryIn.Background = null;
            btnInventoryOut.Background = new SolidColorBrush(Colors.Red);
            btnExpiredItems.Background = null;

            HomeScreen.Content = null;
            HomeScreen.Content = new InventoryOut();
        }

        /// <summary>
        /// Opens the expired items page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenExpiredItems_Click(object sender, RoutedEventArgs e)
        {
            btnInventoryIn.Background = null;
            btnInventoryOut.Background = null;
            btnExpiredItems.Background = new SolidColorBrush(Colors.Red);

            HomeScreen.Content = null;
            HomeScreen.Content = new ExpiredItems();
        }
    }
}
