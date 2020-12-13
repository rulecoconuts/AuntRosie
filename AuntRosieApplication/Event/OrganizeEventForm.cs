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
        RosieEvent curEvent = null;
        SqlTransaction transaction = null;
        Dictionary<string, EventType> types = new Dictionary<string, EventType>()
        {
            { "Farmers Market", EventType.FarmersMarket},
            {"HomeShow", EventType.HomeShow },
            {"Other", EventType.Other}
        };

        public frmOrganizeEvent()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e) { }


        public frmOrganizeEvent(RosieEvent curEvent, SqlTransaction transaction)
        {
            this.curEvent = curEvent;
            this.transaction = transaction;
            InitializeComponent();
            loadEvent(curEvent);
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

            if (cmbLocations.Items.Count > 0)
            {
                cmbLocations.SelectedIndex = 0;
            }

            foreach (KeyValuePair<string, EventType> item in types)
            {
                cmbTypes.Items.Add(item);
            }
            cmbTypes.SelectedIndex = 0;
            cmbTypes.DisplayMember = "Key";
        }

        #region helper-functions

        private void loadEvent(RosieEvent ev)
        {
            if (ev != null)
            {
                txtEventName.Text = ev.Name;
                EventLocation locToBeSelected = findEquivalentInCombobox(ev.EventLocation);
                if (locToBeSelected != null)
                {
                    cmbLocations.SelectedItem = locToBeSelected;
                }
            }
        }

        private EventLocation findEquivalentInCombobox(EventLocation loc)
        {
            foreach (EventLocation cmbLoc in cmbLocations.Items)
            {
                if (cmbLoc.ToString() == loc.ToString())
                {
                    return cmbLoc;
                }
            }

            return null;
        }

        /// <summary>
        /// Show messages on the 'Add location' panel
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="success"></param>
        private void showLocPnlMsg(string msg, bool success)
        {
            if (success)
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
            return validateDate();
        }

        private bool validateDate()
        {
            if (dtpFormDate.Value.Date < DateTime.Today.Date)
            {
                errorProvider1.SetError(dtpFormDate, "Date must be in the future");
                return false;
            }

            return true;
        }

        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            grbExists.Enabled = false;
            grbNew.Enabled = false;
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

        private void goToNextStepForEvent(RosieEvent subject)
        {
            this.Hide();
            AuntRosieApp.frmHome.formStep2.RosieEvent = subject;
            AuntRosieApp.frmHome.formStep2.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radNew.Checked)
            {
                if (validateAddEventFrm())
                {
                    RosieEvent ev = new RosieEvent();
                    ev.EventDate = dtpFormDate.Value;
                    ev.LocationId = (cmbLocations.SelectedItem as EventLocation).Id;
                    ev.Name = txtEventName.Text;
                    ev.Type = ((KeyValuePair<string, EventType>)cmbTypes.SelectedItem).Value;
                    //SqlTransaction transaction = RosieEntity.Connector.Connection.BeginTransaction();
                    ev.Create();
                    RosieEvent createdEvent = RosieEvent.Retrieve(ev.EventDate, ev.LocationId);
                    goToNextStepForEvent(createdEvent);

                }
            }
            else
            {
                if (dgEvents.SelectedRows.Count > 0)
                {
                    goToNextStepForEvent(dgEvents.SelectedRows[0].DataBoundItem as RosieEvent);
                }
            }

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

                        if (location.ToString() == loc.ToString())
                        {
                            cmbLocations.SelectedItem = loc;
                        }
                    }

                    System.Diagnostics.Debug.WriteLine($"{location}");

                    showLocPnlMsg("Successfully added location", true);
                }
                catch (SqlException se)
                {
                    if (se.Message.Contains("duplicate key"))
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

        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radNew.Checked)
            {
                radExisting.Checked = false;
            }
        }

        private void radExisting_CheckedChanged(object sender, EventArgs e)
        {
            

            if (radExisting.Checked)
            {
                radNew.Checked = false;
                dgEvents.DataSource = RosieEvent.GetEvents(DateTime.Now);
            }
        }

        private void dgEvents_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
