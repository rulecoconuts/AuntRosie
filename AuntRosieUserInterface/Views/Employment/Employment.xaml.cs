using AuntRosieUserInterface.Views.Kitchen;
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
    /// Interaction logic for Employment.xaml
    /// </summary>
    public partial class Employment : Page
    {

        public Employment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the Add Employee Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAddEmployee_Click(object sender, RoutedEventArgs e)
        {
                btnAddEmployee.Background = new SolidColorBrush(Colors.Red);
                btnManage.Background = null;
                btnPayroll.Background = null;

                HomeScreen.Content = null;
                HomeScreen.Content = new AddEmployee();
        }

        /// <summary>
        /// Opens Payroll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPayroll_Click(object sender, RoutedEventArgs e)
        {
            btnAddEmployee.Background = null;
            btnManage.Background = null;
            btnPayroll.Background = new SolidColorBrush(Colors.Red);

            HomeScreen.Content = null;
            HomeScreen.Content = new Payroll();
        }

        /// <summary>
        /// Opens Employee Manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenManageEmployee_Click(object sender, RoutedEventArgs e)
        {
            btnAddEmployee.Background = null;
            btnManage.Background = new SolidColorBrush(Colors.Red);
            btnPayroll.Background = null;

            HomeScreen.Content = null;
            HomeScreen.Content = new ManageEmployee();
        }
    }

    
}
