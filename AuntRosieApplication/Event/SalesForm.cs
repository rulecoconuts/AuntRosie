using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuntRosieApplication.Event
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
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
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ViewPanel(pnlNewcustomer);
            pnlMain.Enabled = false;

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
    }
}
