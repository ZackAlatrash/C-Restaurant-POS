﻿namespace UI.UserControls
{
    partial class MenuItemUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDishName = new Label();
            btnAmountIncrease = new Button();
            btnAmountDecrease = new Button();
            lblAmount = new Label();
            SuspendLayout();
            // 
            // lblDishName
            // 
            lblDishName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDishName.Location = new Point(3, 5);
            lblDishName.Name = "lblDishName";
            lblDishName.Size = new Size(311, 57);
            lblDishName.TabIndex = 0;
            lblDishName.Text = "DishName";
            lblDishName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAmountIncrease
            // 
            btnAmountIncrease.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAmountIncrease.Location = new Point(320, 27);
            btnAmountIncrease.Name = "btnAmountIncrease";
            btnAmountIncrease.Size = new Size(25, 25);
            btnAmountIncrease.TabIndex = 1;
            btnAmountIncrease.Text = "+";
            btnAmountIncrease.UseVisualStyleBackColor = true;
            btnAmountIncrease.Click += btnAmountIncrease_Click;
            // 
            // btnAmountDecrease
            // 
            btnAmountDecrease.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAmountDecrease.Location = new Point(399, 27);
            btnAmountDecrease.Name = "btnAmountDecrease";
            btnAmountDecrease.Size = new Size(25, 25);
            btnAmountDecrease.TabIndex = 2;
            btnAmountDecrease.Text = "-";
            btnAmountDecrease.UseVisualStyleBackColor = true;
            btnAmountDecrease.Click += btnAmountDecrease_Click;
            // 
            // lblAmount
            // 
            lblAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(351, 13);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(40, 47);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "0";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuItemUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lblAmount);
            Controls.Add(btnAmountDecrease);
            Controls.Add(btnAmountIncrease);
            Controls.Add(lblDishName);
            Name = "MenuItemUserControl";
            Size = new Size(457, 69);
            Load += MenuItemUserControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblDishName;
        private Button btnAmountIncrease;
        private Button btnAmountDecrease;
        private Label lblAmount;
    }
}
