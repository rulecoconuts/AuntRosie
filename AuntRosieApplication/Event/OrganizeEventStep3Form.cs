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

namespace AuntRosieApplication.Event
{
    public partial class frmOrganizeEventStep3 : Form
    {
        BindingSource bindingSource = new BindingSource();
        private RosieEvent rosieEvent;

        public frmOrganizeEventStep3(RosieEvent rosieEvent)
        {
            this.rosieEvent = rosieEvent;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public frmOrganizeEventStep3()
        {
            InitializeComponent();
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

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrganizeEventStep2 form = new frmOrganizeEventStep2(rosieEvent, null);
            form.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrganizeEventStep4 form = new frmOrganizeEventStep4();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDataGrid()
        {
            bindingSource.DataSource = EventProduct.GetProductionsTable(rosieEvent.Id);
        }

        private void displayEvent()
        {
            if (rosieEvent != null)
            {
                txtEvent.Text = rosieEvent.ToString();
            }
        }

        private void frmOrganizeEventStep3_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            displayEvent();
            dtgProduction.DataSource = bindingSource;
            dtgProduction.AutoGenerateColumns = true;
            loadDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if(rbNew.Checked)
            {
                this.Close();
                Kitchen.frmProduction frm = new Kitchen.frmProduction(rosieEvent);
                frm.ShowDialog();
            }
            else
            {

            }
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                rbExisting.Checked = false;
            }
        }

        private void rbExisting_CheckedChanged(object sender, EventArgs e)
        {
            if(rbExisting.Checked)
            {
                rbNew.Checked = false;
            }
        }
    }
}
