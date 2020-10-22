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
    /// Interaction logic for Inventory_In.xaml
    /// </summary>
    public partial class InventoryIn : Page
    {
        public InventoryIn()
        {
            InitializeComponent();
        }

        private void submitInventory_Click(object sender, RoutedEventArgs e)
        {
            ///
        }

        private void AddSupplier_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = new Supplier();
        }
    }
}
