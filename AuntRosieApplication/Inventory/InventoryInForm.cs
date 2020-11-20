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
namespace AuntRosieApplication.Inventory
{
    public partial class InventoryInForm : Form
    {
        public InventoryInForm()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            ViewPanel(pnlNewType);
            txtxNewType.Focus();
        }

        #region helpper-functions
        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            pnl.Visible = true;
        }
        #endregion

        private void btnNewIngredintCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnNewIngredintClose_Click(object sender, EventArgs e)
        {
            pnlNewIngredint.Visible = false;
            pnlMain.Enabled = true;
            cmbName.Focus();
        }

        private void btnNewTypeClose_Click(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
            cmbType.Focus();
        }

        private void btnAddIngredint_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            ViewPanel(pnlNewIngredint);

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Inventory.SuppliersForm form = new Inventory.SuppliersForm();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryInForm_Load(object sender, EventArgs e)
        {
           this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
           FillCombBox( AuntRosieEntities.IngredientType.GetAllIngredintType
               (Classes.DBMethod.GetConnectionString()),cmbType);
           FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
               (Classes.DBMethod.GetConnectionString()), cmbNewtype);

        }

        private void btnNewIngredintClose_Click_1(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
        }

        private void btnNewTypetClear_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
        }

        private void txtxNewType_TextChanged(object sender, EventArgs e)
        {
            if (txtxNewType.Text.Length>=3)
            {
                btnNewTypetSave.Enabled = true;
            }
            else
            {
                btnNewTypetSave.Enabled = false;
            }
        }

        private void btnNewTypetSave_Click(object sender, EventArgs e)
        {
            IngredientType newType = new IngredientType();
            if (txtxNewType.Text.Length >= 3)
            {
                newType.Name = txtxNewType.Text;
                newType.Create();
            }

            else
            {
                MessageBox.Show("Ingredient Type Name could not contain less than 3 character", "ENTRY ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #region Helpers-Functionsnctons 

        private void FillCombBox(DataTable dt , ComboBox cmb )

            {

            foreach (DataRow row in dt.Rows)
            {AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                 itm.name = row[1].ToString();
                itm.id = row[0].ToString();
                cmb.Items.Add((Object)itm);
            }
        }

        #endregion
    }
}
