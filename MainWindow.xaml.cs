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

using AuntRosieUserInterface.Views.Inventory;
using AuntRosieUserInterface.Views.Kitchen;
using AuntRosieUserInterface.Views.Event;
using AuntRosieUserInterface.Views.Expenses;
using AuntRosieUserInterface.Views.Reports;
using AuntRosieUserInterface.Views.Query;
using AuntRosieUserInterface.Views.Employment;


namespace AuntRosieUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Prompt for login screen
            Login getLogin = new Login();
            getLogin.ShowDialog();

            if (!getLogin.isAdmin && !getLogin.isEmployee)
            {
                Close();
            } 
            else if (!getLogin.isAdmin && getLogin.isEmployee)
            {
                employeeView(); //Disables other employment views
            }

            lblTime.Content = DateTime.Now;
        }

        /// <summary>
        /// Shows the tooltips in the listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (PieButton.IsChecked == true)
            {
                tt_Inventory.Visibility = Visibility.Collapsed;
                tt_Kitchen.Visibility = Visibility.Collapsed;
                tt_Event.Visibility = Visibility.Collapsed;
                tt_Expenses.Visibility = Visibility.Collapsed;
                tt_Reports.Visibility = Visibility.Collapsed;
                tt_Query.Visibility = Visibility.Collapsed;
                tt_Employment.Visibility = Visibility.Collapsed;
                tt_SignOut.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_Inventory.Visibility = Visibility.Visible;
                tt_Kitchen.Visibility = Visibility.Visible;
                tt_Event.Visibility = Visibility.Visible;
                tt_Expenses.Visibility = Visibility.Visible;
                tt_Reports.Visibility = Visibility.Visible;
                tt_Query.Visibility = Visibility.Visible;
                tt_Employment.Visibility = Visibility.Visible;
                tt_SignOut.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Produces the admin
        /// </summary>
        private void employeeView()
        {
            btnQuery.IsEnabled = false;
            btnReports.IsEnabled = false;
            btnExpenses.IsEnabled = false;
            btnEmployment.IsEnabled = false;

            lvExpenses.Content = "";
            lvReports.Content = "";
            lvQuery.Content = "";
            lvEmployment.Content = "";

        }


        private void pieButtonUnchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void pieButtonChecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void MainGridActionButton(object sender, MouseButtonEventArgs e)
        {
            PieButton.IsChecked = false;
        }
        
        /// <summary>
        /// Signs out of the current page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Opens the Inventory Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenInventory_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = null;
            HomeScreen.Content = new InventoryPage();
        }

        /// <summary>
        /// Opens the Kitchen Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenKitchen_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = null;
            HomeScreen.Content = new Kitchen();
        }

        /// <summary>
        /// Opens the Event Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenEvent_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = null;
            HomeScreen.Content = new Event();
        }

        /// <summary>
        /// Opens the Expenses Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenExpenses_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = null;
            HomeScreen.Content = new Expenses();
        }

        /// <summary>
        /// Opens the Reports Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenReports_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = null;
            HomeScreen.Content = new Reports();
        }

        /// <summary>
        /// Opens the Query Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenQuery_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = null;
            HomeScreen.Content = new Query();
        }

        /// <summary>
        /// Opens the Employment Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenEmployment_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen.Content = null;
            HomeScreen.Content = new Employment();
        }
    }
}