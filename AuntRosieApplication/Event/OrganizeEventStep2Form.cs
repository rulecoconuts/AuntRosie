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
using System.Data.SqlClient;

namespace AuntRosieApplication.Event
{
    public partial class frmOrganizeEventStep2 : Form
    {
        private RosieEvent rosieEvent;
        private SqlTransaction transaction;
        

        public frmOrganizeEventStep2(RosieEvent rosieEvent, SqlTransaction transaction)
        {
            this.rosieEvent = rosieEvent;
            this.transaction = transaction;
            InitializeComponent();
            loadEvent(rosieEvent);
        }

        private void loadEvent(RosieEvent ev)
        {
            if (ev != null)
            {
                txtEvent.Text = ev.ToString();
            }
        }

        public frmOrganizeEventStep2()
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

        private void frmOrganizeEventStep2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrganizeEvent form = new frmOrganizeEvent();
            form.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrganizeEventStep3 form = new frmOrganizeEventStep3();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grbNew_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
