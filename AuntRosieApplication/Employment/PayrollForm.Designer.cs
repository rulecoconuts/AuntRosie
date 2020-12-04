namespace AuntRosieApplication.Employment
{
    partial class frmPayroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayroll));
            this.lblTitle = new System.Windows.Forms.Label();
            this.errPayroll = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSet = new AuntRosieApplication.AuntRosieDBDataSet();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grdPayroll = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFullAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfullEmp = new System.Windows.Forms.ComboBox();
            this.btnAddFull = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPartAmount = new System.Windows.Forms.Label();
            this.txtwage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPartEmp = new System.Windows.Forms.ComboBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPaymentDate = new System.Windows.Forms.Panel();
            this.cmbPaymentDate = new System.Windows.Forms.ComboBox();
            this.radExists = new System.Windows.Forms.RadioButton();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.payrollTableAdapter = new AuntRosieApplication.AuntRosieDBDataSetTableAdapters.payrollTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayroll)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPaymentDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(29, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payroll";
            // 
            // errPayroll
            // 
            this.errPayroll.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPayroll.ContainerControl = this;
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.Transparent;
            this.btnOkay.FlatAppearance.BorderSize = 0;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Image = global::AuntRosieApplication.Properties.Resources.login_rounded_right;
            this.btnOkay.Location = new System.Drawing.Point(121, 160);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(79, 61);
            this.btnOkay.TabIndex = 129;
            this.toolTip1.SetToolTip(this.btnOkay, "Delete");
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPaymentDate.Location = new System.Drawing.Point(285, 8);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(281, 30);
            this.lblPaymentDate.TabIndex = 124;
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPaymentDate, "MM/DD/YYYY");
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "payroll";
            this.payrollBindingSource.DataSource = this.auntRosieDBDataSetBindingSource;
            // 
            // auntRosieDBDataSetBindingSource
            // 
            this.auntRosieDBDataSetBindingSource.DataSource = this.auntRosieDBDataSet;
            this.auntRosieDBDataSetBindingSource.Position = 0;
            // 
            // auntRosieDBDataSet
            // 
            this.auntRosieDBDataSet.DataSetName = "AuntRosieDBDataSet";
            this.auntRosieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.grdPayroll);
            this.pnlMain.Controls.Add(this.lblPaymentDate);
            this.pnlMain.Controls.Add(this.label13);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.cmbPaymentMethod);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.dtpFormDate);
            this.pnlMain.Controls.Add(this.dtpToDate);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.lblDays);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(61, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(845, 595);
            this.pnlMain.TabIndex = 123;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // grdPayroll
            // 
            this.grdPayroll.AllowUserToAddRows = false;
            this.grdPayroll.AllowUserToDeleteRows = false;
            this.grdPayroll.AutoGenerateColumns = false;
            this.grdPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeFirstNameDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.Delete});
            this.grdPayroll.DataSource = this.payrollBindingSource;
            this.grdPayroll.Location = new System.Drawing.Point(102, 405);
            this.grdPayroll.Name = "grdPayroll";
            this.grdPayroll.ReadOnly = true;
            this.grdPayroll.Size = new System.Drawing.Size(696, 150);
            this.grdPayroll.TabIndex = 125;
            this.grdPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPayroll_CellContentClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 89;
            // 
            // employeeFirstNameDataGridViewTextBoxColumn
            // 
            this.employeeFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFirstName";
            this.employeeFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.employeeFirstNameDataGridViewTextBoxColumn.Name = "employeeFirstNameDataGridViewTextBoxColumn";
            this.employeeFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "ToDate";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(139, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 22);
            this.label13.TabIndex = 123;
            this.label13.Tag = "";
            this.label13.Text = "Payment Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(171, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 103;
            this.label9.Tag = "";
            this.label9.Text = "From Date";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(283, 157);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(283, 31);
            this.cmbPaymentMethod.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(196, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 22);
            this.label10.TabIndex = 104;
            this.label10.Tag = "";
            this.label10.Text = "To Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(111, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 122;
            this.label6.Tag = "";
            this.label6.Text = "Payment Method";
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormDate.Location = new System.Drawing.Point(285, 41);
            this.dtpFormDate.Name = "dtpFormDate";
            this.dtpFormDate.Size = new System.Drawing.Size(281, 26);
            this.dtpFormDate.TabIndex = 100;
            this.dtpFormDate.ValueChanged += new System.EventHandler(this.dtpFormDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(285, 81);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(281, 26);
            this.dtpToDate.TabIndex = 101;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(220, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 119;
            this.label7.Tag = "";
            this.label7.Text = "Days";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(588, 194);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 22);
            this.lblName.TabIndex = 62;
            this.lblName.Text = "Full Time";
            // 
            // lblDays
            // 
            this.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDays.Location = new System.Drawing.Point(285, 119);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(108, 30);
            this.lblDays.TabIndex = 118;
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(141, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 111;
            this.label2.Text = "Part Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblFullAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbfullEmp);
            this.panel1.Controls.Add(this.btnAddFull);
            this.panel1.Location = new System.Drawing.Point(424, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 169);
            this.panel1.TabIndex = 109;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Sienna;
            this.label12.Location = new System.Drawing.Point(281, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 23);
            this.label12.TabIndex = 116;
            this.label12.Text = "CAD";
            // 
            // lblFullAmount
            // 
            this.lblFullAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFullAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullAmount.Location = new System.Drawing.Point(167, 89);
            this.lblFullAmount.Name = "lblFullAmount";
            this.lblFullAmount.Size = new System.Drawing.Size(108, 30);
            this.lblFullAmount.TabIndex = 113;
            this.lblFullAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Payment Amount";
            // 
            // cmbfullEmp
            // 
            this.cmbfullEmp.BackColor = System.Drawing.SystemColors.Info;
            this.cmbfullEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfullEmp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfullEmp.FormattingEnabled = true;
            this.cmbfullEmp.Location = new System.Drawing.Point(12, 15);
            this.cmbfullEmp.Name = "cmbfullEmp";
            this.cmbfullEmp.Size = new System.Drawing.Size(347, 31);
            this.cmbfullEmp.TabIndex = 63;
            this.cmbfullEmp.SelectedIndexChanged += new System.EventHandler(this.cmbfullEmp_SelectedIndexChanged);
            // 
            // btnAddFull
            // 
            this.btnAddFull.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFull.FlatAppearance.BorderSize = 0;
            this.btnAddFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFull.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btnAddFull.Location = new System.Drawing.Point(328, 123);
            this.btnAddFull.Name = "btnAddFull";
            this.btnAddFull.Size = new System.Drawing.Size(31, 35);
            this.btnAddFull.TabIndex = 106;
            this.btnAddFull.UseVisualStyleBackColor = false;
            this.btnAddFull.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblPartAmount);
            this.panel2.Controls.Add(this.txtwage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblHour);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbPartEmp);
            this.panel2.Controls.Add(this.btnAddPart);
            this.panel2.Location = new System.Drawing.Point(25, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 169);
            this.panel2.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(285, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 23);
            this.label11.TabIndex = 115;
            this.label11.Text = "CAD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(285, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 23);
            this.label8.TabIndex = 113;
            this.label8.Text = "CAD";
            // 
            // lblPartAmount
            // 
            this.lblPartAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartAmount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPartAmount.Location = new System.Drawing.Point(171, 122);
            this.lblPartAmount.Name = "lblPartAmount";
            this.lblPartAmount.Size = new System.Drawing.Size(108, 30);
            this.lblPartAmount.TabIndex = 114;
            this.lblPartAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtwage
            // 
            this.txtwage.BackColor = System.Drawing.SystemColors.Info;
            this.txtwage.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtwage.Location = new System.Drawing.Point(171, 52);
            this.txtwage.Name = "txtwage";
            this.txtwage.Size = new System.Drawing.Size(108, 29);
            this.txtwage.TabIndex = 112;
            this.txtwage.Leave += new System.EventHandler(this.txtwage_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "Payment Amount";
            // 
            // lblHour
            // 
            this.lblHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHour.Location = new System.Drawing.Point(171, 89);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(108, 30);
            this.lblHour.TabIndex = 112;
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 111;
            this.label4.Text = "Total worked hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Hour\'s wage";
            // 
            // cmbPartEmp
            // 
            this.cmbPartEmp.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPartEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartEmp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartEmp.FormattingEnabled = true;
            this.cmbPartEmp.Location = new System.Drawing.Point(10, 15);
            this.cmbPartEmp.Name = "cmbPartEmp";
            this.cmbPartEmp.Size = new System.Drawing.Size(349, 31);
            this.cmbPartEmp.TabIndex = 63;
            this.cmbPartEmp.SelectedIndexChanged += new System.EventHandler(this.cmbPartEmp_SelectedIndexChanged);
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPart.FlatAppearance.BorderSize = 0;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btnAddPart.Location = new System.Drawing.Point(328, 123);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(31, 29);
            this.btnAddPart.TabIndex = 106;
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(828, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 108;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlPaymentDate
            // 
            this.pnlPaymentDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPaymentDate.BackgroundImage")));
            this.pnlPaymentDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentDate.Controls.Add(this.cmbPaymentDate);
            this.pnlPaymentDate.Controls.Add(this.btnOkay);
            this.pnlPaymentDate.Controls.Add(this.radExists);
            this.pnlPaymentDate.Controls.Add(this.radNew);
            this.pnlPaymentDate.Controls.Add(this.label14);
            this.pnlPaymentDate.Location = new System.Drawing.Point(34, 120);
            this.pnlPaymentDate.Name = "pnlPaymentDate";
            this.pnlPaymentDate.Size = new System.Drawing.Size(356, 237);
            this.pnlPaymentDate.TabIndex = 124;
            this.pnlPaymentDate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaymentDate_Paint);
            // 
            // cmbPaymentDate
            // 
            this.cmbPaymentDate.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentDate.Enabled = false;
            this.cmbPaymentDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentDate.FormattingEnabled = true;
            this.cmbPaymentDate.Location = new System.Drawing.Point(39, 123);
            this.cmbPaymentDate.Name = "cmbPaymentDate";
            this.cmbPaymentDate.Size = new System.Drawing.Size(272, 31);
            this.cmbPaymentDate.TabIndex = 130;
            this.cmbPaymentDate.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentDate_SelectedIndexChanged);
            // 
            // radExists
            // 
            this.radExists.AutoSize = true;
            this.radExists.BackColor = System.Drawing.Color.Transparent;
            this.radExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExists.Location = new System.Drawing.Point(39, 60);
            this.radExists.Name = "radExists";
            this.radExists.Size = new System.Drawing.Size(178, 28);
            this.radExists.TabIndex = 127;
            this.radExists.Text = "Pervious Payroll";
            this.radExists.UseVisualStyleBackColor = false;
            this.radExists.CheckedChanged += new System.EventHandler(this.radExists_CheckedChanged);
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.BackColor = System.Drawing.Color.Transparent;
            this.radNew.Checked = true;
            this.radNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNew.Location = new System.Drawing.Point(39, 26);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(161, 28);
            this.radNew.TabIndex = 126;
            this.radNew.TabStop = true;
            this.radNew.Text = "Today Payroll ";
            this.radNew.UseVisualStyleBackColor = false;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 125;
            this.label14.Tag = "";
            this.label14.Text = "Payment Date";
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 698);
            this.Controls.Add(this.pnlPaymentDate);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollForm";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayroll)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPaymentDate.ResumeLayout(false);
            this.pnlPaymentDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errPayroll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private System.Windows.Forms.BindingSource auntRosieDBDataSetBindingSource;
        private AuntRosieDBDataSet auntRosieDBDataSet;
        private AuntRosieDBDataSetTableAdapters.payrollTableAdapter payrollTableAdapter;
        private System.Windows.Forms.Panel pnlPaymentDate;
        private System.Windows.Forms.RadioButton radExists;
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFullAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbfullEmp;
        private System.Windows.Forms.Button btnAddFull;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPartAmount;
        private System.Windows.Forms.TextBox txtwage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPartEmp;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.ComboBox cmbPaymentDate;
        private System.Windows.Forms.DataGridView grdPayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}