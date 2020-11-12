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
    /// Interaction logic for ProductQuery.xaml
    /// </summary>
    public partial class ProductQuery : Page
    {
        public ProductQuery()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sends request to the database and returns data if found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
