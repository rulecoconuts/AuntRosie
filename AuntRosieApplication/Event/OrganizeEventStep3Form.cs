﻿using System;
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
    public partial class frmOrganizeEventStep3 : Form
    {
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
            frmOrganizeEventStep2 form = new frmOrganizeEventStep2();
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

        private void frmOrganizeEventStep3_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
