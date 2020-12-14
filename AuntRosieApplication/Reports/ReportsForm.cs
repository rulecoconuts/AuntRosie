using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieApplication.Classes;
namespace AuntRosieApplication.Reports
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
             
            this.DoubleBuffered = true;
            InitializeComponent();
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

        private void btnLowStock_Click(object sender, EventArgs e)
        {
           
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

        }

        private void btnLowStock_Click_1(object sender, EventArgs e)
        {
 DBMethod.Reptype = "Low-Stock";
            (new ReportVewierForm()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeIngredientPrice_Click(object sender, EventArgs e)
        {
            DBMethod.Reptype = "Diff-Price";
            (new ReportVewierForm()).ShowDialog();
        }

        private void btnNutrition_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployeeEvent_Click(object sender, EventArgs e)
        {
            DBMethod.Reptype = "Emp-Event";
            (new ReportVewierForm()).ShowDialog();
        }
    }
}
