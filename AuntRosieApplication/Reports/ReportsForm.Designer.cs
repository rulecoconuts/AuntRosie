namespace AuntRosieApplication.Reports
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChangeIngredientPrice = new System.Windows.Forms.Button();
            this.btnNutrition = new System.Windows.Forms.Button();
            this.btnLowStock = new System.Windows.Forms.Button();
            this.btnEmployeeEvent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeIngredientPrice
            // 
            this.btnChangeIngredientPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeIngredientPrice.BackgroundImage")));
            this.btnChangeIngredientPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeIngredientPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeIngredientPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnChangeIngredientPrice.Image = global::AuntRosieApplication.Properties.Resources.price_comparison;
            this.btnChangeIngredientPrice.Location = new System.Drawing.Point(574, 71);
            this.btnChangeIngredientPrice.Name = "btnChangeIngredientPrice";
            this.btnChangeIngredientPrice.Size = new System.Drawing.Size(260, 225);
            this.btnChangeIngredientPrice.TabIndex = 8;
            this.btnChangeIngredientPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnChangeIngredientPrice, "Changes in the prices of ingredients");
            this.btnChangeIngredientPrice.UseVisualStyleBackColor = true;
            this.btnChangeIngredientPrice.Click += new System.EventHandler(this.btnChangeIngredientPrice_Click);
            // 
            // btnNutrition
            // 
            this.btnNutrition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNutrition.BackgroundImage")));
            this.btnNutrition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNutrition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNutrition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNutrition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNutrition.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnNutrition.Image = global::AuntRosieApplication.Properties.Resources.clothes_tag;
            this.btnNutrition.Location = new System.Drawing.Point(308, 71);
            this.btnNutrition.Name = "btnNutrition";
            this.btnNutrition.Size = new System.Drawing.Size(260, 225);
            this.btnNutrition.TabIndex = 7;
            this.btnNutrition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnNutrition, "Nutritional Information per product");
            this.btnNutrition.UseVisualStyleBackColor = true;
            this.btnNutrition.Click += new System.EventHandler(this.btnNutrition_Click);
            // 
            // btnLowStock
            // 
            this.btnLowStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLowStock.BackgroundImage")));
            this.btnLowStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLowStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLowStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLowStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowStock.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnLowStock.Image = global::AuntRosieApplication.Properties.Resources.low_battery;
            this.btnLowStock.Location = new System.Drawing.Point(42, 72);
            this.btnLowStock.Name = "btnLowStock";
            this.btnLowStock.Size = new System.Drawing.Size(260, 225);
            this.btnLowStock.TabIndex = 6;
            this.btnLowStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnLowStock, "Low stock ingredients");
            this.btnLowStock.UseVisualStyleBackColor = true;
            this.btnLowStock.Click += new System.EventHandler(this.btnLowStock_Click_1);
            // 
            // btnEmployeeEvent
            // 
            this.btnEmployeeEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeEvent.BackgroundImage")));
            this.btnEmployeeEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmployeeEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeEvent.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnEmployeeEvent.Image = global::AuntRosieApplication.Properties.Resources.workers_male;
            this.btnEmployeeEvent.Location = new System.Drawing.Point(42, 302);
            this.btnEmployeeEvent.Name = "btnEmployeeEvent";
            this.btnEmployeeEvent.Size = new System.Drawing.Size(260, 225);
            this.btnEmployeeEvent.TabIndex = 12;
            this.btnEmployeeEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnEmployeeEvent, "Employees per event location");
            this.btnEmployeeEvent.UseVisualStyleBackColor = true;
            this.btnEmployeeEvent.Click += new System.EventHandler(this.btnEmployeeEvent_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.button1.Location = new System.Drawing.Point(574, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 225);
            this.button1.TabIndex = 11;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.button2.Location = new System.Drawing.Point(308, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 225);
            this.button2.TabIndex = 10;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(799, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 112;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(329, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 30);
            this.lblTitle.TabIndex = 113;
            this.lblTitle.Text = "Reports";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEmployeeEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChangeIngredientPrice);
            this.Controls.Add(this.btnNutrition);
            this.Controls.Add(this.btnLowStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChangeIngredientPrice;
        private System.Windows.Forms.Button btnNutrition;
        private System.Windows.Forms.Button btnLowStock;
        private System.Windows.Forms.Button btnEmployeeEvent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}