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
namespace AuntRosieApplication.Employment
{
    public partial class frmManagEmp : Form
    {
        public string OpStatus = string.Empty;
        public string EmpType = "F";
        public static String ExOpStatus = null;
        public frmManagEmp()
        {
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmManagEmp_Load(object sender, EventArgs e)
        {
             this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            pnlButton.Left = (this.Width - pnlButton.Width) / 2;
            cmbRole.SelectedItem = cmbRole.Items[0];
            radFullTime.Checked = true;
            radPartTime.Checked = false;
            pnlFullTimeData.Enabled = true;

            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployees
                  (Classes.DBMethod.GetConnectionString()), cmbName);
            btnNew.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpStatus = "new";
            TextBoxEnabled();
            btnClancel.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            cmbName.Visible = false;
             
            clearTextBox();
            txtFirstName.Focus();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            bool OpIsSaved = true;
            
            if (OpStatus == "new")
            {
                isValid = GetValidationStatus();
                if (isValid)
                {
                    newEmployee();


                }
                else
                {
                    OpIsSaved = false;
                }
            }
            else
            if (OpStatus == "edit")
            {

                isValid = GetValidationStatus();
                if (isValid)
                {
                    editEmployee();
                    cmbName.Items.Clear();
                    Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployees
                                       (Classes.DBMethod.GetConnectionString()), cmbName);
                }
                else
                {
                    OpIsSaved = false;
                }


            }
            else
            if (OpStatus == "delete")
            {
                deleteEmployee();
                cmbName.Items.Clear();
                Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployees
                   (Classes.DBMethod.GetConnectionString()), cmbName);

                OpIsSaved = true;



            }

