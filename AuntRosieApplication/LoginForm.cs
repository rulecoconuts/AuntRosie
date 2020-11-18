using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AuntRosieApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //relocation the login pannel 
            pnlLoginBox.Left = (this.Width - pnlLoginBox.Width) / 2;
            pnlLoginBox.Top = (this.Height - pnlLoginBox.Height) / 2;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
