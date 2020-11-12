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

namespace AuntRosieUserInterface.Views.Employment
{
    /// <summary>
    /// Interaction logic for Payroll.xaml
    /// </summary>
    public partial class Payroll : Page
    {
        public Payroll()
        {
            InitializeComponent();
            sp_CreateSlip.Visibility = Visibility.Hidden;

            //Temporary Display

        }

        /// <summary>
        /// Opens the payroll creation page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPayroll_Click(object sender, RoutedEventArgs e)
        {
            sp_CreateSlip.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Closes the slip create screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCustomerSlip_Click(object sender, RoutedEventArgs e)
        {
            sp_CreateSlip.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Submits the slip to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitSlip_Click(object sender, RoutedEventArgs e)
        {
            sp_CreateSlip.Visibility = Visibility.Hidden;
        }


        /// <summary>
        /// Retrieves data from database of payroll members in range of dates specified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    
}
