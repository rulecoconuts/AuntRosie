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
        private BindingSource employeeHoursSource = new BindingSource();
        private BindingSource productionSource = new BindingSource();

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

        private void displayEvent()
        {
            if (rosieEvent != null)
            {
                txtEvent.Text = rosieEvent.ToString();
            }
        }

        private void prepareDataGrids()
        {
            dtgProduction.DataSource = productionSource;
            dtgProduction.AutoGenerateColumns = true;
            prepareEmployeeGrid();
        }

        private void loadEmployeeHours()
        {
            DataTable employeeTable = EmployeeHours.GetEmployeeHoursUpdateable(rosieEvent.Id);
            employeeHoursSource.DataSource = employeeTable;
        }

        private void loadProductionGrid()
        {
            productionSource.DataSource = EventProduct.GetProductionsTable(rosieEvent.Id);
        }

        private void loadDataGrids()
        {
            loadEmployeeHours();
            loadProductionGrid();
        }

        private void prepareEmployeeGrid()
        {
            dtgEmployeeHours.AutoGenerateColumns = true;
            dtgEmployeeHours.DataSource = employeeHoursSource;
           /* DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = "Delete";
            column.Name = "dataGridDeleteButton";
            column.Text = "Delete";
            column.UseColumnTextForButtonValue = true;
            dtgEmployeeHours.Columns.Add(column);
            int count = dtgEmployeeHours.Columns.Count;
            if (count >= 2)
            {
                DataGridViewColumn temp = dtgEmployeeHours.Columns[0];
                dtgEmployeeHours.Columns.Insert(0, dtgEmployeeHours.Columns[count - 1]);
                dtgEmployeeHours.Columns.Insert(count - 1, temp);
            }*/
        }

        private void frmOrganizeEventStep4_Load(object sender, EventArgs e)
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
            prepareDataGrids();
            loadDataGrids();
        }
    }
}
