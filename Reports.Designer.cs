﻿namespace IMS
{
    partial class dgvReports
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
            rbStockLevels = new RadioButton();
            rbMostOrdered = new RadioButton();
            lblTitle = new Label();
            btnBack = new Button();
            btnGenerate = new Button();
            dataGridView2 = new DataGridView();
            SKU = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            TotalOrdered = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // rbStockLevels
            // 
            rbStockLevels.AutoSize = true;
            rbStockLevels.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbStockLevels.Location = new Point(39, 97);
            rbStockLevels.Margin = new Padding(4);
            rbStockLevels.Name = "rbStockLevels";
            rbStockLevels.Size = new Size(248, 34);
            rbStockLevels.TabIndex = 1;
            rbStockLevels.TabStop = true;
            rbStockLevels.Text = "Current Stock Levels";
            rbStockLevels.UseVisualStyleBackColor = true;
            rbStockLevels.CheckedChanged += rbStockLevels_CheckedChanged;
            // 
            // rbMostOrdered
            // 
            rbMostOrdered.AutoSize = true;
            rbMostOrdered.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbMostOrdered.Location = new Point(369, 97);
            rbMostOrdered.Margin = new Padding(4);
            rbMostOrdered.Name = "rbMostOrdered";
            rbMostOrdered.Size = new Size(283, 34);
            rbMostOrdered.TabIndex = 2;
            rbMostOrdered.TabStop = true;
            rbMostOrdered.Text = "Most Ordered Products";
            rbMostOrdered.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(155, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 38);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Inventory Reports";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Location = new Point(449, 498);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(182, 44);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back to Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerate.Location = new Point(39, 498);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(199, 44);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { SKU, Name, TotalOrdered, Quantity });
            dataGridView2.Location = new Point(28, 139);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(646, 321);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // SKU
            // 
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 8;
            SKU.Name = "SKU";
            SKU.Width = 150;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // TotalOrdered
            // 
            TotalOrdered.HeaderText = "Total Ordered";
            TotalOrdered.MinimumWidth = 8;
            TotalOrdered.Name = "TotalOrdered";
            TotalOrdered.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // dgvReports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 562);
            Controls.Add(btnGenerate);
            Controls.Add(btnBack);
            Controls.Add(dataGridView2);
            Controls.Add(lblTitle);
            Controls.Add(rbMostOrdered);
            Controls.Add(rbStockLevels);
            Margin = new Padding(4);
            Name = "dgvReports";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbStockLevels;
        private RadioButton rbMostOrdered;
        private Label lblTitle;
        private Button btnBack;
        private Button btnGenerate;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn TotalOrdered;
        private DataGridViewTextBoxColumn Quantity;
    }
}