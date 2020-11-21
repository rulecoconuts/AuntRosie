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

namespace AuntRosieApplication.Kitchen
{
    public partial class frmGiveProductSize : Form
    {
        List<Product> products = new List<Product>();

        public frmGiveProductSize()
        {
            InitializeComponent();
        }

        private void frmGiveProductSize_Load(object sender, EventArgs e)
        {
            DBConnector conn = new DBConnector(Properties.Resources.ConnectionString);
            RosieEntity.Connector = conn;
            products = Product.GetProducts();
            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "Name";
        }
    }
}
