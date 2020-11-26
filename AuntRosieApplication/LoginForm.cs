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
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.sweet;
            //relocation the login pannel 
            pnlLoginBox.Left = (this.Width - pnlLoginBox.Width) / 2;
            pnlLoginBox.Top = (this.Height - pnlLoginBox.Height) / 2;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuntRosieApp.frmHome form = new AuntRosieApp.frmHome();
            form.ShowDialog();
        }
    }
}
