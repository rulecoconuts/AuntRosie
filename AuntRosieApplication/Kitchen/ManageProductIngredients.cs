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
    public partial class frmManageProductIngredients : Form
    {
        private BindingSource ingredientSource = new BindingSource();
        private BindingSource productItemSource = new BindingSource();

        public frmManageProductIngredients()
        {
            InitializeComponent();
        }

        private void frmManageProductIngredients_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            loadCmb();
            prepareDataGrid();
        }

        /// <summary>
        /// Prepare/setup data grid view
        /// </summary>
        private void prepareDataGrid()
        {
            addUpdateButtonColumn();
            dtgIngredients.DataSource = ingredientSource;
            dtgIngredients.AutoGenerateColumns = true;
        }

        private void loadCmb()
        {
            cmbProductName.DataSource = ProductItem.GetProductItems();
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
            dtgIngredients.Columns.Add(updateBtnColumn);
        }

        private void loadDataGrid(ProductItem productItem)
        {
            ingredientSource.DataSource = ProductIngredient.GetIngredientsTable(productItem.Id);
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(cmbProductName.SelectedItem is null))
            {
                loadDataGrid(cmbProductName.SelectedItem as ProductItem);
            }
        }

        private void dtgIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtgIngredients.Columns["updateColumn"].Index)
            {
                //Move to update window
                long ingredientID = (long)dtgIngredients.Rows[e.RowIndex].Cells["IngredientID"].Value;
                this.Close();
                frmAddProductIngredients frm = new frmAddProductIngredients(cmbProductName.SelectedItem as ProductItem,
                    ingredientID);
                frm.ShowDialog();
            }
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddProductIngredients frm = new frmAddProductIngredients();
            frm.ShowDialog();
        }
    }
}
