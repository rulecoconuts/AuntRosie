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
    public partial class frmOrganizeEvent : Form
    {
        public frmOrganizeEvent()
        {
            InitializeComponent();
        }

        private void frmOrganizeEvent_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

        }
        #region helpper-functions
        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            grbNew.Enabled = false;
            grbExists.Enabled = false;
            btnNext.Enabled = false;
            pnl.Visible = true;

        }
        #endregion

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            ViewPanel(pnlNewLoc);

        }

        private void btnNewTypeClose_Click(object sender, EventArgs e)
        {
            grbNew.Enabled = true;
            grbExists.Enabled = true;
            btnNext.Enabled = true;
            pnlNewLoc.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
             frmOrganizeEventStep2 form = new frmOrganizeEventStep2();
            form.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
