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
    /// Interaction logic for Inventory_Out.xaml
    /// </summary>
    public partial class InventoryOut : Page
    {
        public InventoryOut()
        {
            InitializeComponent();

            //Temporary add

            lstIngredients.Items.Add("Potatoes");
            lstIngredients.Items.Add("Onions");
            lstIngredients.Items.Add("Flour");
            lstIngredients.Items.Add("Eggs");
            lstIngredients.Items.Add("Butter");
            lstIngredients.Items.Add("Ketchup");
        }

        private void lstIngredients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check if still valid quantity in database
        }
    }
}
