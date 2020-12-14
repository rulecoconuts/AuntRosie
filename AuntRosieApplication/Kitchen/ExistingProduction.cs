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
        private List<DataGridViewRow> includedProductionRows = new List<DataGridViewRow>();

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
            if (e.ColumnIndex == dtgExistingProduction.Columns["updateColumn"].Index)
            {

            }
            return false;
        }

        private bool checkForIncludeClick(DataGridViewCellEventArgs e)
        {
            int columnIndex = dtgExistingProduction.Columns["includeColumn"].Index;
            if (e.ColumnIndex == columnIndex)
            {
                DataGridViewRow clickedRow = dtgExistingProduction.Rows[e.RowIndex];
                DataGridViewCheckBoxCell includeCell = clickedRow.Cells[columnIndex] as DataGridViewCheckBoxCell;
                if(Convert.ToBoolean(includeCell.Value))
                {
                    includedProductionRows.Add(clickedRow);
                }
                else
                {
                    includedProductionRows.Remove(clickedRow);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Include production in event
        /// </summary>
        /// <param name="row">Row from a datagrid that represents the production record</param>
        private void includeProduction(DataGridViewRow row)
        {
            DataGridViewTextBoxCell quantityToTakeCell = row.Cells["quantityColumn"] as DataGridViewTextBoxCell;
            short quantityToTake = 0;
            if (short.TryParse(quantityToTakeCell.Value as string, out quantityToTake))
            {
                checkQuantityIsRightSize(quantityToTake, quantityToTakeCell, row);
            }
            else
            {
                quantityToTakeCell.ErrorText = "Quantity must be a valid integer";
            }
        }

        /// <summary>
        /// Check that the quantity is the right size and 
        /// properly handle it if it isn't
        /// </summary>
        /// <param name="quantityToTake"></param>
        /// <param name="quantityToTakeCell"></param>
        /// <param name="row"></param>
        private void checkQuantityIsRightSize(short quantityToTake,
            DataGridViewTextBoxCell quantityToTakeCell, DataGridViewRow row)
        {
            short remainingQuantity = (short)row.Cells["Remaining Quantity"].Value;
            bool isQuantityToTakeWithinRemaining = remainingQuantity >= quantityToTake;
            if (quantityToTake > 0 && isQuantityToTakeWithinRemaining)
            {
                long productionID = (long)row.Cells["ProductionID"].Value;
                includeProduction(productionID, quantityToTake);
            }
            else
            {
                quantityToTakeCell.ErrorText = $"Quantity must be between 1 and {remainingQuantity}";
            }
        }

        /// <summary>
        /// Include production in event
        /// </summary>
        /// <param name="productionID"></param>
        /// <param name="quantityToTake">Quantity of products to include in the event</param>
        private void includeProduction(long productionID, short quantityToTake)
        {
            new EventProduct(rosieEvent.Id, productionID, quantityToTake, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in includedProductionRows)
            {
                try
                {
                    includeProduction(row);
                }
                catch
                {
                    row.ErrorText = "Failed to include production in event";
                }
            }
        }
    }
}
