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
    public partial class frmManageProductNutrition : Form
    {
        private Dictionary<string, char> valueTypes = new Dictionary<string, char>()
        {
            { "Weight (g)", 'W' },
            {"Percentage (%)", 'P'},
            {"Other", 'O'}
        };
        public frmManageProductNutrition()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManageProductNutrition_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            loadCmbs();
        }

        private void loadCmbs()
        {
            //Load products combobox
            cmbProduct.DataSource = ProductItem.GetProductItems();

            cmbNutrType.DataSource = Nutrition.GetNutritions();
            cmbNutrType.DisplayMember = "Name";

            cmbValType.DataSource = valueTypes.Keys.ToList<string>();
        }
    }
}
