using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieEntities;

namespace AuntRosieApplication.Kitchen
{
    public partial class frmProduction : Form
    {
        private List<ProductItem> productItems = new List<ProductItem>();
        private List<RosieEvent> events = new List<RosieEvent>();

        public frmProduction()
        {
            InitializeComponent();
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            loadCmbs();
            /*cmbEvent.DisplayMember = "ToString()";*/
        }

        private void loadCmbs()
        {
            productItems = ProductItem.GetProductItems();

            cmbProductName.DataSource = productItems;
            cmbProductName.DisplayMember = "Product.Name";

            loadEventCmb(DateTime.Now);
        }

        private void loadEventCmb(DateTime earliestDate)
        {
            cmbEvent.Items.Clear();
            cmbEvent.Text = "";
            foreach (RosieEvent ev in RosieEvent.GetEvents(earliestDate))
            {
                cmbEvent.Items.Add(ev);
            }
            if(cmbEvent.Items.Count > 0)
            {
                cmbEvent.SelectedIndex = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clear and enable fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clear fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Save production
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int productItem = (cmbProductName.SelectedItem as ProductItem).Id;
            DateTime date = dtpProductionDate.Value.Date + dtpProductionTime.Value.TimeOfDay;
            Production prodToBeCreated = new Production();
            prodToBeCreated.ProductItemID = productItem;
            prodToBeCreated.ProductionDate = date;
            prodToBeCreated.Quantity = Convert.ToInt16(txtQuantity.Text);

            prodToBeCreated.Create();
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLoc.Text = $"Event Location: {(cmbEvent.SelectedItem as RosieEvent).EventLocation}";
        }

        private void dtpProductionDate_ValueChanged(object sender, EventArgs e)
        {
            
            loadEventCmb(dtpProductionDate.Value);
        }
    }
}
