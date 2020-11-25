namespace AuntRosieApplication.Kitchen
{
    partial class frmProduction
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.dtgProduction = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtpProductionTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduction)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(35, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(116, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtQuantity.Location = new System.Drawing.Point(204, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(131, 29);
            this.txtQuantity.TabIndex = 4;
            // 
            // cmbEvent
            // 
            this.cmbEvent.AutoCompleteCustomSource.AddRange(new string[] {
            "Pies",
            "Preserves"});
            this.cmbEvent.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(204, 28);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(230, 31);
            this.cmbEvent.TabIndex = 3;
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbEvent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Event";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(628, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 52);
            this.btnClose.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(217, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 72);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "6";
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::AuntRosieApplication.Properties.Resources.plus_2_math;
            this.btnNew.Location = new System.Drawing.Point(22, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 72);
            this.btnNew.TabIndex = 0;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn
            // 
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btn.Location = new System.Drawing.Point(380, 135);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(54, 38);
            this.btn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn, "Add");
            this.btn.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblProductName.Location = new System.Drawing.Point(199, 98);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(76, 22);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Product";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProductionDate.Location = new System.Drawing.Point(287, 166);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(278, 26);
            this.dtpProductionDate.TabIndex = 5;
            this.dtpProductionDate.ValueChanged += new System.EventHandler(this.dtpProductionDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(135, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Production Date";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblLoc);
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.dtgProduction);
            this.groupBox1.Controls.Add(this.cmbEvent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(83, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 310);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events Quantity";
            // 
            // lblLoc
            // 
            this.lblLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoc.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblLoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLoc.Location = new System.Drawing.Point(140, 72);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(294, 56);
            this.lblLoc.TabIndex = 14;
            this.lblLoc.Text = "Event Location:   ";
            // 
            // dtgProduction
            // 
            this.dtgProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduction.Location = new System.Drawing.Point(15, 178);
            this.dtgProduction.Name = "dtgProduction";
            this.dtgProduction.Size = new System.Drawing.Size(480, 118);
            this.dtgProduction.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(171, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 80);
            this.panel2.TabIndex = 28;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnClear.Location = new System.Drawing.Point(114, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 72);
            this.btnClear.TabIndex = 15;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(77, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "Production";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AuntRosieApplication.Properties.Resources.Production_Lines;
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 78);
            this.panel1.TabIndex = 140;
            // 
            // cmbProductName
            // 
            this.cmbProductName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(287, 94);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(382, 31);
            this.cmbProductName.TabIndex = 141;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(131, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 142;
            this.label5.Text = "Production Time";
            // 
            // dtpProductionTime
            // 
            this.dtpProductionTime.CustomFormat = "hh:mm tt";
            this.dtpProductionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProductionTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProductionTime.Location = new System.Drawing.Point(287, 202);
            this.dtpProductionTime.Name = "dtpProductionTime";
            this.dtpProductionTime.ShowUpDown = true;
            this.dtpProductionTime.Size = new System.Drawing.Size(278, 26);
            this.dtpProductionTime.TabIndex = 143;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.Location = new System.Drawing.Point(135, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 22);
            this.label7.TabIndex = 145;
            this.label7.Text = "Expiration Date";
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiry.Location = new System.Drawing.Point(287, 234);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(278, 26);
            this.dtpExpiry.TabIndex = 144;
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(708, 656);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.dtpProductionTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpProductionDate);
            this.Controls.Add(this.lblProductName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduction";
            this.Load += new System.EventHandler(this.frmProduction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduction)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dtgProduction;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpProductionTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
    }
}