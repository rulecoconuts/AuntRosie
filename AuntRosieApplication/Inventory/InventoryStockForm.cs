using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuntRosieApplication.Inventory
{
    public partial class frmInventoryStock : Form
    {
        public frmInventoryStock()
        {
            InitializeComponent();
        }

        private void frmInventoryStock_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
