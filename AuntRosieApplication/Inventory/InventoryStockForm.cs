using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieApplication.Classes;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AuntRosieApplication.Inventory
{
    public partial class frmInventoryStock : Form
    {
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public string SelectSQLCmmand = "SELECT        tblSupplier.SupplierName, tblIngredientType.TypeName, tblIngredient.IngredientName, tblIngredientInventory.PurchaseDate, tblIngredientInventory.ExpiryDate, tblIngredientInventory.Quantity, tblIngredientInventory.Unit, "+
                       "  tblIngredientInventory.Cost "+
                       " FROM            tblSupplier INNER JOIN "+
                       "  tblIngredientInventory ON tblSupplier.SupplierID = tblIngredientInventory.SupplierID INNER JOIN "+
                      "   tblIngredient ON tblIngredientInventory.IngredientID = tblIngredient.IngredientID INNER JOIN "+
                       "  tblIngredientType ON tblIngredient.IngredientTypeID = tblIngredientType.IngredientTypeID  "+
                        "WHERE         (tblIngredientInventory.Quantity > 0) ";
        public string OrderSQLCmmand = "  ORDER BY tblIngredientInventory.ExpiryDate ";



        public frmInventoryStock()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e) { }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        private void frmInventoryStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auntRosieDBDataSet.StockQuery' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'auntRosieDBDataSet.StockQuery' table. You can move, or remove it, as needed.

            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            lblTitle.Left = (this.Width - lblTitle.Width) / 2;

            cmbType.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                 (Classes.DBMethod.GetConnectionString()), cmbType);
            FillGridStock(SelectSQLCmmand + OrderSQLCmmand );

            this.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Ingredient.GetAllIngredintsByType
              (Classes.DBMethod.GetConnectionString(), DBMethod.GetSelectedItemID(cmbType)), cmbName);
           

            chkAllIngrdient.Checked = false;
            string wherSQLCmmand = " and  tblIngredient.IngredientTypeID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
            FillGridStock(SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand);

            chkAllTypies.Checked = false;
            cmbName.Enabled = true;
            chkAllIngrdient.Enabled = true;
            chkAllIngrdient.Checked = true;


        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wherSQLCmmand = " and  tblIngredientInventory.IngredientID= " + DBMethod.GetSelectedItemID(cmbName) + " ";
            FillGridStock(SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand);
            chkAllIngrdient.Checked = false;
        }
        private void FillGridStock( string sql)
        {
            
            string connectionString = DBMethod.GetConnectionString();
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Stock_query");
            connection.Close();
            grdStock.DataSource = ds;
            grdStock.DataMember = "Stock_query";
        }

        private void radExpry_CheckedChanged(object sender, EventArgs e)
        {

            if (grdStock.Rows.Count == 0)
            {
                btnDestroy.Enabled = true;
            }
            {
                MessageBox.Show("No Expierd Items ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string curdhead = "Inventory Stock";
            e.Graphics.DrawString(curdhead, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 350, 50);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 100);

            //ExpiryDate, tblIngredientInventory.Quantity, tblIngredientInventory.Unit
            string g1 = "SupplierName ";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 140);

            string g2 = "TypeName";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 100, 140);

            string g3 = "IngredientName";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 200, 140);

            string g4 = "PurchaseDate";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 300, 140);

            string g5 = "ExpiryDate";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 400, 140);

            string g6 = "Quantity";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 500, 140);
            string g7 ="Unit";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 600, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < grdStock.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= grdStock.Rows.Count)
                    {

                        height += grdStock.Rows[0].Height;
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[0].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(0, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[1].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(100, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[2].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(200, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[3].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(300, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[4].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(400, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[5].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(500, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[6].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(600, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));


                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllTypies.Checked)
            {
                cmbType.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                     (Classes.DBMethod.GetConnectionString()), cmbType);
                FillGridStock(SelectSQLCmmand + OrderSQLCmmand);
                cmbName.Items.Clear();
                cmbName.Enabled = false;
                chkAllIngrdient.Enabled = false;
                FillGridStock(SelectSQLCmmand + OrderSQLCmmand);

            }
        }

        private void chkExpierd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpierd.Checked)
            {
                string whereExpirySQLSelect= " and  tblIngredientInventory.ExpiryDate < '" + DateTime.Today.Date.ToShortDateString() + "' ";
                if (chkAllTypies.Checked)
                {
                   // MessageBox.Show(SelectSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand);

                    FillGridStock(SelectSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand);
                   
                }
                else
                {
                    if(chkAllIngrdient.Checked)
                    {
                        string wherSQLCmmand = " and  tblIngredientInventory.IngredientID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
                        FillGridStock(SelectSQLCmmand + wherSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand);
              
                    }
                    else
                    {
                        string wherSQLCmmand = " and  tblIngredient.IngredientTypeID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
                        FillGridStock(SelectSQLCmmand + wherSQLCmmand+  whereExpirySQLSelect+ OrderSQLCmmand);

                    }
                }
                 


            }
            else
            {

                if (chkAllTypies.Checked)
                {
                    // MessageBox.Show(SelectSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand);

                    FillGridStock(SelectSQLCmmand + OrderSQLCmmand);

                }
                else
                {
                    if (chkAllIngrdient.Checked)
                    {
                        string wherSQLCmmand = " and  tblIngredientInventory.IngredientID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
                        FillGridStock(SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand);

                    }
                    else
                    {
                        string wherSQLCmmand = " and  tblIngredient.IngredientTypeID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
                        FillGridStock(SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand);

                    }
                }



            }
        }
    }
}
