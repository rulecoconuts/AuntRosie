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
    public partial class frmViewProducts : Form
    {
        BindingSource productSource = new BindingSource();
        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auntRosieDBDataSet.tblProduct' table. You can move, or remove it, as needed.
            //this.tblProductTableAdapter.Fill(this.auntRosieDBDataSet.tblProduct);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            dtgProductList.DataSource = productSource;
            loadDataInitial();
        }

        private void loadDataInitial()
        {
            addDeleteButtonToGrid();
            productSource.DataSource = Product.GetProducts();
        }

        private void addDeleteButtonToGrid()
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = "Delete";
            column.Name = "DeleteButton";
            column.Text = "Delete";
            column.UseColumnTextForButtonValue = true;
            dtgProductList.AutoGenerateColumns = true;
            dtgProductList.Columns.Add(column);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgProductList.Columns["DeleteButton"].Index)
            {
                try
                {
                    DataGridViewRow clickedRow = dtgProductList.Rows[e.RowIndex];
                    (clickedRow.DataBoundItem as Product).Delete();

                    dtgProductList.Rows.Remove(clickedRow);
                }
                catch
                {

                }
            }
        }
    }
}
