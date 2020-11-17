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

namespace AuntRosieUserInterface.Views.Reports
{
    /// <summary>
    /// Interaction logic for Reports.xaml
    /// </summary>
    public partial class Reports : Page
    {
        public Reports()
        {
            InitializeComponent();

            AuntRosieDBDataSet ds = new AuntRosieDBDataSet();

        }

        /// <summary>
        /// Displays the report selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewReport_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Prints the report selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintReport_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the description box for each report type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportSelection_Changed(object sender, SelectionChangedEventArgs e)
        {

            #region Descriptions
            if (cmbReportTypes.SelectedIndex == 0)
            {
                txtDescription.Text = "This report involves the Inventory auditing reports content the expenses (cost) and revenue (sales) details with the totals for each day, week, month, year";
            }
            else if (cmbReportTypes.SelectedIndex == 1)
            {
                txtDescription.Text = "Displays the employees, whether full-time or part-time per each event.";
            }
            else if (cmbReportTypes.SelectedIndex == 3)
            {
                txtDescription.Text = "Displays the total revenue produced by sales and transactions.";
            }
            else if (cmbReportTypes.SelectedIndex == 4)
            {
                txtDescription.Text = "Displays the total expenses produced by products, ingredients, venues, and employees.";
            }
            else if (cmbReportTypes.SelectedIndex == 5)
            {
                txtDescription.Text = "Displays the ingredients that are low in stock that need to be replenished.";
            }
            else if (cmbReportTypes.SelectedIndex == 6)
            {
                txtDescription.Text = "Displays the for all nutrition information for the each product.";
            }
            else if (cmbReportTypes.SelectedIndex == 7)
            {
                txtDescription.Text = "Displays the top grossing markets with the most sales.";
            }
            else if (cmbReportTypes.SelectedIndex == 8)
            {
                txtDescription.Text = "Displays the top selling products.";
            }
            else if (cmbReportTypes.SelectedIndex == 9)
            {
                txtDescription.Text = "Displays the lowest selling products.";
            }
            else if (cmbReportTypes.SelectedIndex == 10)
            {
                txtDescription.Text = "Displays the products needed to turn a profit for a specific event.";
            }
            else if (cmbReportTypes.SelectedIndex == 11)
            {
                txtDescription.Text = "Displays the ingredients that have had their prices changed.";
            }
            else if (cmbReportTypes.SelectedIndex == 12)
            {
                txtDescription.Text = "Displays the customers that are eligible for promotions.";
            }
            else if (cmbReportTypes.SelectedIndex == 13)
            {
                txtDescription.Text = "Displays the number of purchases per customer.";
            } else
            {
                txtDescription.Text = "";
            }

            #endregion
        }
    }
}
