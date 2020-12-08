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
        private string conStr;
        BindingSource bindingSource = new BindingSource();

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
            // TODO: This line of code loads data into the 'auntRosieDBDataSet.tblEmployeeHours' table. You can move, or remove it, as needed.
            //this.tblEmployeeHoursTableAdapter.Fill(this.auntRosieDBDataSet.tblEmployeeHours);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            prepareDataGrid();
            loadEmployees();
            loadEmployeeHours();
        }

        private void prepareDataGrid()
        {
            dtgEmployeeHours.AutoGenerateColumns = true;
            dtgEmployeeHours.DataSource = bindingSource;
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
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
            }
        }

        private void loadEmployees()
        {
            cmbEmpName.Items.Clear();
            DataTable employeeTable = Employee.GetAllEmployees(conStr);
            foreach(DataRow row in employeeTable.Rows)
            {
                Employee employee = new Employee();
                employee.Id = row.Field<long>("EmployeeID");
                employee.FirstName = row.Field<string>("EmployeeFirstName");
                employee.LastName = row.Field<string>("EmployeeLastName");
                employee.Phone = row.Field<string>("EmployeePhone");
                employee.Province = row.Field<string>("EmployeeProvince");
                employee.City = row.Field<string>("EmployeeCity");
                employee.Street = row.Field<string>("EmployeeStreet");
                employee.PostalCode = row.Field<string>("EmployeePostalCode");
                employee.Email = row.Field<string>("EmployeeEmail");
                employee.Role = row.Field<string>("EmployeeRole");
                employee.Salary = row.IsNull("EmployeeSalary")?0:(double)row.Field<decimal>("EmployeeSalary");
                if (!row.IsNull("EmploymentDate"))
                {
                    employee.EmploymentDate = row.Field<DateTime>("EmploymentDate");
                }
                employee.Type = row.Field<string>("EmployeeType");

                cmbEmpName.Items.Add(employee);
            }
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

        private bool validate()
        {
            if(txtHours.Text.Length < 1)
            {
                errorProvider1.SetError(txtHours, "txtHours cannot be blank");
                return false;
            }
            errorProvider1.SetError(txtHours, "");
            return true;
        }

        private void loadEmployeeHours()
        {
            DataTable employeeTable = EmployeeHours.GetEmployeeHoursUpdateable(rosieEvent.Id);
            bindingSource.DataSource = employeeTable;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    EmployeeHours hourRecord = new EmployeeHours();
                    hourRecord.Hours = Decimal.Parse(txtHours.Text);
                    hourRecord.IsPaid = false;
                    hourRecord.EventID = rosieEvent.Id;
                    hourRecord.EmployeeID = (cmbEmpName.SelectedItem as Employee).Id;

                    hourRecord.Create();
                    errorProvider1.SetError(cmbEmpName, "");

                    loadEmployeeHours();
                }
                catch (SqlException se)
                {
                    if (se.Message.Contains("duplicate key"))
                    {
                        errorProvider1.SetError(cmbEmpName, "This employee has already been assigned to this event");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void dtgEmployeeHours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtgEmployeeHours.Columns["dataGridDeleteButton"].Index)
            {
                DataGridViewRow selectedRow = dtgEmployeeHours.Rows[e.RowIndex];
                long employeeID = (long)(selectedRow.Cells["EmployeeID"].Value);
                EmployeeHours hoursRecord = new EmployeeHours();
                hoursRecord.EmployeeID = employeeID;
                hoursRecord.EventID = rosieEvent.Id;
                hoursRecord.Delete();
                dtgEmployeeHours.Rows.Remove(selectedRow);
            }
        }
    }
}
