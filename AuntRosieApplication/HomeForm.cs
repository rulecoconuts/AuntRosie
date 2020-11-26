using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
 
namespace AuntRosieApp
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.Visible = false;
        }
 

        private void frmHome_Load(object sender, EventArgs e)
        {
           

            ShowMainMenu();
           
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.sweet;
            this.DoubleBuffered = false;
            relocation(pnlMain);
            relocation(pnlInventory);
            relocation(pnlKitchen);
            relocation(pnlEvent);
            relocation(pnlReportQuery);
            relocation(pnlEmp);

            
             
            
            pnlExit.Left=  this.Width- pnlExit.Width ;
            pnlExit.Top = 0 ;
            
            this.Visible = true;

        }
        #region Helpers-Functions

        private void ShowMainMenu()
        {
            HidePanels();
            pnlMain.Visible = true;
            btnInventory.Focus();
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="Pnl"></param>
        private void relocation( Panel pnl)
        {
            //relocation the login pannel 
           pnl.Left = (this.Width - pnl.Width) / 2;
           pnl.Top = (this.Height - pnl.Height) / 2;
        }
        /// <summary>
        /// 
        /// </summary>
        private void HidePanels()
        {
            pnlInventory.Visible = false;
            pnlMain.Visible = false;
            pnlKitchen.Visible = false;
            pnlEvent.Visible = false;
            pnlEmp.Visible = false;
            pnlReportQuery.Visible = false;
           
        }
        private void BackToMain(Panel pnl)
        {
            pnl.Visible = false;
            pnlMain.Visible = true;
            btnInventory.Focus();
        }
        private void ShowPnlel(Panel pnl)
        {

             pnl.Visible = true;
            pnlMain.Visible = false;
        }
        ///
        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlInventory);
        }

        private  void ShowForm( Form  form)
        {
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Left = (this.Width - form.Width) / 2;
            form.Top = (this.Height - form.Height) / 2;
            form.Show();
            form.Activate();
            form.Focus();
            HidePanels();
            mnuMain.Visible = false;
            btnShowMain.Enabled = true;
        }

        #endregion


        private void btnInventoryMain_Click(object sender, EventArgs e)
        {
            BackToMain(pnlInventory);
        }

        private void btnKitchenMain_Click(object sender, EventArgs e)
        {
            BackToMain(pnlInventory);
        }

        private void btnEventMAin_Click(object sender, EventArgs e)
        {
            BackToMain(pnlEvent);
        }


        private void btnEmployment_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlEmp);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlEvent);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {

        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlKitchen);
        }

        private void btnQueryAndreport_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlReportQuery);
        }

        private void btnReportMain_Click(object sender, EventArgs e)
        {
            BackToMain(pnlReportQuery);
        }

        private void btnEmpMAin_Click(object sender, EventArgs e)
        {
            BackToMain(pnlEmp);
        }
 

        private void btnKitchenProduct_Click(object sender, EventArgs e)
        {
            AuntRosieApp.Kitchen.frmManageProduct form = new AuntRosieApp.Kitchen.frmManageProduct();
            ShowForm(form);
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowMain_Click(object sender, EventArgs e)
        {
           
            if(this.Controls.Count==8)
            {
                ShowMainMenu();
                mnuMain.Visible = true;
                btnShowMain.Enabled = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Controls.Count.ToString());
        }

        private void frmHome_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
            HidePanels();
            pnlInventory.Show();

        }

        private void employmentToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlEmp.Show();
        }

        private void eventToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlEvent.Show();
        }

        private void kitchenToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlKitchen.Show();
        }

        private void queriesAndReportsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlReportQuery.Show();
        }
 

        private void tmnInventoryIn_MouseLeave(object sender, EventArgs e)
        {
            btnInventoryMain.Focus();
        }

        private void tmnManageEmployee_MouseEnter(object sender, EventArgs e)
        {
            btnManagEmp.Focus();
        }

        private void tmnManageEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnEmpMAin.Focus();
        }

        private void mnuPayroll_MouseEnter(object sender, EventArgs e)
        {
            btnPayroll.Focus();
        }

        private void tmnInventoryIn_MouseEnter(object sender, EventArgs e)
        {
            btnInventoryIn.Focus();
        }

        private void tmnManageProduct_MouseEnter(object sender, EventArgs e)
        {
            btnSuppliers.Focus();
        }

        private void tmnOrginizeEvent_MouseEnter(object sender, EventArgs e)
        {
            btnOrgEvent.Focus();
        }

        private void tmnOrginizeEvent_MouseLeave(object sender, EventArgs e)
        {
            btnEventMAin.Focus();
        }

        private void tmnSales_MouseEnter(object sender, EventArgs e)
        {
            btnSale.Focus();
        }

        private void tmnProducation_MouseEnter(object sender, EventArgs e)
        {
            btnProduction.Focus();
        }

        private void tmnProducation_MouseLeave(object sender, EventArgs e)
        {
            btnKitchenMain.Focus();
        }

        private void tmnManage_MouseEnter(object sender, EventArgs e)
        {
            btnKitchenProduct.Focus();
        }

        private void tmnQueries_MouseEnter(object sender, EventArgs e)
        {
            btnQuery.Focus();
        }

        private void tmnQueries_MouseLeave(object sender, EventArgs e)
        {
            btnReportMain.Focus();
        }

        private void tmnReports_MouseEnter(object sender, EventArgs e)
        {
            btnReport.Focus();
        }

        private void pnlKitchen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            //AuntRosieApplication.Kitchen.frmProduction form = new AuntRosieApplication.Kitchen.frmProduction();
            AuntRosieApplication.Kitchen.frmProduction form = new AuntRosieApplication.Kitchen.frmProduction();
            ShowForm(form);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Inventory.frmSupplier form = new AuntRosieApplication.Inventory.frmSupplier();
            ShowForm(form);
        }

        private void tmnManageProduct_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Inventory.frmSupplier form = new AuntRosieApplication.Inventory.frmSupplier();
            ShowForm(form);
        }

        private void btnInventoryIn_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Inventory.InventoryInForm form = new AuntRosieApplication.Inventory.InventoryInForm();
            ShowForm(form);
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Employment.frmPayroll  form = new AuntRosieApplication.Employment.frmPayroll();
            ShowForm(form);
        }

        private void btnManagEmp_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Employment.frmManagEmp form  = new AuntRosieApplication.Employment.frmManagEmp();
            ShowForm(form);
        }

        private void tmnEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Event.frmSale form = new AuntRosieApplication.Event.frmSale();
            ShowForm(form);
        }

        private void btnOrgEvent_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Event.frmOrganizeEvent form = new AuntRosieApplication.Event.frmOrganizeEvent();
            ShowForm(form);
        }

        private void btnManageIngerdint_Click(object sender, EventArgs e)
        {
         
            ShowForm(new AuntRosieApplication.Inventory.frmIngredients());
        }

        private void ingredintsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            btnManageIngerdint.Focus();
        }

        private void btnInventoryContents_Click(object sender, EventArgs e)
        {
           
            ShowForm(new AuntRosieApplication.Inventory.frmInventoryStock());

        }

        private void tmnInventoryStock_MouseEnter(object sender, EventArgs e)
        {
            btnInventoryContents.Focus();
        }

        private void btnMinmize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
