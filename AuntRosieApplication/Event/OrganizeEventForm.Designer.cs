namespace AuntRosieApplication.Event
{
    partial class frmOrganizeEvent
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
            this.radNew = new System.Windows.Forms.RadioButton();
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.grbExists = new System.Windows.Forms.GroupBox();
            this.radExisting = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlNewLoc = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtnewLocName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewTypeClose = new System.Windows.Forms.Button();
            this.btnNewTypeCancel = new System.Windows.Forms.Button();
            this.btnNewTypetClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grbNew.SuspendLayout();
            this.grbExists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNewLoc.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Checked = true;
            this.radNew.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNew.Location = new System.Drawing.Point(6, 0);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(91, 24);
            this.radNew.TabIndex = 1;
            this.radNew.TabStop = true;
            this.radNew.Text = "New Event";
            this.radNew.UseVisualStyleBackColor = true;
            // 
            // grbNew
            // 
            this.grbNew.Controls.Add(this.txtEventName);
            this.grbNew.Controls.Add(this.label7);
            this.grbNew.Controls.Add(this.label2);
            this.grbNew.Controls.Add(this.btnAddLocation);
            this.grbNew.Controls.Add(this.radNew);
            this.grbNew.Controls.Add(this.cmbName);
            this.grbNew.Controls.Add(this.dtpFormDate);
            this.grbNew.Controls.Add(this.lblName);
            this.grbNew.Controls.Add(this.label9);
            this.grbNew.Location = new System.Drawing.Point(38, 68);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(512, 242);
            this.grbNew.TabIndex = 2;
            this.grbNew.TabStop = false;
            this.grbNew.Text = "groupBox1";
            // 
            // grbExists
            // 
            this.grbExists.Controls.Add(this.dataGridView1);
            this.grbExists.Controls.Add(this.radExisting);
            this.grbExists.Location = new System.Drawing.Point(32, 316);
            this.grbExists.Name = "grbExists";
            this.grbExists.Size = new System.Drawing.Size(512, 157);
            this.grbExists.TabIndex = 3;
            this.grbExists.TabStop = false;
            this.grbExists.Text = "groupBox2";
            // 
            // radExisting
            // 
            this.radExisting.AutoSize = true;
            this.radExisting.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExisting.Location = new System.Drawing.Point(6, 0);
            this.radExisting.Name = "radExisting";
            this.radExisting.Size = new System.Drawing.Size(116, 24);
            this.radExisting.TabIndex = 1;
            this.radExisting.TabStop = true;
            this.radExisting.Text = "Existing Event";
            this.radExisting.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 96);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 38);
            this.panel1.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Orgnize Event- Step1";
            // 
            // cmbName
            // 
            this.cmbName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(161, 120);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(281, 31);
            this.cmbName.TabIndex = 108;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblName.Location = new System.Drawing.Point(20, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 22);
            this.lblName.TabIndex = 107;
            this.lblName.Tag = "";
            this.lblName.Text = "Event Location";
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormDate.Location = new System.Drawing.Point(161, 30);
            this.dtpFormDate.Name = "dtpFormDate";
            this.dtpFormDate.Size = new System.Drawing.Size(281, 26);
            this.dtpFormDate.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label9.Location = new System.Drawing.Point(22, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 22);
            this.label9.TabIndex = 111;
            this.label9.Tag = "";
            this.label9.Text = "Event Date";
            // 
            // pnlNewLoc
            // 
            this.pnlNewLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewLoc.Controls.Add(this.txtnewLocName);
            this.pnlNewLoc.Controls.Add(this.label1);
            this.pnlNewLoc.Controls.Add(this.txtPostalCode);
            this.pnlNewLoc.Controls.Add(this.textBox6);
            this.pnlNewLoc.Controls.Add(this.txtProvince);
            this.pnlNewLoc.Controls.Add(this.label3);
            this.pnlNewLoc.Controls.Add(this.label6);
            this.pnlNewLoc.Controls.Add(this.txtStreet);
            this.pnlNewLoc.Controls.Add(this.label5);
            this.pnlNewLoc.Controls.Add(this.txtCity);
            this.pnlNewLoc.Controls.Add(this.panel4);
            this.pnlNewLoc.Controls.Add(this.btnNewTypeCancel);
            this.pnlNewLoc.Controls.Add(this.btnNewTypetClear);
            this.pnlNewLoc.Location = new System.Drawing.Point(-9, 143);
            this.pnlNewLoc.Name = "pnlNewLoc";
            this.pnlNewLoc.Size = new System.Drawing.Size(360, 290);
            this.pnlNewLoc.TabIndex = 114;
            this.pnlNewLoc.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnNewTypeClose);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 35);
            this.panel4.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(97, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 22);
            this.label12.TabIndex = 102;
            this.label12.Tag = "";
            this.label12.Text = "Add NewLlocation";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AutoSize = true;
            this.txtPostalCode.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPostalCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPostalCode.Location = new System.Drawing.Point(34, 197);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(115, 22);
            this.txtPostalCode.TabIndex = 118;
            this.txtPostalCode.Text = "Postal Code";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.textBox6.Location = new System.Drawing.Point(168, 190);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 29);
            this.textBox6.TabIndex = 114;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtProvince.Location = new System.Drawing.Point(168, 80);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(168, 29);
            this.txtProvince.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(84, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 117;
            this.label3.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(65, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "Province";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtStreet.Location = new System.Drawing.Point(168, 155);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(168, 29);
            this.txtStreet.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(107, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 116;
            this.label5.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtCity.Location = new System.Drawing.Point(168, 120);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(168, 29);
            this.txtCity.TabIndex = 112;
            // 
            // txtnewLocName
            // 
            this.txtnewLocName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtnewLocName.Location = new System.Drawing.Point(168, 41);
            this.txtnewLocName.Name = "txtnewLocName";
            this.txtnewLocName.Size = new System.Drawing.Size(168, 29);
            this.txtnewLocName.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 120;
            this.label1.Text = "Location Name";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(161, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 56);
            this.label2.TabIndex = 114;
            this.label2.Text = "Event Location:   ";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtEventName.Location = new System.Drawing.Point(161, 75);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(281, 29);
            this.txtEventName.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 122;
            this.label7.Text = "Event Name";
            // 
            // btnNewTypeClose
            // 
            this.btnNewTypeClose.Image = global::AuntRosieApplication.Properties.Resources.close_window;
            this.btnNewTypeClose.Location = new System.Drawing.Point(0, -2);
            this.btnNewTypeClose.Name = "btnNewTypeClose";
            this.btnNewTypeClose.Size = new System.Drawing.Size(41, 38);
            this.btnNewTypeClose.TabIndex = 17;
            this.btnNewTypeClose.UseVisualStyleBackColor = true;
            this.btnNewTypeClose.Click += new System.EventHandler(this.btnNewTypeClose_Click);
            // 
            // btnNewTypeCancel
            // 
            this.btnNewTypeCancel.Image = global::AuntRosieApplication.Properties.Resources.file_delete;
            this.btnNewTypeCancel.Location = new System.Drawing.Point(195, 230);
            this.btnNewTypeCancel.Name = "btnNewTypeCancel";
            this.btnNewTypeCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypeCancel.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnNewTypeCancel, "Cancel");
            this.btnNewTypeCancel.UseVisualStyleBackColor = true;
            // 
            // btnNewTypetClear
            // 
            this.btnNewTypetClear.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewTypetClear.Location = new System.Drawing.Point(131, 230);
            this.btnNewTypetClear.Name = "btnNewTypetClear";
            this.btnNewTypetClear.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypetClear.TabIndex = 15;
            this.btnNewTypetClear.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::AuntRosieApplication.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(283, 479);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 59);
            this.btnNext.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_window;
            this.btnClose.Location = new System.Drawing.Point(0, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 38);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddLocation.Location = new System.Drawing.Point(448, 120);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(41, 42);
            this.btnAddLocation.TabIndex = 113;
            this.toolTip1.SetToolTip(this.btnAddLocation, "Add new Location");
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1, 544);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(549, 23);
            this.progressBar1.TabIndex = 136;
            this.progressBar1.Value = 25;
            // 
            // frmOrganizeEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 568);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pnlNewLoc);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbExists);
            this.Controls.Add(this.grbNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrganizeEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizeEventForm";
            this.Load += new System.EventHandler(this.frmOrganizeEvent_Load);
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            this.grbExists.ResumeLayout(false);
            this.grbExists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNewLoc.ResumeLayout(false);
            this.pnlNewLoc.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.GroupBox grbExists;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radExisting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlNewLoc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNewTypeClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewTypeCancel;
        private System.Windows.Forms.Button btnNewTypetClear;
        private System.Windows.Forms.TextBox txtnewLocName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPostalCode;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}