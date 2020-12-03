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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnChangeIngredientPrice = new System.Windows.Forms.Button();
            this.btnNutrition = new System.Windows.Forms.Button();
            this.btnLowStock = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.button2);
            this.pnlMain.Controls.Add(this.button3);
            this.pnlMain.Controls.Add(this.btnChangeIngredientPrice);
            this.pnlMain.Controls.Add(this.btnNutrition);
            this.pnlMain.Controls.Add(this.btnLowStock);
            this.pnlMain.Location = new System.Drawing.Point(3, -5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(819, 478);
            this.pnlMain.TabIndex = 10;
            this.pnlMain.Visible = false;
            // 
            // btnChangeIngredientPrice
            // 
            this.btnChangeIngredientPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeIngredientPrice.BackgroundImage")));
            this.btnChangeIngredientPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeIngredientPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeIngredientPrice.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnChangeIngredientPrice.Image = global::AuntRosieApplication.Properties.Resources.price_comparison;
            this.btnChangeIngredientPrice.Location = new System.Drawing.Point(548, 14);
            this.btnChangeIngredientPrice.Name = "btnChangeIngredientPrice";
            this.btnChangeIngredientPrice.Size = new System.Drawing.Size(260, 225);
            this.btnChangeIngredientPrice.TabIndex = 2;
            this.btnChangeIngredientPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnChangeIngredientPrice, "Changes in the prices of ingredients");
            this.btnChangeIngredientPrice.UseVisualStyleBackColor = true;
            // 
            // btnNutrition
            // 
            this.btnNutrition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNutrition.BackgroundImage")));
            this.btnNutrition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNutrition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNutrition.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnNutrition.Image = global::AuntRosieApplication.Properties.Resources.clothes_tag;
            this.btnNutrition.Location = new System.Drawing.Point(282, 14);
            this.btnNutrition.Name = "btnNutrition";
            this.btnNutrition.Size = new System.Drawing.Size(260, 225);
            this.btnNutrition.TabIndex = 1;
            this.btnNutrition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnNutrition, "Nutritional Information per product");
            this.btnNutrition.UseVisualStyleBackColor = true;
            // 
            // btnLowStock
            // 
            this.btnLowStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLowStock.BackgroundImage")));
            this.btnLowStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLowStock.FlatAppearance.BorderSize = 0;
            this.btnLowStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnLowStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnLowStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLowStock.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.btnLowStock.Image = global::AuntRosieApplication.Properties.Resources.low_battery;
            this.btnLowStock.Location = new System.Drawing.Point(16, 14);
            this.btnLowStock.Name = "btnLowStock";
            this.btnLowStock.Size = new System.Drawing.Size(260, 225);
            this.btnLowStock.TabIndex = 0;
            this.btnLowStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnLowStock, "Low stock ingredients");
            this.btnLowStock.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.button1.Location = new System.Drawing.Point(548, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 225);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.button2.Location = new System.Drawing.Point(282, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 225);
            this.button2.TabIndex = 4;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.button3.Location = new System.Drawing.Point(16, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 225);
            this.button3.TabIndex = 3;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 485);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnChangeIngredientPrice;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNutrition;
        private System.Windows.Forms.Button btnLowStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}