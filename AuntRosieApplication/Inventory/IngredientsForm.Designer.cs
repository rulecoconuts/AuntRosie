namespace AuntRosieApplication.Inventory
{
    partial class frmIngredients
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
            this.pnlNewIngredint = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtstoringNote = new System.Windows.Forms.TextBox();
            this.cmbNewtype = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNewIngredintCancel = new System.Windows.Forms.Button();
            this.btnNewIngredintSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNewIngredintName = new System.Windows.Forms.TextBox();
            this.pnlNewIngredint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewIngredint
            // 
            this.pnlNewIngredint.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlNewIngredint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewIngredint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewIngredint.Controls.Add(this.label13);
            this.pnlNewIngredint.Controls.Add(this.label16);
            this.pnlNewIngredint.Controls.Add(this.txtstoringNote);
            this.pnlNewIngredint.Controls.Add(this.cmbNewtype);
            this.pnlNewIngredint.Controls.Add(this.label15);
            this.pnlNewIngredint.Controls.Add(this.btnNewIngredintCancel);
            this.pnlNewIngredint.Controls.Add(this.btnNewIngredintSave);
            this.pnlNewIngredint.Controls.Add(this.label14);
            this.pnlNewIngredint.Controls.Add(this.txtNewIngredintName);
            this.pnlNewIngredint.Location = new System.Drawing.Point(211, 103);
            this.pnlNewIngredint.Name = "pnlNewIngredint";
            this.pnlNewIngredint.Size = new System.Drawing.Size(379, 245);
            this.pnlNewIngredint.TabIndex = 62;
            this.pnlNewIngredint.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.Goldenrod;
            this.label13.Location = new System.Drawing.Point(95, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 22);
            this.label13.TabIndex = 102;
            this.label13.Tag = "";
            this.label13.Text = "Add New Ingredint ";
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
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(84, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 22);
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
            this.btnNewIngredintCancel.UseVisualStyleBackColor = true;
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
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(76, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 22);
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
            // frmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlNewIngredint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngredients";
            this.Text = "ingredients";
            this.pnlNewIngredint.ResumeLayout(false);
            this.pnlNewIngredint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewIngredint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtstoringNote;
        private System.Windows.Forms.ComboBox cmbNewtype;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnNewIngredintCancel;
        private System.Windows.Forms.Button btnNewIngredintSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNewIngredintName;
    }
}