            if (OpIsSaved)
            {
                if (ExOpStatus == "newOnly")
                {

                    this.Close();
                }
                radPartTime.Enabled = false;
                TextBoxDisEnabled();
                btnClancel.Enabled = false;
                btnSave.Enabled = false;
                btnNew.Focus();
                btnNew.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnNew.Focus();
                clearTextBox();
                cmbName.Visible = false;
                cmbName.Items.Clear();
        
                Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployees
             (Classes.DBMethod.GetConnectionString()), cmbName);

            }


        }

        #region Helper_Functions 

        private void clearTextBox()
        {
            txtsalary.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPostalCode.Text = String.Empty;
            txtStreet.Text = String.Empty;
            cmbProvinces.Text = String.Empty;
            cmbRole.Text = String.Empty;
            txtCity.Text = String.Empty;
        }
        private void newEmployee()
        {


            AuntRosieEntities.Employee insertEmployee = new AuntRosieEntities.Employee();
          
            insertEmployee.FirstName = txtFirstName.Text.Trim();
            insertEmployee.LastName = txtLastName.Text.Trim();
            insertEmployee.Phone = txtPhone.Text.Trim();
            insertEmployee.Email = txtEmail.Text.Trim();
            insertEmployee.City = txtCity.Text.Trim();
            insertEmployee.Phone = txtPhone.Text.Trim();
            insertEmployee.Email = txtEmail.Text.Trim();
            insertEmployee.City = txtCity.Text.Trim();
            insertEmployee.Role = cmbRole.Text.Trim();
            insertEmployee.Type = EmpType;


            AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
            Object obj = cmbProvinces.Items[cmbProvinces.SelectedIndex];
            itm = (AuntRosieApplication.Classes.ListItem)obj;
            insertEmployee.Province = itm.id;
            insertEmployee.Street = txtStreet.Text.Trim();
            insertEmployee.PostalCode = txtPostalCode.Text.Trim();

            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                insertEmployee.Create();

                MessageBox.Show("The new Employee has been inserted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }


        private void editEmployee()
        {


            AuntRosieEntities.Employee updateEmployee = new AuntRosieEntities.Employee();

             
            updateEmployee.FirstName = txtFirstName.Text.Trim();
            updateEmployee.LastName = txtLastName.Text.Trim();
            updateEmployee.Phone = txtPhone.Text.Trim();
            updateEmployee.Email = txtEmail.Text.Trim();
            updateEmployee.City = txtCity.Text.Trim();
            AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
            Object obj = cmbProvinces.Items[cmbProvinces.SelectedIndex];
            itm = (AuntRosieApplication.Classes.ListItem)obj;
            updateEmployee.Province = itm.id;
            updateEmployee.Street = txtStreet.Text.Trim();
            updateEmployee.PostalCode = txtPostalCode.Text.Trim();
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            object obj2 = cmbName.Items[cmbName.SelectedIndex];
            itm2 = (AuntRosieApplication.Classes.ListItem)obj2;
            updateEmployee.Id = (long)Convert.ToDouble(itm2.id);

            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                updateEmployee.Update();

                MessageBox.Show("The Employee has been updated successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message);
                MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void deleteEmployee()
        {
            Employee deleteEmployee = new Employee();
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            object obj2 = cmbName.Items[cmbName.SelectedIndex];
            itm2 = (AuntRosieApplication.Classes.ListItem)obj2;
            deleteEmployee.Id = (long)Convert.ToDouble(itm2.id);

            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                deleteEmployee.Delete();

                MessageBox.Show("The Employee has been deleted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                MessageBox.Show("This Employee could not be deleted ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void TextBoxEnabled()
        {

            
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtPostalCode.Enabled = true;
            txtStreet.Enabled = true;
            cmbProvinces.Enabled = true;
            txtCity.Enabled = true;
            pnlFullTimeData.Enabled = true;
            


        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void TextBoxDisEnabled()
        {

            
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtPostalCode.Enabled = false;
            txtStreet.Enabled = false;
            cmbProvinces.Enabled = false;
            txtCity.Enabled = false;
            pnlFullTimeData.Enabled = false;
           


        }

        private bool GetValidationStatus()
        {
            bool isValid = true;
             
            if (txtFirstName.Text.Trim().Length < 3)
            {
                erPEmployeeForm.SetError(txtFirstName, "Employee Contact first name should be 3 letters at least");
                isValid = false;

            }
            if (txtLastName.Text.Trim().Length < 3)
            {
                erPEmployeeForm.SetError(txtLastName, "Employee Contact last name should be 3 letters at least");
                isValid = false;

            }

            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                erPEmployeeForm.SetError(txtEmail, "Entred Employee Email is not a valid email address");
                isValid = false;

            }
            if (txtPhone.Text.Trim().Length != 14)
            {
                erPEmployeeForm.SetError(txtPhone, "Entred Phone is not a valid phone number");
                isValid = false;

            }
            if (txtCity.Text.Trim().Length < 3)
            {
                erPEmployeeForm.SetError(txtCity, " City should be 3 letters at least");
                isValid = false;

            }
            if (cmbProvinces.Text.Trim().Length == 0)
            {
                erPEmployeeForm.SetError(cmbProvinces, " Province could not be empty");
                isValid = false;

            }
            if (txtPostalCode.Text.Trim().Length != 6)
            {
                erPEmployeeForm.SetError(txtPostalCode, "Entred Postalcode is not a valid postalcode");
                isValid = false;

            }


            return isValid;
        }
        #endregion

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            Employee employee = Employee.Retrieve(DBMethod.GetSelectedItemID(cmbName));

            
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtPhone.Text = employee.Phone;
            txtEmail.Text = employee.Email;
            txtCity.Text = employee.City;
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            itm2.id = employee.Province;
            itm2.name = Classes.DBMethod.GetProvinceName(itm2.id);
            cmbProvinces.SelectedItem = itm2;
            cmbProvinces.Text = Classes.DBMethod.GetProvinceName(itm2.id);
            txtStreet.Text = employee.Street;
            txtPostalCode.Text = employee.PostalCode;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpStatus = "edit";
            TextBoxEnabled();
            btnClancel.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            cmbName.Visible = true;
            radPartTime.Enabled = false;
            cmbName.Focus();
        }

        private void btnClancel_Click(object sender, EventArgs e)
        {
            TextBoxDisEnabled();
            btnClancel.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Focus();
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Focus();
            if (ExOpStatus == "newOnly")
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpStatus = "delete";
            TextBoxDisEnabled();
            btnClancel.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            cmbName.Visible = true;
            cmbName.Focus();
        }

        private void radFullTime_CheckedChanged(object sender, EventArgs e)
        {
            cmbRole.SelectedItem = cmbRole.Items[0];
            EmpType = "F";
        }

        private void radPartTime_CheckedChanged(object sender, EventArgs e)
        {
            pnlFullTimeData.Enabled = false;
            EmpType = "P";
        }
    }
}
