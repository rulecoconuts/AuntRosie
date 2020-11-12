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
    /// Interaction logic for Event.xaml
    /// </summary>
    public partial class Event : Page
    {
        public Event()
        {
            InitializeComponent();

            //Display Events on Startup
            HomeScreen.Content = new ShowEvents();
        }

        private void OpenSales_Click(object sender, RoutedEventArgs e)
        {
            btnCreateEvent.Background = null;
            btnSales.Background = new SolidColorBrush(Colors.Red);

            HomeScreen.Content = null;
            HomeScreen.Content = new Sales();
        }

        /// <summary>
        /// Opens the create event page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCreateEvent_Click(object sender, RoutedEventArgs e)
        {
            btnSales.Background = null;
            btnCreateEvent.Background = new SolidColorBrush(Colors.Red);

            HomeScreen.Content = null;
            HomeScreen.Content = new CreateEvent();
        }
    }
}
