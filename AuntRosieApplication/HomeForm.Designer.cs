namespace AuntRosieApp
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlKitchen = new System.Windows.Forms.Panel();
            this.pnlEmp = new System.Windows.Forms.Panel();
            this.pnlEvent = new System.Windows.Forms.Panel();
            this.pnlReportQuery = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tmnInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnInventoryIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnManageProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnEmployment = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnManageEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayroll = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnOrginizeEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnExpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnKitchen = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnProducation = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnQueriesAndReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportMain = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnKitchenMain = new System.Windows.Forms.Button();
            this.btnKitchenProduct = new System.Windows.Forms.Button();
            this.btnEmpMAin = new System.Windows.Forms.Button();
            this.btnManagEmp = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnEventMAin = new System.Windows.Forms.Button();
            this.btnOrgEvent = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnShowMain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnQueryAndreport = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnEmployment = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnInventoryMain = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnInventoryIn = new System.Windows.Forms.Button();
            this.pnlInventory.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlKitchen.SuspendLayout();
            this.pnlEmp.SuspendLayout();
            this.pnlEvent.SuspendLayout();
            this.pnlReportQuery.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInventory
            // 
            this.pnlInventory.Controls.Add(this.btnInventoryMain);
            this.pnlInventory.Controls.Add(this.btnSuppliers);
            this.pnlInventory.Controls.Add(this.btnInventoryIn);
            this.pnlInventory.Location = new System.Drawing.Point(1188, 45);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(582, 207);
            this.pnlInventory.TabIndex = 9;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnQueryAndreport);
            this.pnlMain.Controls.Add(this.btnKitchen);
            this.pnlMain.Controls.Add(this.btnExpenses);
            this.pnlMain.Controls.Add(this.btnEvent);
            this.pnlMain.Controls.Add(this.btnEmployment);
            this.pnlMain.Controls.Add(this.btnInventory);
            this.pnlMain.Location = new System.Drawing.Point(377, 471);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(819, 478);
            this.pnlMain.TabIndex = 9;
            // 
            // pnlKitchen
            // 
            this.pnlKitchen.Controls.Add(this.btnProduction);
            this.pnlKitchen.Controls.Add(this.btnKitchenMain);
            this.pnlKitchen.Controls.Add(this.btnKitchenProduct);
            this.pnlKitchen.Location = new System.Drawing.Point(12, 45);
            this.pnlKitchen.Name = "pnlKitchen";
            this.pnlKitchen.Size = new System.Drawing.Size(582, 207);
            this.pnlKitchen.TabIndex = 9;
            this.pnlKitchen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKitchen_Paint);
            // 
            // pnlEmp
            // 
            this.pnlEmp.Controls.Add(this.btnEmpMAin);
            this.pnlEmp.Controls.Add(this.btnManagEmp);
            this.pnlEmp.Controls.Add(this.btnPayroll);
            this.pnlEmp.Location = new System.Drawing.Point(600, 258);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(582, 207);
            this.pnlEmp.TabIndex = 9;
            // 
            // pnlEvent
            // 
            this.pnlEvent.Controls.Add(this.btnEventMAin);
            this.pnlEvent.Controls.Add(this.btnOrgEvent);
            this.pnlEvent.Controls.Add(this.btnSale);
            this.pnlEvent.Location = new System.Drawing.Point(12, 258);
            this.pnlEvent.Name = "pnlEvent";
            this.pnlEvent.Size = new System.Drawing.Size(582, 207);
            this.pnlEvent.TabIndex = 9;
            // 
            // pnlReportQuery
            // 
            this.pnlReportQuery.Controls.Add(this.btnReportMain);
            this.pnlReportQuery.Controls.Add(this.btnQuery);
            this.pnlReportQuery.Controls.Add(this.btnReport);
            this.pnlReportQuery.Location = new System.Drawing.Point(600, 45);
            this.pnlReportQuery.Name = "pnlReportQuery";
            this.pnlReportQuery.Size = new System.Drawing.Size(582, 207);
            this.pnlReportQuery.TabIndex = 9;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnShowMain);
            this.pnlExit.Controls.Add(this.btnExit);
            this.pnlExit.Controls.Add(this.btnHelp);
            this.pnlExit.Location = new System.Drawing.Point(12, 514);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(87, 260);
            this.pnlExit.TabIndex = 10;
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnInventory,
            this.tmnEmployment,
            this.tmnEvent,
            this.tmnExpenses,
            this.tmnKitchen,
            this.tmnQueriesAndReports});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1770, 31);
            this.mnuMain.TabIndex = 11;
            this.mnuMain.Text = "menuStrip1";
            // 
            // tmnInventory
            // 
            this.tmnInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnInventoryIn,
            this.tmnManageProduct});
            this.tmnInventory.Name = "tmnInventory";
            this.tmnInventory.Size = new System.Drawing.Size(94, 27);
            this.tmnInventory.Text = "Inventory";
            this.tmnInventory.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            this.tmnInventory.MouseEnter += new System.EventHandler(this.inventoryToolStripMenuItem_MouseEnter);
            // 
            // tmnInventoryIn
            // 
            this.tmnInventoryIn.Name = "tmnInventoryIn";
            this.tmnInventoryIn.Size = new System.Drawing.Size(171, 28);
            this.tmnInventoryIn.Text = "Inventory-In";
            this.tmnInventoryIn.MouseEnter += new System.EventHandler(this.tmnInventoryIn_MouseEnter);
            this.tmnInventoryIn.MouseLeave += new System.EventHandler(this.tmnInventoryIn_MouseLeave);
            // 
            // tmnManageProduct
            // 
            this.tmnManageProduct.Name = "tmnManageProduct";
            this.tmnManageProduct.Size = new System.Drawing.Size(171, 28);
            this.tmnManageProduct.Text = "Suppliers";
            this.tmnManageProduct.MouseEnter += new System.EventHandler(this.tmnManageProduct_MouseEnter);
            this.tmnManageProduct.MouseLeave += new System.EventHandler(this.tmnInventoryIn_MouseLeave);
            // 
            // tmnEmployment
            // 
            this.tmnEmployment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPayroll,
            this.tmnManageEmployee});
            this.tmnEmployment.Name = "tmnEmployment";
            this.tmnEmployment.Size = new System.Drawing.Size(117, 27);
            this.tmnEmployment.Text = "Employment";
            this.tmnEmployment.MouseEnter += new System.EventHandler(this.employmentToolStripMenuItem_MouseEnter);
            // 
            // tmnManageEmployee
            // 
            this.tmnManageEmployee.Name = "tmnManageEmployee";
            this.tmnManageEmployee.Size = new System.Drawing.Size(219, 28);
            this.tmnManageEmployee.Text = "Manage Employee";
            this.tmnManageEmployee.MouseEnter += new System.EventHandler(this.tmnManageEmployee_MouseEnter);
            this.tmnManageEmployee.MouseLeave += new System.EventHandler(this.tmnManageEmployee_MouseLeave);
            // 
            // mnuPayroll
            // 
            this.mnuPayroll.Name = "mnuPayroll";
            this.mnuPayroll.Size = new System.Drawing.Size(219, 28);
            this.mnuPayroll.Text = "Payroll";
            this.mnuPayroll.MouseEnter += new System.EventHandler(this.mnuPayroll_MouseEnter);
            this.mnuPayroll.MouseLeave += new System.EventHandler(this.tmnManageEmployee_MouseLeave);
            // 
            // tmnEvent
            // 
            this.tmnEvent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnOrginizeEvent,
            this.tmnSales});
            this.tmnEvent.Name = "tmnEvent";
            this.tmnEvent.Size = new System.Drawing.Size(65, 27);
            this.tmnEvent.Text = "Event";
            this.tmnEvent.MouseEnter += new System.EventHandler(this.eventToolStripMenuItem_MouseEnter);
            // 
            // tmnOrginizeEvent
            // 
            this.tmnOrginizeEvent.Name = "tmnOrginizeEvent";
            this.tmnOrginizeEvent.Size = new System.Drawing.Size(190, 28);
            this.tmnOrginizeEvent.Text = "Orginize Event";
            this.tmnOrginizeEvent.MouseEnter += new System.EventHandler(this.tmnOrginizeEvent_MouseEnter);
            this.tmnOrginizeEvent.MouseLeave += new System.EventHandler(this.tmnOrginizeEvent_MouseLeave);
            // 
            // tmnSales
            // 
            this.tmnSales.Name = "tmnSales";
            this.tmnSales.Size = new System.Drawing.Size(190, 28);
            this.tmnSales.Text = "Sales";
            this.tmnSales.MouseEnter += new System.EventHandler(this.tmnSales_MouseEnter);
            this.tmnSales.MouseLeave += new System.EventHandler(this.tmnOrginizeEvent_MouseLeave);
            // 
            // tmnExpenses
            // 
            this.tmnExpenses.Name = "tmnExpenses";
            this.tmnExpenses.Size = new System.Drawing.Size(97, 27);
            this.tmnExpenses.Text = "Expenses";
            // 
            // tmnKitchen
            // 
            this.tmnKitchen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnProducation,
            this.tmnManage});
            this.tmnKitchen.Name = "tmnKitchen";
            this.tmnKitchen.Size = new System.Drawing.Size(80, 27);
            this.tmnKitchen.Text = "Kitchen";
            this.tmnKitchen.MouseEnter += new System.EventHandler(this.kitchenToolStripMenuItem_MouseEnter);
            // 
            // tmnProducation
            // 
            this.tmnProducation.Name = "tmnProducation";
            this.tmnProducation.Size = new System.Drawing.Size(204, 28);
            this.tmnProducation.Text = "Producation";
            this.tmnProducation.MouseEnter += new System.EventHandler(this.tmnProducation_MouseEnter);
            this.tmnProducation.MouseLeave += new System.EventHandler(this.tmnProducation_MouseLeave);
            // 
            // tmnManage
            // 
            this.tmnManage.Name = "tmnManage";
            this.tmnManage.Size = new System.Drawing.Size(204, 28);
            this.tmnManage.Text = "Manage Product";
            this.tmnManage.MouseEnter += new System.EventHandler(this.tmnManage_MouseEnter);
            this.tmnManage.MouseLeave += new System.EventHandler(this.tmnProducation_MouseLeave);
            // 
            // tmnQueriesAndReports
            // 
            this.tmnQueriesAndReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnReports,
            this.tmnQueries});
            this.tmnQueriesAndReports.Name = "tmnQueriesAndReports";
            this.tmnQueriesAndReports.Size = new System.Drawing.Size(178, 27);
            this.tmnQueriesAndReports.Text = "Queries and Reports";
            this.tmnQueriesAndReports.MouseEnter += new System.EventHandler(this.queriesAndReportsToolStripMenuItem_MouseEnter);
            // 
            // tmnQueries
            // 
            this.tmnQueries.Name = "tmnQueries";
            this.tmnQueries.Size = new System.Drawing.Size(140, 28);
            this.tmnQueries.Text = "Queries";
            this.tmnQueries.MouseEnter += new System.EventHandler(this.tmnQueries_MouseEnter);
            this.tmnQueries.MouseLeave += new System.EventHandler(this.tmnQueries_MouseLeave);
            // 
            // tmnReports
            // 
            this.tmnReports.Name = "tmnReports";
            this.tmnReports.Size = new System.Drawing.Size(140, 28);
            this.tmnReports.Text = "Reports";
            this.tmnReports.MouseEnter += new System.EventHandler(this.tmnReports_MouseEnter);
            this.tmnReports.MouseLeave += new System.EventHandler(this.tmnQueries_MouseLeave);
            // 
            // btnReportMain
            // 
            this.btnReportMain.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnReportMain.Image = global::AuntRosieApplication.Properties.Resources.squared_menu;
            this.btnReportMain.Location = new System.Drawing.Point(388, 9);
            this.btnReportMain.Name = "btnReportMain";
            this.btnReportMain.Size = new System.Drawing.Size(184, 187);
            this.btnReportMain.TabIndex = 2;
            this.btnReportMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnReportMain, "Main Panel");
            this.btnReportMain.UseVisualStyleBackColor = true;
            this.btnReportMain.Click += new System.EventHandler(this.btnReportMain_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnQuery.Image = global::AuntRosieApplication.Properties.Resources.faq;
            this.btnQuery.Location = new System.Drawing.Point(199, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(184, 187);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnQuery, "Query");
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnReport.Image = global::AuntRosieApplication.Properties.Resources.business_report;
            this.btnReport.Location = new System.Drawing.Point(9, 9);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(184, 187);
            this.btnReport.TabIndex = 0;
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnReport, "Report");
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnProduction
            // 
            this.btnProduction.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnProduction.Image = global::AuntRosieApplication.Properties.Resources.Production_Lines;
            this.btnProduction.Location = new System.Drawing.Point(11, 9);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(184, 187);
            this.btnProduction.TabIndex = 1;
            this.btnProduction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnProduction, "Production");
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnKitchenMain
            // 
            this.btnKitchenMain.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnKitchenMain.Image = global::AuntRosieApplication.Properties.Resources.squared_menu;
            this.btnKitchenMain.Location = new System.Drawing.Point(390, 9);
            this.btnKitchenMain.Name = "btnKitchenMain";
            this.btnKitchenMain.Size = new System.Drawing.Size(184, 187);
            this.btnKitchenMain.TabIndex = 3;
            this.btnKitchenMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnKitchenMain, "Main Panel");
            this.btnKitchenMain.UseVisualStyleBackColor = true;
            this.btnKitchenMain.Click += new System.EventHandler(this.btnKitchenMain_Click);
            // 
            // btnKitchenProduct
            // 
            this.btnKitchenProduct.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnKitchenProduct.Image = global::AuntRosieApplication.Properties.Resources.services;
            this.btnKitchenProduct.Location = new System.Drawing.Point(201, 9);
            this.btnKitchenProduct.Name = "btnKitchenProduct";
            this.btnKitchenProduct.Size = new System.Drawing.Size(184, 187);
            this.btnKitchenProduct.TabIndex = 2;
            this.btnKitchenProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnKitchenProduct, "Manage Products");
            this.btnKitchenProduct.UseVisualStyleBackColor = true;
            this.btnKitchenProduct.Click += new System.EventHandler(this.btnKitchenProduct_Click);
            // 
            // btnEmpMAin
            // 
            this.btnEmpMAin.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnEmpMAin.Image = global::AuntRosieApplication.Properties.Resources.squared_menu;
            this.btnEmpMAin.Location = new System.Drawing.Point(391, 9);
            this.btnEmpMAin.Name = "btnEmpMAin";
            this.btnEmpMAin.Size = new System.Drawing.Size(184, 187);
            this.btnEmpMAin.TabIndex = 2;
            this.btnEmpMAin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnEmpMAin, "Main Panel");
            this.btnEmpMAin.UseVisualStyleBackColor = true;
            this.btnEmpMAin.Click += new System.EventHandler(this.btnEmpMAin_Click);
            // 
            // btnManagEmp
            // 
            this.btnManagEmp.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnManagEmp.Image = global::AuntRosieApplication.Properties.Resources.services;
            this.btnManagEmp.Location = new System.Drawing.Point(201, 9);
            this.btnManagEmp.Name = "btnManagEmp";
            this.btnManagEmp.Size = new System.Drawing.Size(184, 187);
            this.btnManagEmp.TabIndex = 1;
            this.btnManagEmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnManagEmp, "Manage Employees");
            this.btnManagEmp.UseVisualStyleBackColor = true;
            // 
            // btnPayroll
            // 
            this.btnPayroll.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnPayroll.Image = global::AuntRosieApplication.Properties.Resources.teacher_hirring;
            this.btnPayroll.Location = new System.Drawing.Point(9, 9);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(184, 187);
            this.btnPayroll.TabIndex = 0;
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnPayroll, "Payroll");
            this.btnPayroll.UseVisualStyleBackColor = true;
            // 
            // btnEventMAin
            // 
            this.btnEventMAin.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnEventMAin.Image = global::AuntRosieApplication.Properties.Resources.squared_menu;
            this.btnEventMAin.Location = new System.Drawing.Point(388, 9);
            this.btnEventMAin.Name = "btnEventMAin";
            this.btnEventMAin.Size = new System.Drawing.Size(184, 187);
            this.btnEventMAin.TabIndex = 2;
            this.btnEventMAin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnEventMAin, "Main Panel");
            this.btnEventMAin.UseVisualStyleBackColor = true;
            this.btnEventMAin.Click += new System.EventHandler(this.btnEventMAin_Click);
            // 
            // btnOrgEvent
            // 
            this.btnOrgEvent.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnOrgEvent.Image = global::AuntRosieApplication.Properties.Resources.event_declined;
            this.btnOrgEvent.Location = new System.Drawing.Point(199, 9);
            this.btnOrgEvent.Name = "btnOrgEvent";
            this.btnOrgEvent.Size = new System.Drawing.Size(184, 187);
            this.btnOrgEvent.TabIndex = 1;
            this.btnOrgEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnOrgEvent, "Organize Event");
            this.btnOrgEvent.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnSale.Image = global::AuntRosieApplication.Properties.Resources.receipt;
            this.btnSale.Location = new System.Drawing.Point(9, 9);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(184, 187);
            this.btnSale.TabIndex = 0;
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnSale, "Sales");
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // btnShowMain
            // 
            this.btnShowMain.Enabled = false;
            this.btnShowMain.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnShowMain.Image = global::AuntRosieApplication.Properties.Resources.home;
            this.btnShowMain.Location = new System.Drawing.Point(0, 3);
            this.btnShowMain.Name = "btnShowMain";
            this.btnShowMain.Size = new System.Drawing.Size(84, 81);
            this.btnShowMain.TabIndex = 6;
            this.btnShowMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnShowMain, "Home");
            this.btnShowMain.UseVisualStyleBackColor = true;
            this.btnShowMain.Click += new System.EventHandler(this.btnShowMain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnExit.Image = global::AuntRosieApplication.Properties.Resources.shutdown;
            this.btnExit.Location = new System.Drawing.Point(0, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 81);
            this.btnExit.TabIndex = 8;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnHelp.Image = global::AuntRosieApplication.Properties.Resources.question_mark;
            this.btnHelp.Location = new System.Drawing.Point(0, 90);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(84, 81);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnQueryAndreport
            // 
            this.btnQueryAndreport.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnQueryAndreport.Image = global::AuntRosieApplication.Properties.Resources.short_hair_lady_question_mark;
            this.btnQueryAndreport.Location = new System.Drawing.Point(548, 245);
            this.btnQueryAndreport.Name = "btnQueryAndreport";
            this.btnQueryAndreport.Size = new System.Drawing.Size(260, 225);
            this.btnQueryAndreport.TabIndex = 5;
            this.btnQueryAndreport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnQueryAndreport, "Queries and Reports");
            this.btnQueryAndreport.UseVisualStyleBackColor = true;
            this.btnQueryAndreport.Click += new System.EventHandler(this.btnQueryAndreport_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnKitchen.Image = global::AuntRosieApplication.Properties.Resources.kitchen__1_;
            this.btnKitchen.Location = new System.Drawing.Point(282, 245);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(260, 225);
            this.btnKitchen.TabIndex = 4;
            this.btnKitchen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnKitchen, "Kitchen");
            this.btnKitchen.UseVisualStyleBackColor = true;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnExpenses.Image = global::AuntRosieApplication.Properties.Resources.pay_wall;
            this.btnExpenses.Location = new System.Drawing.Point(16, 245);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(260, 225);
            this.btnExpenses.TabIndex = 3;
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnExpenses, "Expenses");
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnEvent.Image = global::AuntRosieApplication.Properties.Resources.confetti;
            this.btnEvent.Location = new System.Drawing.Point(548, 14);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(260, 225);
            this.btnEvent.TabIndex = 2;
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnEvent, "Event");
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnEmployment
            // 
            this.btnEmployment.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnEmployment.Image = global::AuntRosieApplication.Properties.Resources.parse_resumes;
            this.btnEmployment.Location = new System.Drawing.Point(282, 14);
            this.btnEmployment.Name = "btnEmployment";
            this.btnEmployment.Size = new System.Drawing.Size(260, 225);
            this.btnEmployment.TabIndex = 1;
            this.btnEmployment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnEmployment, "Employment");
            this.btnEmployment.UseVisualStyleBackColor = true;
            this.btnEmployment.Click += new System.EventHandler(this.btnEmployment_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnInventory.Image = global::AuntRosieApplication.Properties.Resources.warehouse_1;
            this.btnInventory.Location = new System.Drawing.Point(16, 14);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(260, 225);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnInventory, "Inventory");
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnInventoryMain
            // 
            this.btnInventoryMain.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnInventoryMain.Image = global::AuntRosieApplication.Properties.Resources.squared_menu;
            this.btnInventoryMain.Location = new System.Drawing.Point(388, 9);
            this.btnInventoryMain.Name = "btnInventoryMain";
            this.btnInventoryMain.Size = new System.Drawing.Size(184, 187);
            this.btnInventoryMain.TabIndex = 2;
            this.btnInventoryMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnInventoryMain, "Main Panel");
            this.btnInventoryMain.UseVisualStyleBackColor = true;
            this.btnInventoryMain.Click += new System.EventHandler(this.btnInventoryMain_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnSuppliers.Image = global::AuntRosieApplication.Properties.Resources.supplier__1_;
            this.btnSuppliers.Location = new System.Drawing.Point(199, 9);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(184, 187);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnSuppliers, "Suppliers");
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnInventoryIn
            // 
            this.btnInventoryIn.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnInventoryIn.Image = global::AuntRosieApplication.Properties.Resources.move_stock;
            this.btnInventoryIn.Location = new System.Drawing.Point(9, 9);
            this.btnInventoryIn.Name = "btnInventoryIn";
            this.btnInventoryIn.Size = new System.Drawing.Size(184, 187);
            this.btnInventoryIn.TabIndex = 0;
            this.btnInventoryIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnInventoryIn, "Inventory-In");
            this.btnInventoryIn.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1114, 769);
            this.Controls.Add(this.pnlReportQuery);
            this.Controls.Add(this.pnlKitchen);
            this.Controls.Add(this.pnlEmp);
            this.Controls.Add(this.pnlEvent);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMain;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.MouseEnter += new System.EventHandler(this.frmHome_MouseEnter);
            this.pnlInventory.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlKitchen.ResumeLayout(false);
            this.pnlEmp.ResumeLayout(false);
            this.pnlEvent.ResumeLayout(false);
            this.pnlReportQuery.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnInventoryIn;
        private System.Windows.Forms.Button btnEmployment;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnQueryAndreport;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnInventoryMain;
        private System.Windows.Forms.Button btnKitchenMain;
        private System.Windows.Forms.Button btnKitchenProduct;
        private System.Windows.Forms.Panel pnlKitchen;
        private System.Windows.Forms.Button btnEmpMAin;
        private System.Windows.Forms.Button btnManagEmp;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Panel pnlEmp;
        private System.Windows.Forms.Button btnEventMAin;
        private System.Windows.Forms.Button btnOrgEvent;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Panel pnlEvent;
        private System.Windows.Forms.Button btnReportMain;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlReportQuery;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnShowMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tmnInventory;
        private System.Windows.Forms.ToolStripMenuItem tmnInventoryIn;
        private System.Windows.Forms.ToolStripMenuItem tmnManageProduct;
        private System.Windows.Forms.ToolStripMenuItem tmnEmployment;
        private System.Windows.Forms.ToolStripMenuItem tmnManageEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuPayroll;
        private System.Windows.Forms.ToolStripMenuItem tmnEvent;
        private System.Windows.Forms.ToolStripMenuItem tmnOrginizeEvent;
        private System.Windows.Forms.ToolStripMenuItem tmnSales;
        private System.Windows.Forms.ToolStripMenuItem tmnExpenses;
        private System.Windows.Forms.ToolStripMenuItem tmnKitchen;
        private System.Windows.Forms.ToolStripMenuItem tmnProducation;
        private System.Windows.Forms.ToolStripMenuItem tmnManage;
        private System.Windows.Forms.ToolStripMenuItem tmnQueriesAndReports;
        private System.Windows.Forms.ToolStripMenuItem tmnQueries;
        private System.Windows.Forms.ToolStripMenuItem tmnReports;
        private System.Windows.Forms.Button btnProduction;
    }
}