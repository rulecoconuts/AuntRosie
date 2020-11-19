namespace AuntRosieApplication.Inventory
{
    partial class InventoryInForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuanitity = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlNewIngredint = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNewIngredintClose = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtstoringNote = new System.Windows.Forms.TextBox();
            this.cmbNewtype = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNewIngredintCancel = new System.Windows.Forms.Button();
            this.btnNewIngredintSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNewIngredintName = new System.Windows.Forms.TextBox();
            this.pnlNewType = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNewTypeClose = new System.Windows.Forms.Button();
            this.btnNewTypeCancel = new System.Windows.Forms.Button();
            this.btnNewTypetClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtxNewType = new System.Windows.Forms.TextBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnAddIngredint = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNewIngredint.SuspendLayout();
            this.pnlNewType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Inventory-In";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.dtpExpiryDate);
            this.pnlMain.Controls.Add(this.dtpPurchaseDate);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.comboBox2);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.btnAddType);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.btnAddIngredint);
            this.pnlMain.Controls.Add(this.txtQuanitity);
            this.pnlMain.Controls.Add(this.cmbUnit);
            this.pnlMain.Controls.Add(this.btnAddSupplier);
            this.pnlMain.Controls.Add(this.comboBox1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.cmbType);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.cmbName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Location = new System.Drawing.Point(46, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(531, 461);
            this.pnlMain.TabIndex = 59;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Location = new System.Drawing.Point(208, 309);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(281, 26);
            this.dtpExpiryDate.TabIndex = 11;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(208, 268);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(281, 26);
            this.dtpPurchaseDate.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label10.Location = new System.Drawing.Point(82, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 22);
            this.label10.TabIndex = 99;
            this.label10.Tag = "";
            this.label10.Text = "Expiry Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label9.Location = new System.Drawing.Point(54, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 98;
            this.label9.Tag = "";
            this.label9.Text = "Purchase Date";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cash",
            "Debit cards",
            "Credit cards"});
            this.comboBox2.Location = new System.Drawing.Point(208, 222);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(281, 31);
            this.comboBox2.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.Location = new System.Drawing.Point(41, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 96;
            this.label6.Tag = "";
            this.label6.Text = "Payment Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(438, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 95;
            this.label3.Text = "CAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(111, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 94;
            this.label5.Text = "Cost";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(208, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 29);
            this.textBox1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(325, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 82;
            this.label8.Text = "Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(111, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 81;
            this.label7.Text = "Quantity";
            // 
            // txtQuanitity
            // 
            this.txtQuanitity.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtQuanitity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuanitity.Location = new System.Drawing.Point(208, 135);
            this.txtQuanitity.Name = "txtQuanitity";
            this.txtQuanitity.Size = new System.Drawing.Size(86, 29);
            this.txtQuanitity.TabIndex = 7;
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Pies",
            "Preserves"});
            this.cmbUnit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(377, 133);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(112, 31);
            this.cmbUnit.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 31);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 88;
            this.label2.Tag = "";
            this.label2.Text = "Supplier Name";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(208, 0);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(235, 31);
            this.cmbType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(62, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 86;
            this.label1.Text = "Ingredint Type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(102, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 79);
            this.panel3.TabIndex = 85;
            // 
            // cmbName
            // 
            this.cmbName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(208, 46);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(235, 31);
            this.cmbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblName.Location = new System.Drawing.Point(54, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 22);
            this.lblName.TabIndex = 83;
            this.lblName.Text = "Ingredint Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AuntRosieApplication.Properties.Resources.move_stock;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(541, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 52);
            this.btnClose.TabIndex = 140;
            this.toolTip1.SetToolTip(this.btnClose, "Close the screen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlNewIngredint
            // 
            this.pnlNewIngredint.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlNewIngredint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewIngredint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewIngredint.Controls.Add(this.label13);
            this.pnlNewIngredint.Controls.Add(this.btnNewIngredintClose);
            this.pnlNewIngredint.Controls.Add(this.label16);
            this.pnlNewIngredint.Controls.Add(this.txtstoringNote);
            this.pnlNewIngredint.Controls.Add(this.cmbNewtype);
            this.pnlNewIngredint.Controls.Add(this.label15);
            this.pnlNewIngredint.Controls.Add(this.btnNewIngredintCancel);
            this.pnlNewIngredint.Controls.Add(this.btnNewIngredintSave);
            this.pnlNewIngredint.Controls.Add(this.label14);
            this.pnlNewIngredint.Controls.Add(this.txtNewIngredintName);
            this.pnlNewIngredint.Location = new System.Drawing.Point(12, 361);
            this.pnlNewIngredint.Name = "pnlNewIngredint";
            this.pnlNewIngredint.Size = new System.Drawing.Size(379, 245);
            this.pnlNewIngredint.TabIndex = 61;
            this.pnlNewIngredint.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(95, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 22);
            this.label13.TabIndex = 102;
            this.label13.Tag = "";
            this.label13.Text = "Add New Ingredint ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnNewIngredintClose
            // 
            this.btnNewIngredintClose.BackColor = System.Drawing.Color.Transparent;
            this.btnNewIngredintClose.FlatAppearance.BorderSize = 0;
            this.btnNewIngredintClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIngredintClose.Image = global::AuntRosieApplication.Properties.Resources.macos_close;
            this.btnNewIngredintClose.Location = new System.Drawing.Point(9, 3);
            this.btnNewIngredintClose.Name = "btnNewIngredintClose";
            this.btnNewIngredintClose.Size = new System.Drawing.Size(36, 38);
            this.btnNewIngredintClose.TabIndex = 109;
            this.toolTip1.SetToolTip(this.btnNewIngredintClose, "Close add new ingredint box");
            this.btnNewIngredintClose.UseVisualStyleBackColor = false;
            this.btnNewIngredintClose.Click += new System.EventHandler(this.btnNewIngredintClose_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label16.Location = new System.Drawing.Point(11, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 22);
            this.label16.TabIndex = 105;
            this.label16.Text = "Storing Notes";
            // 
            // txtstoringNote
            // 
            this.txtstoringNote.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtstoringNote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtstoringNote.Location = new System.Drawing.Point(140, 125);
            this.txtstoringNote.Multiline = true;
            this.txtstoringNote.Name = "txtstoringNote";
            this.txtstoringNote.Size = new System.Drawing.Size(210, 45);
            this.txtstoringNote.TabIndex = 20;
            // 
            // cmbNewtype
            // 
            this.cmbNewtype.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewtype.FormattingEnabled = true;
            this.cmbNewtype.Location = new System.Drawing.Point(140, 88);
            this.cmbNewtype.Name = "cmbNewtype";
            this.cmbNewtype.Size = new System.Drawing.Size(210, 31);
            this.cmbNewtype.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label15.Location = new System.Drawing.Point(84, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 22);
            this.label15.TabIndex = 102;
            this.label15.Text = "Type";
            // 
            // btnNewIngredintCancel
            // 
            this.btnNewIngredintCancel.Image = global::AuntRosieApplication.Properties.Resources.file_delete;
            this.btnNewIngredintCancel.Location = new System.Drawing.Point(204, 176);
            this.btnNewIngredintCancel.Name = "btnNewIngredintCancel";
            this.btnNewIngredintCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewIngredintCancel.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnNewIngredintCancel, "Cancel");
            this.btnNewIngredintCancel.UseVisualStyleBackColor = true;
            this.btnNewIngredintCancel.Click += new System.EventHandler(this.btnNewIngredintCancel_Click);
            // 
            // btnNewIngredintSave
            // 
            this.btnNewIngredintSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewIngredintSave.Location = new System.Drawing.Point(140, 176);
            this.btnNewIngredintSave.Name = "btnNewIngredintSave";
            this.btnNewIngredintSave.Size = new System.Drawing.Size(63, 55);
            this.btnNewIngredintSave.TabIndex = 21;
            this.btnNewIngredintSave.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label14.Location = new System.Drawing.Point(76, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 22);
            this.label14.TabIndex = 103;
            this.label14.Text = "Name";
            // 
            // txtNewIngredintName
            // 
            this.txtNewIngredintName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtNewIngredintName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewIngredintName.Location = new System.Drawing.Point(140, 55);
            this.txtNewIngredintName.Name = "txtNewIngredintName";
            this.txtNewIngredintName.Size = new System.Drawing.Size(208, 29);
            this.txtNewIngredintName.TabIndex = 18;
            // 
            // pnlNewType
            // 
            this.pnlNewType.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlNewType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewType.Controls.Add(this.label12);
            this.pnlNewType.Controls.Add(this.btnNewTypeClose);
            this.pnlNewType.Controls.Add(this.btnNewTypeCancel);
            this.pnlNewType.Controls.Add(this.btnNewTypetClear);
            this.pnlNewType.Controls.Add(this.label11);
            this.pnlNewType.Controls.Add(this.txtxNewType);
            this.pnlNewType.Location = new System.Drawing.Point(20, 105);
            this.pnlNewType.Name = "pnlNewType";
            this.pnlNewType.Size = new System.Drawing.Size(379, 245);
            this.pnlNewType.TabIndex = 60;
            this.pnlNewType.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(78, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 22);
            this.label12.TabIndex = 102;
            this.label12.Tag = "";
            this.label12.Text = "Add New Ingredint Type";
            // 
            // btnNewTypeClose
            // 
            this.btnNewTypeClose.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeClose.FlatAppearance.BorderSize = 0;
            this.btnNewTypeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeClose.Image = global::AuntRosieApplication.Properties.Resources.macos_close;
            this.btnNewTypeClose.Location = new System.Drawing.Point(3, 3);
            this.btnNewTypeClose.Name = "btnNewTypeClose";
            this.btnNewTypeClose.Size = new System.Drawing.Size(36, 38);
            this.btnNewTypeClose.TabIndex = 108;
            this.toolTip1.SetToolTip(this.btnNewTypeClose, "Close add new ingredint type box");
            this.btnNewTypeClose.UseVisualStyleBackColor = false;
            this.btnNewTypeClose.Click += new System.EventHandler(this.btnNewTypeClose_Click_1);
            // 
            // btnNewTypeCancel
            // 
            this.btnNewTypeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeCancel.FlatAppearance.BorderSize = 0;
            this.btnNewTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeCancel.Image = global::AuntRosieApplication.Properties.Resources.file_delete;
            this.btnNewTypeCancel.Location = new System.Drawing.Point(183, 140);
            this.btnNewTypeCancel.Name = "btnNewTypeCancel";
            this.btnNewTypeCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypeCancel.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnNewTypeCancel, "Cancel");
            this.btnNewTypeCancel.UseVisualStyleBackColor = false;
            // 
            // btnNewTypetClear
            // 
            this.btnNewTypetClear.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypetClear.FlatAppearance.BorderSize = 0;
            this.btnNewTypetClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypetClear.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewTypetClear.Location = new System.Drawing.Point(119, 140);
            this.btnNewTypetClear.Name = "btnNewTypetClear";
            this.btnNewTypetClear.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypetClear.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnNewTypetClear, "Save");
            this.btnNewTypetClear.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label11.Location = new System.Drawing.Point(26, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 22);
            this.label11.TabIndex = 103;
            this.label11.Text = "Type";
            // 
            // txtxNewType
            // 
            this.txtxNewType.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtxNewType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtxNewType.Location = new System.Drawing.Point(92, 85);
            this.txtxNewType.Name = "txtxNewType";
            this.txtxNewType.Size = new System.Drawing.Size(208, 29);
            this.txtxNewType.TabIndex = 14;
            // 
            // btnAddType
            // 
            this.btnAddType.FlatAppearance.BorderSize = 0;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddType.Location = new System.Drawing.Point(449, 2);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(40, 31);
            this.btnAddType.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddType, "Add new Ingredint Type");
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnAddIngredint
            // 
            this.btnAddIngredint.FlatAppearance.BorderSize = 0;
            this.btnAddIngredint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredint.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddIngredint.Location = new System.Drawing.Point(449, 48);
            this.btnAddIngredint.Name = "btnAddIngredint";
            this.btnAddIngredint.Size = new System.Drawing.Size(40, 31);
            this.btnAddIngredint.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAddIngredint, "Add new  Ingredient");
            this.btnAddIngredint.UseVisualStyleBackColor = true;
            this.btnAddIngredint.Click += new System.EventHandler(this.btnAddIngredint_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddSupplier.Location = new System.Drawing.Point(449, 89);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(40, 31);
            this.btnAddSupplier.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnAddSupplier, "Add new Supplier");
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnClear.Location = new System.Drawing.Point(111, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 72);
            this.btnClear.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnClear, "Clear");
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::AuntRosieApplication.Properties.Resources.plus_2_math;
            this.btnNew.Location = new System.Drawing.Point(8, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 72);
            this.btnNew.TabIndex = 0;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(214, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 72);
            this.btnSave.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // InventoryInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlNewIngredint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlNewType);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryInForm";
            this.Text = "InventoryInForm";
            this.Load += new System.EventHandler(this.InventoryInForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNewIngredint.ResumeLayout(false);
            this.pnlNewIngredint.PerformLayout();
            this.pnlNewType.ResumeLayout(false);
            this.pnlNewType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddIngredint;
        private System.Windows.Forms.TextBox txtQuanitity;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlNewType;
        private System.Windows.Forms.Button btnNewTypeCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewTypetClear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtxNewType;
        private System.Windows.Forms.Panel pnlNewIngredint;
        private System.Windows.Forms.Button btnNewIngredintCancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNewIngredintSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNewIngredintName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtstoringNote;
        private System.Windows.Forms.ComboBox cmbNewtype;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnNewTypeClose;
        private System.Windows.Forms.Button btnNewIngredintClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}