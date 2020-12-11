using System;
 
using System.Data;
 
using System.Data.SqlClient;
 
using System.Windows.Forms;
using AuntRosieApplication.Classes;
using AuntRosieEntities;
namespace AuntRosieApplication.Event
{
    public partial class frmSale : Form
    {

        public long SaleID = -1;
        public frmSale()
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.saleDet' table. You can move, or remove it, as needed.
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            cmbCustomerName.Items.Clear();
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Customer.GetAllCustomer
                (Classes.DBMethod.GetConnectionString()), cmbCustomerName);

            cmbEventName.Items.Clear();
        FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                (Classes.DBMethod.GetConnectionString(), DateTime.Today.Date.ToShortDateString()), cmbEventName);
            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ViewPanel(pnlNewcustomer);
            
            pnlMain.Enabled = false;
            pnlButton.Enabled = false;

        }

        #region helpper-functions
        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            pnl.Visible = true;
        }
        #endregion

        private void btnNewTypeClose_Click(object sender, EventArgs e)
        {
            pnlNewcustomer.Visible = false;
            pnlMain.Enabled = true;
        }

        private void pnlNewcustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool GetValidationStatus()
        {
            bool isValid = true;
             
            if (txtFirstName.Text.Trim().Length < 3)
            {
                errCustomer.SetError(txtFirstName, "Customer Contact first name should be 3 letters at least");
                isValid = false;

            }
            if (txtLastName.Text.Trim().Length < 3)
            {
                errCustomer.SetError(txtLastName, "Customer Contact last name should be 3 letters at least");
                isValid = false;

            }

            if (!DBMethod.IsValidEmail(txtEmail.Text.Trim()))
            {
                errCustomer.SetError(txtEmail, "Entred Customer Email is not a valid email address");
                isValid = false;

            }
            if (txtPhone.Text.Trim().Length != 14)
            {
                errCustomer.SetError(txtPhone, "Entred Phone is not a valid phone number");
                isValid = false;

            }
            return isValid;
        }

        private void btnNewTypetClear_Click(object sender, EventArgs e)
        {
           bool  isValid = GetValidationStatus();
            if (isValid)
            {
                newCustomer();
                
                pnlNewcustomer.Visible = false;
                pnlMain.Enabled = true;
                pnlButton.Enabled = true;

            }
        }
        private void newCustomer()
        {


            AuntRosieEntities.Customer insertCustomer = new AuntRosieEntities.Customer();

            insertCustomer.FirstName = txtFirstName.Text.Trim();
            insertCustomer.LastName = txtLastName.Text.Trim();
            insertCustomer.Phone = txtPhone.Text.Trim();
            insertCustomer.Email = txtEmail.Text.Trim();



            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                insertCustomer.Create();
                cmbCustomerName.Items.Clear();
                Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Customer.GetAllCustomer
                    (Classes.DBMethod.GetConnectionString()), cmbCustomerName);

                cmbCustomerName.SelectedItem = cmbCustomerName.Items[cmbCustomerName.Items.Count - 1];

                MessageBox.Show("The new Customer has been inserted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
                //MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            pnlNewcustomer.Visible = false;
            pnlMain.Enabled = true;
            pnlButton.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
             
             }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = true;
            btnClear.Enabled = true;
            btnSave.Enabled = true;
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCustomerName.Items.Clear();
                Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Customer.GetAllCustomerByLastName
                    (Classes.DBMethod.GetConnectionString(), cmbCustomerName.Text.Trim()), cmbCustomerName);
                if ( cmbCustomerName.Items.Count>0)
                {
                    cmbCustomerName.SelectedItem = cmbCustomerName.Items[0];
                }
               
            }
        }

        private void chkGuest_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomerName.SelectedItem = null;
            if (chkGuest.Checked)
            {
                cmbCustomerName.Enabled = false;
                btnAddCustomer.Enabled = false;


            }
            else
            {
                cmbCustomerName.Enabled = true;
                btnAddCustomer.Enabled = true;

            }
        }

        private void radLastMonth_CheckedChanged(object sender, EventArgs e)
        {
            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                (Classes.DBMethod.GetConnectionString(), (DateTime.Today.Date.AddMonths(-1)).ToShortDateString()), cmbEventName);

        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEvent
                (Classes.DBMethod.GetConnectionString()), cmbEventName);

        }

        private void radToday_CheckedChanged(object sender, EventArgs e)
        {
            
            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                    (Classes.DBMethod.GetConnectionString(), DateTime.Today.Date.ToShortDateString()), cmbEventName);

        }

        private void FillCombBoxEvent(DataTable dt, ComboBox cmb) 
        {

             
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                    itm.name = row[1].ToString() + "--ON " + DateTime.Parse(row[2].ToString()).ToLongDateString();
                        itm.id = row[0].ToString();
                        cmb.Items.Add((Object)itm);
                    }
                }
             
        }

        private void cmbEventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            RosieEvent rosieEvent = RosieEvent.Retrieve  ( long.Parse(DBMethod.GetSelectedItemID(cmbEventName)));
            EventLocation locEvent = EventLocation.Retrieve(rosieEvent.LocationId);
            lblEventLocation.Text += locEvent.Address.ToString();
            FillProduct(DBMethod.GetSelectedItemID(cmbEventName));


        }

        private void FillProduct (String eventID)
        {
           string sqlEventText = "SELECT  tblEventProduct.EventProductID, tblProduct.ProductName, tblProduct.ProductType " +
            "FROM tblEventProduct INNER JOIN " +
            "tblProduction ON tblEventProduct.ProductionID = tblProduction.ProductionID INNER JOIN " +
            "tblProductItem ON tblProduction.ProductItemID = tblProductItem.ProductItemID INNER JOIN " +
            "tblProductSize ON tblProductItem.SizeID = tblProductSize.SizeID INNER JOIN " +
            "tblProduct ON tblProductItem.ProductID = tblProduct.ProductID " +
            " WHERE        tblEventProduct.EventID = " + eventID;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand(sqlEventText, dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable productTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(productTable);

                DBMethod.FillCombBoxPerson(productTable, cmbProduct);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated DataTable
            
         


        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            EventProduct product = EventProduct.Retrieve( short.Parse(DBMethod.GetSelectedItemID(cmbProduct)));
            ndpQuanitity.Maximum =  product.Quantity - product.SoldQuantity;
            //
            conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            Production production = Production.Retrieve(product.ProductionId);
            //
            conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            ProductItem productItem = ProductItem.Retrieve(production.ProductItemID);
            lblItemPrice.Text =   productItem.Price.ToString("C");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {     
            if (grdSale.Rows.Count==0)
            {
                Sale newSale = new Sale();
                newSale.PaymentMethod = DBMethod.GetSelectedItemID(cmbPaymentMethod);
                newSale.SaleDate = DateTime.Today;
                if (chkGuest.Checked)
                {
                    newSale.CustomerId = 0;
                }
                else
                {
                    newSale.CustomerId = long.Parse( DBMethod.GetSelectedItemID(cmbCustomerName));
                }
                DBConnector conn1 = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn1;
                newSale.Create();
                SaleID = Sale.RetrieveMax();
            }
            //MessageBox.Show(SaleID.ToString());
            SaleProduct newSaleProduct = new SaleProduct();
            newSaleProduct.SaleId= SaleID;
            newSaleProduct.SaleQuantity = int.Parse( ndpQuanitity.Value.ToString());
            newSaleProduct.SalePrice = Double.Parse(lblItemPrice.Text.Substring(1));
            newSaleProduct.EventProductId =  long.Parse(DBMethod.GetSelectedItemID(cmbProduct));
            DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            newSaleProduct.Create();
           

             fillSaleGrid();
        }

        private void fillSaleGrid ()
        {
            String sql = "SELECT        tblSale.SaleID, tblSaleProducts.SaleQuantity, tblSaleProducts.SalePrice, tblSaleProducts.SaleQuantity * tblSaleProducts.SalePrice AS itemCost, tblCustomer.CustomerFirstName, tblCustomer.CustomerLastName," +
                           " tblSale.SaleDateTime, tblSale.PaymentMethod, tblProductSize.SizeName, tblProduct.ProductName " +
                           " FROM            tblSaleProducts INNER JOIN " +
                            " tblSale ON tblSaleProducts.SaleID = tblSale.SaleID INNER JOIN " +
                            " tblCustomer ON tblSale.CustomerID = tblCustomer.CustomerID INNER JOIN " +
                            " tblEventProduct ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID INNER JOIN " +
                            " tblProduction ON tblEventProduct.ProductionID = tblProduction.ProductionID INNER JOIN " +
                            " tblProductItem ON tblProduction.ProductItemID = tblProductItem.ProductItemID INNER JOIN " +
                            " tblProductSize ON tblProductItem.SizeID = tblProductSize.SizeID INNER JOIN " +
                            " tblProduct ON tblProductItem.ProductID = tblProduct.ProductID " +
                            " WHERE(tblSale.SaleID = " + SaleID.ToString() + ")";

            string connectionString = DBMethod.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql,connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "SaleDet");
            connection.Close();
           grdSale.DataSource = ds;
            grdSale.DataMember = "SaleDet";
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
