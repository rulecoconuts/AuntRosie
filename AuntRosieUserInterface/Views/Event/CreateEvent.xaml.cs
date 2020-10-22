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

namespace AuntRosieUserInterface.Views.Event
{
    /// <summary>
    /// Interaction logic for CreateEvent.xaml
    /// </summary>
    public partial class CreateEvent : Page
    {
        public CreateEvent()
        {
            InitializeComponent();

            EnableLocation(false);
            btnSubmitNewLocation.Visibility = Visibility.Hidden;
            btnSubmitHelper.IsEnabled = false;

            //Temporary Output
            cmbLocations.Items.Add("North Bay Market");
            cmbLocations.Items.Add("HillCrest Farm");
            cmbLocations.Items.Add("South SIde Farm");

            lstHelpers.Items.Add("Christy Margaret");
            lstHelpers.Items.Add("John Alimony");
        }

        /// <summary>
        /// Sets the location inputs based on input
        /// </summary>
        /// <param name="value"></param>
        private void EnableLocation(bool value)
        {
            if (value)
            {
                txtNewLocationName.Text = "Location Name";
                txtNewLocationProvince.Text = "Province";
                txtNewLocationCity.Text = "City";
                txtNewLocationStreet.Text = "Street";
            }

            btnSubmitNewLocation.Visibility = Visibility.Visible;
            txtNewLocationName.IsEnabled = value;
            txtNewLocationProvince.IsEnabled = value;
            txtNewLocationCity.IsEnabled = value;
            txtNewLocationStreet.IsEnabled = value;
        }

        /// <summary>
        /// Submits new location to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitNewLocation_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        //Creates a new location field to be added to locations table
        private void NewLocation_Click(object sender, RoutedEventArgs e)
        {
            EnableLocation(true);
        }

        /// <summary>
        /// Adds information to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateEvent_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        /// <summary>
        /// Will prompt each persons task to the textbox which can be changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstHelpers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //If no helpers are selected, disable submit button
            if(lstHelpers.SelectedIndex >= 0)
            {
                btnSubmitHelper.IsEnabled = true;
            } else
            {
                btnSubmitHelper.IsEnabled = false;
            }

            //Temporary Output
            if(lstHelpers.SelectedIndex == 0)
            {
                txtRole.Text = "Cashier";
                
            } else if (lstHelpers.SelectedIndex == 1)
            {
                txtRole.Text = "Baker";
            } 
        }

        /// <summary>
        /// Creates a new helper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitNewHelper_Click(object sender, RoutedEventArgs e)
        {
            lstHelpersList.Items.Add(lstHelpers.SelectedItem.ToString() + " | " + txtRole.Text);
        }
    }
}
