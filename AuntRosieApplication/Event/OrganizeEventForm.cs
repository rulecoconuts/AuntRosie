using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AuntRosieEntities;

namespace AuntRosieApplication.Event
{
    public partial class frmOrganizeEvent : Form
    {
        public frmOrganizeEvent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load background image, connect to the database and fill comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrganizeEvent_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            
            foreach (EventLocation location in EventLocation.GetLocations())
            {
                cmbLocations.Items.Add(location);
            }

            if(cmbLocations.Items.Count > 0)
            {
                cmbLocations.SelectedIndex = 0;
            }
        }

        #region helper-functions

        /// <summary>
        /// Show messages on the 'Add location' panel
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="success"></param>
        private void showLocPnlMsg(string msg, bool success)
        {
            if(success)
            {
                lblLocMsg.ForeColor = Color.Green;
            }
            else
            {
                lblLocMsg.ForeColor = Color.Red;
            }

            lblLocMsg.Text = msg;
        }

        /// <summary>
        /// Validate input on the 'Add location' panel
        /// </summary>
        /// <returns></returns>
        private bool validateAddLocation()
        {
            bool result = validateLocCity() && validateLocProvince() && validateLocStreet();

            return result;
        }

        /// <summary>
        /// Validate province in the 'Add location' panel
        /// </summary>
        /// <returns></returns>
        private bool validateLocProvince()
        {
            if (txtProvince.Text.Length < 1)
            {
                errorProvider1.SetError(txtProvince, "Province cannot be blank");
                return false;
            }

            errorProvider1.SetError(txtProvince, "");
            return true;
        }

        /// <summary>
        /// Validate city in the 'Add location' panel
        /// </summary>
        /// <returns></returns>
        private bool validateLocCity()
        {
            if (txtCity.Text.Length < 1)
            {
                errorProvider1.SetError(txtCity, "City cannot be blank");
                return false;
            }

            errorProvider1.SetError(txtCity, "");
            return true;
        }

        /// <summary>
        /// Validate street in the 'Add location' panel
        /// </summary>
        /// <returns></returns>
        private bool validateLocStreet()
        {
            if (txtStreet.Text.Length < 1)
            {
                errorProvider1.SetError(txtStreet, "Street cannot be blank");
                return false;
            }

            errorProvider1.SetError(txtStreet, "");
            return true;
        }

        private bool validateAddEventFrm()
        {
            return true;
        }

        private bool validateDate()
        {
            return true;
        }

        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            grbNew.Enabled = false;
            grbExists.Enabled = false;
            btnNext.Enabled = false;
            pnl.Visible = true;

        }
        #endregion

        /// <summary>
        /// Display panel to add location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            ViewPanel(pnlNewLoc);

        }

        private void btnNewTypeClose_Click(object sender, EventArgs e)
        {
            grbNew.Enabled = true;
            grbExists.Enabled = true;
            btnNext.Enabled = true;
            pnlNewLoc.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
             frmOrganizeEventStep2 form = new frmOrganizeEventStep2();
            form.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Add new location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewTypetClear_Click(object sender, EventArgs e)
        {
            if (validateAddLocation())
            {
                try
                {
                    Address address = new Address(txtProvince.Text, txtCity.Text, txtStreet.Text);
                    EventLocation location = new EventLocation();
                    location.Name = txtnewLocName.Text;
                    location.Address = address;
                    location.Create();

                    cmbLocations.Items.Clear();
                    foreach (EventLocation loc in EventLocation.GetLocations())
                    {
                        cmbLocations.Items.Add(loc);

                        if(location.ToString() == loc.ToString())
                        {
                            cmbLocations.SelectedItem = loc;
                        }
                    }

                    System.Diagnostics.Debug.WriteLine($"{location}");

                    showLocPnlMsg("Successfully added location", true);
                }
                catch(SqlException se)
                {
                    if(se.Message.Contains("duplicate key"))
                    {
                        showLocPnlMsg("Location already exists", false);
                    }
                }
            }
        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            btnNewTypeClose_Click(sender, e);
        }
    }
}
