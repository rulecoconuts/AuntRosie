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
    public partial class frmOrganizeEventStep4 : Form
    {
        private RosieEvent rosieEvent;

        public frmOrganizeEventStep4(RosieEvent rosieEvent)
        {
            this.rosieEvent = rosieEvent;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public frmOrganizeEventStep4()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrganizeEventStep3 form = new frmOrganizeEventStep3();
            form.ShowDialog();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrganizeEventStep4_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

        }
    }
}
