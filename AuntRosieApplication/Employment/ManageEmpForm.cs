using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuntRosieApplication.Employment
{
    public partial class frmManagEmp : Form
    {
        public frmManagEmp()
        {
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmManagEmp_Load(object sender, EventArgs e)
        {
             this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            pnlButton.Left = (this.Width - pnlButton.Width) / 2;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
