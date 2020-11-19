using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnNewTypeClose_Click_1(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
        }

        private void btnNewIngredintClose_Click_1(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
        }
    }
}
