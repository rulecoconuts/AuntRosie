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
using AuntRosieApplication.Classes;
 
using System.Data.OleDb;
using System.Data.SqlClient;
 

namespace AuntRosieApplication.Employment
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        { 
            this.DoubleBuffered = true;
            InitializeComponent();
           
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e) { }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayroll_Load(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployeesByType
                     (Classes.DBMethod.GetConnectionString(),"F"), cmbfullEmp);
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployeesByType
                 (Classes.DBMethod.GetConnectionString(),"P"), cmbPartEmp);
            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeePay empPayt = new EmployeePay();
                empPayt.EmployeeID= (long)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbfullEmp));
                empPayt.ThisPaymentMethod = DBMethod.GetSelectedItemID(cmbPaymentMethod);
                empPayt.FromDate =dtpFormDate.Value;
                empPayt.ToDate = dtpToDate.Value;
                empPayt.Amount = Convert.ToDouble(lblFullAmount.Text.Trim());
                empPayt.PaymentDate = DateTime.Today.Date;
                
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                empPayt.Create();
                MessageBox.Show("The ingredient quantity has successfully stocked into the inventory", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                //MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            getDays();
        }

        private void cmbfullEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lblDays.Text.Length > 0)
            {
                try
                {

                    DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;
                    Employee employee = Employee.Retrieve(DBMethod.GetSelectedItemID(cmbfullEmp));


                    double sal = employee.Salary;

                    double amount = (sal / 365) * getDays();
                    lblFullAmount.Text = String.Format("{0:0.0}", amount.ToString("N"));




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("From Date should be before To Date ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        private int getDays()
        {
            int days=0;

            DateTime start = Convert.ToDateTime(dtpFormDate.Value.Date);
            DateTime end = Convert.ToDateTime(dtpToDate.Value.Date);
            if (end > start)
            {
                TimeSpan difference = end.Subtract(start);


                days = (int)difference.TotalDays+1;
                lblDays.Text = days.ToString();
               
            }
            else
            {
                //MessageBox.Show("From Date should be bfore To Date ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDays.Text = string.Empty;
            }
                
                
            return days; 



        }

        private void dtpFormDate_ValueChanged(object sender, EventArgs e)
        {
            getDays();
        }

        private void cmbPartEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblDays.Text.Length > 0)
            {
                SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

                // Create new SQL command
                SqlCommand command = new SqlCommand("SELECT  SUM(Hours) AS exp1 " +
    " FROM(SELECT        tblEmployeeHours.EmployeeID, tblEmployeeHours.EventID, tblEmployeeHours.Hours," +
    " tblEmployeeHours.IsPaid, tblEvent.EventID AS Expr1, tblEvent.EventName, tblEvent.LocationID, tblEvent.EventDate, " +
    " tblEvent.EventType FROM    tblEmployeeHours INNER JOIN   tblEvent ON tblEmployeeHours.EventID = tblEvent.EventID " +
    " WHERE(tblEvent.EventDate BETWEEN '" + dtpFormDate.Value.Date.ToShortDateString() + "' AND '" +
    dtpToDate.Value.Date.ToShortDateString() + "' )) AS derivedtbl_1" +
    " GROUP BY EmployeeID  HAVING(EmployeeID = " + DBMethod.GetSelectedItemID(cmbPartEmp) + ")", dbConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Declare a DataTable object that will hold the return value
                DataTable dt = new DataTable();

                // Try to connect to the database, and use the adapter to fill the table
                try
                {
                    dbConnection.Open();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        lblHour.Text = "0.0";

                    }

                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {

                            lblHour.Text = String.Format("{0:0.0}", row[0].ToString());

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("From Date should be before To Date ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txtwage_Leave(object sender, EventArgs e)
        {
            double wage;
            if (txtwage.Text.Trim().Length > 0)
            {
                if (double.TryParse(txtwage.Text, out wage))
                {
                    txtwage.Text = string.Format("{0:0.00}", wage);
                    double hours;
                    double.TryParse(lblHour.Text, out hours);
                    lblPartAmount.Text = string.Format("{0:0.00}", hours * wage);
                }
            }
        }
    }
}
