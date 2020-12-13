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
    public partial class frmExistingProduction : Form
    {
        private RosieEvent rosieEvent;

        public frmExistingProduction(RosieEvent rosieEvent)
        {
            this.rosieEvent = rosieEvent;
            InitializeComponent();
        }

        private BindingSource productionSource = new BindingSource();

        public RosieEvent RosieEvent { get => rosieEvent; set => rosieEvent = value; }

        public frmExistingProduction()
        {
            InitializeComponent();
        }

        private void displayEvent()
        {
            if (rosieEvent != null)
            {
                txtEvent.Text = rosieEvent.ToString();
            }
        }

        /// <summary>
        /// Load available productions into data grid view
        /// </summary>
        private void loadProductionData()
        {
            productionSource.DataSource = Production.GetAvailableProductionsTable(RosieEvent.Id);
            //productionSource.DataSource = Production.G
        }

        /// <summary>
        /// Prepare/setup data grid view
        /// </summary>
        private void prepareDataGrid()
        {
            addUpdateButtonColumn();
            addIncludeCheckBoxColumn();
            addQuantityEntryColumn();
            dtgExistingProduction.DataSource = productionSource;
            dtgExistingProduction.AutoGenerateColumns = true;
        }

        /// <summary>
        /// Add column that contains update buttons to the
        /// production data grid view
        /// </summary>
        private void addUpdateButtonColumn()
        {
            DataGridViewButtonColumn updateBtnColumn = new DataGridViewButtonColumn();
            updateBtnColumn.HeaderText = "Update";
            updateBtnColumn.Name = "updateColumn";
            updateBtnColumn.Text = "Update";
            updateBtnColumn.UseColumnTextForButtonValue = true;
            dtgExistingProduction.Columns.Add(updateBtnColumn);
        }

        /// <summary>
        /// Add column to indicate whether a production should be included in the event
        /// </summary>
        private void addIncludeCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn includeBtnColumn = new DataGridViewCheckBoxColumn();
            includeBtnColumn.HeaderText = "Include";
            includeBtnColumn.Name = "includeColumn";
            dtgExistingProduction.Columns.Add(includeBtnColumn);
        }

        /// <summary>
        /// Add column to enter quantity of products from the production to take
        /// </summary>
        private void addQuantityEntryColumn()
        {
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Quantity to Take";
            quantityColumn.Name = "quantityColumn";
            dtgExistingProduction.Columns.Add(quantityColumn);
        }

        /// <summary>
        /// Setup the form
        /// i.e setup database connection, prepare controls and display data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExistingProduction_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            displayEvent();
            prepareDataGrid();
            loadProductionData();
        }

        private void dtgExistingProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!checkForIncludeClick(e))
            {
                checkForUpdateClick(e);
            }
        }

        private bool checkForUpdateClick(DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtgExistingProduction.Columns["updateColumn"].Index)
            {

            }
            return false;
        }

        private bool checkForIncludeClick(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgExistingProduction.Columns["includeColumn"].Index)
            {
                DataGridViewRow clickedRow = dtgExistingProduction.Rows[e.RowIndex];
                long productionID = (long)clickedRow.Cells["ProductionID"].Value;
                return true;
            }
            return false;
        }
    }
}
