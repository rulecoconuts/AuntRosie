﻿using System;
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
namespace AuntRosieApplication.Inventory
{
    public partial class InventoryInForm : Form
    {
        public static String OpStatus = null;
        public bool SupplierFlag = false;
        public bool isNewIngrdent = false;
        public InventoryInForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                   (Classes.DBMethod.GetConnectionString()), cmbNewtype);
            pnlMain.Enabled = false;
            ViewPanel(pnlNewType);
            txtxNewType.Focus();
        }

        #region helppr-functions
        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            pnl.Visible = true;
        }
         private bool IsValidIngredent ()
        {
            bool isvalid = true;
            if (txtNewIngredintName.Text.Length < 3)
            {
                isvalid = false;
                errIngredientName.SetError(txtNewIngredintName, "Ingredient Name could not be less than 3 letters");
            }
            if (cmbNewtype.Text.Length ==0)
            {
                isvalid = false;
                errIngredientType.SetError(cmbNewtype, "Ingredient should has a type");

            }
            if (txtstoringNote.Text.Length == 0)
            {
                isvalid = false;
                errCost.SetError(txtstoringNote, "Sorting note could not be empty");

            }
             
            return isvalid;
        }
         
        #endregion

        private void btnNewIngredintCancel_Click(object sender, EventArgs e)
        {
            pnlNewIngredint.Visible = false;
        }

        private void btnNewIngredintClose_Click(object sender, EventArgs e)
        {
            pnlNewIngredint.Visible = false;
            pnlMain.Enabled = true;
            cmbName.Focus();
        }

        private void btnNewTypeClose_Click(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
            cmbType.Focus();
        }

        private void btnAddIngredint_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            ViewPanel(pnlNewIngredint);

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Inventory.frmSupplier form = new Inventory.frmSupplier();
            form.thisOpStatus = "newOnly";
            form.ShowDialog();
            SupplierFlag = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryInForm_Load(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            pnlButton.Left = (this.Width - pnlButton.Width) / 2;
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlSubMain.Enabled = false;
            btnNew.Focus();
            DBMethod.relocation(pnlNewType, this);
            DBMethod.relocation(pnlNewIngredint, this);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
          Classes.DBMethod.FillCombBox( AuntRosieEntities.IngredientType.GetAllIngredintType
               (Classes.DBMethod.GetConnectionString()),cmbType);
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
               (Classes.DBMethod.GetConnectionString()), cmbNewtype);
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
                (Classes.DBMethod.GetConnectionString()), cmbSupplier);


        }

        private void btnNewIngredintClose_Click_1(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
        }

        private void btnNewTypetClear_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
        }

        private void txtxNewType_TextChanged(object sender, EventArgs e)
        {
            if (txtxNewType.Text.Length>=3)
            {
                btnNewTypetSave.Enabled = true;
            }
            else
            {
                btnNewTypetSave.Enabled = false;
            }
        }

        private void btnNewTypetSave_Click(object sender, EventArgs e)
        {
            IngredientType newType = new IngredientType();
            if (txtxNewType.Text.Length >= 3)
            {
                newType.Name = txtxNewType.Text;
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;

                newType.Create();
                pnlNewType.Visible = false;
                pnlMain.Enabled = true; 

                cmbType.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                     (Classes.DBMethod.GetConnectionString()), cmbType);
                cmbType.SelectedItem = cmbType.Items[cmbType.Items.Count - 1];
                
                 


                cmbNewtype.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                     (Classes.DBMethod.GetConnectionString()), cmbNewtype);
                cmbNewtype.SelectedItem = cmbType.Items[cmbNewtype.Items.Count - 1];

            }

            else
            {
                errIngredientType.SetError(txtxNewType, "Ingredient Type Name could not contain less than 3 character");
                txtxNewType.Focus();
            }
        }

 

        private void InventoryInForm_Activated(object sender, EventArgs e)
        {   if (SupplierFlag)
            {
        
            cmbSupplier.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
                (Classes.DBMethod.GetConnectionString()), cmbSupplier);

                cmbSupplier.SelectedItem = cmbSupplier.Items[cmbSupplier.Items.Count - 1];

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpStatus = "new";
            pnlSubMain.Enabled = true; ;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            cmbType.Focus();
            btnNew.Enabled = false;
             
           
             
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Ingredient.GetAllIngredintsByType
              (Classes.DBMethod.GetConnectionString(), DBMethod.GetSelectedItemID(cmbType)), cmbName);
        }

        private void btnNewIngredintSave_Click(object sender, EventArgs e)
        {
            Ingredient newIngredient = new Ingredient();
            if (IsValidIngredent())
            {
                newIngredient.Name = txtNewIngredintName.Text.Trim();

                newIngredient.IngredientTypeId = (short) Convert.ToDouble(DBMethod.GetSelectedItemID(cmbNewtype)) ;
                newIngredient.StoringNote = txtstoringNote.Text;
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                newIngredient.Create();
                pnlNewIngredint.Visible = false;
                pnlMain.Enabled = true;

                cmbType.Items.Clear();
             
                cmbType.SelectedItem = cmbType.Items[cmbType.Items.Count - 1];




                cmbNewtype.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                     (Classes.DBMethod.GetConnectionString()), cmbNewtype);
                cmbNewtype.SelectedItem = cmbType.Items[cmbNewtype.Items.Count - 1];



            }


        }
    }
}
