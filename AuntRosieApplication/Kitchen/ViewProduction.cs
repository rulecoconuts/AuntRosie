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
    public partial class frmViewProduction : Form
    {
        public frmViewProduction()
        {
            InitializeComponent();
        }

        private void ViewProduction_Load(object sender, EventArgs e)
        {
             
            // TODO: This line of code loads data into the 'auntRosieDBDataSet.tblProduction' table. You can move, or remove it, as needed.
            //this.tblProductionTableAdapter.Fill(this.auntRosieDBDataSet.tblProduction);
            cmbType.DataSource = new string[]{ "Pie", "Pickle"};

            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;

            loadDTG(Production.GetProductions());
            int colWidth = dtgProduction.Width / 4;
            foreach(DataGridViewColumn col in dtgProduction.Columns)
            {
                col.Width = colWidth;
            }
        }

        private void loadDTG(List<Production> productions)
        {

            dtgProduction.DataSource = productions;
            /*foreach(Production production in productions)
            {
                dtgProduction.Rows.Add()
            }*/
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chkAllProducts.Checked)
            {
                loadDTG(Production.GetProductions(cmbType.Text.ToLower()));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
