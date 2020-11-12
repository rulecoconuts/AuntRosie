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

namespace AuntRosieUserInterface.Views.Query
{
    /// <summary>
    /// Interaction logic for LowerProducts.xaml
    /// </summary>
    public partial class LowerProducts : Page
    {
        public LowerProducts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sends requests to database, retrieves data and populates table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
