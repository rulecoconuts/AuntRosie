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

namespace AuntRosieApplication.Kitchen
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;

            cmbType.DataSource = new string[] {"pie", "preserve"};
        }

        private bool validate()
        {
            return validateName() & validateSize();
        }

        private bool validateName()
        {
            if(txtName.Text.Length < 1)
            {
                errorProvider1.SetError(txtName, "Name cannot be blank");
                return false;
            }

            errorProvider1.SetError(txtName, "");
            return true;
        }

        private bool validateSize()
        {
            if (txtName.Text.Length < 1)
            {
                errorProvider1.SetError(txtSize, "Serving Size cannot be blank");
                return false;
            }

            errorProvider1.SetError(txtSize, "");
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                try
                {
                    Product product = new Product();
                    product.Name = txtName.Text;
                    product.ServingSize = txtSize.Text;
                    product.Type = cmbType.Text;

                    product.Create();
                }
                catch(SqlException se)
                {
                    if(se.Message.Contains("duplicate key"))
                    {
                        errorProvider1.SetError(txtName, "A product with this name already exists");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 100)
            {
                txtName.Text = txtName.Text.Substring(0, txtName.Text.Length - 1);
                errorProvider1.SetError(txtName, "Name cannot be greater than 100");
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            if (txtSize.Text.Length > 20)
            {
                txtSize.Text = txtSize.Text.Substring(0, txtSize.Text.Length - 1);
                errorProvider1.SetError(txtSize, "Name cannot be greater than 20");
            }
            else
            {
                errorProvider1.SetError(txtSize, "");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSize.Clear();
        }

        private void frmAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
