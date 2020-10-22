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

        private bool openInventoryIn;
        private bool openInventoryOut;
        private bool openExpiredItems;

        private void OpenInventoryIn_Click(object sender, RoutedEventArgs e)
        {
            if (!openInventoryIn)
            {
                HomeScreen.Content = new InventoryIn();
                openInventoryIn = true;

                btnInventoryOut.IsEnabled = false;
                btnExpiredItems.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                openInventoryIn = false;

                btnInventoryOut.IsEnabled = true;
                btnExpiredItems.IsEnabled = true;
            }
        }

        private void OpenInventoryOut_Click(object sender, RoutedEventArgs e)
        {
            if (!openInventoryOut)
            {
                HomeScreen.Content = new InventoryOut();
                openInventoryOut = true;

                btnExpiredItems.IsEnabled = false;
                btnInventoryIn.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                openInventoryOut = false;

                btnExpiredItems.IsEnabled = true;
                btnInventoryIn.IsEnabled = true;
            }
        }

        private void OpenExpiredItems_Click(object sender, RoutedEventArgs e)
        {
            if (!openExpiredItems)
            {
                HomeScreen.Content = new ExpiredItems();
                openExpiredItems = true;

                btnInventoryOut.IsEnabled = false;
                btnInventoryIn.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                openExpiredItems = false;

                btnInventoryOut.IsEnabled = true;
                btnInventoryIn.IsEnabled = true;
            }
        }
    }
}
