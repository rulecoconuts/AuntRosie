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
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e) { }
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
            AuntRosieApplication.Classes.DBMethod.UserType = cmbType.SelectedItem.ToString();
            AuntRosieApp.frmHome form = new AuntRosieApp.frmHome();
            form.ShowDialog();
            this.Close();
        }

        private void pnlLoginBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
