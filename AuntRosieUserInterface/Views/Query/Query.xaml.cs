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
    /// Interaction logic for Query.xaml
    /// </summary>
    public partial class Query : Page
    {
        public Query()
        {
            InitializeComponent();
        }


        private void OpenProductQuery_Click(object sender, RoutedEventArgs e)
        {

            btnProductQuery.Background = new SolidColorBrush(Colors.Red);
            btnTopProducts.Background = null;
            btnLowerProducts.Background = null;

            HomeScreen.Content = null;
            //HomeScreen.Content = new ProductQuery();
        }

        private void OpenTopProducts_Click(object sender, RoutedEventArgs e)
        {

            btnProductQuery.Background = null;
            btnTopProducts.Background = new SolidColorBrush(Colors.Red);
            btnLowerProducts.Background = null;

            HomeScreen.Content = null;
            //HomeScreen.Content = new TopProducts();
        }

        private void OpenLowerProducts_Click(object sender, RoutedEventArgs e)
        {

            btnProductQuery.Background = null;
            btnTopProducts.Background = null;
            btnLowerProducts.Background = new SolidColorBrush(Colors.Red);

            HomeScreen.Content = null;
            //HomeScreen.Content = new LowerProducts();
        }
    }
}
