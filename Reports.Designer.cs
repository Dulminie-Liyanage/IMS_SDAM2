namespace IMS
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
            dataGridView2 = new DataGridView();
            btnBack = new Button();
            btnGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // rbStockLevels
            // 
            rbStockLevels.AutoSize = true;
            rbStockLevels.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbStockLevels.Location = new Point(200, 85);
            rbStockLevels.Name = "rbStockLevels";
            rbStockLevels.Size = new Size(172, 24);
            rbStockLevels.TabIndex = 1;
            rbStockLevels.TabStop = true;
            rbStockLevels.Text = "Current Stock Levels";
            rbStockLevels.UseVisualStyleBackColor = true;
            // 
            // rbMostOrdered
            // 
            rbMostOrdered.AutoSize = true;
            rbMostOrdered.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbMostOrdered.Location = new Point(412, 85);
            rbMostOrdered.Name = "rbMostOrdered";
            rbMostOrdered.Size = new Size(193, 24);
            rbMostOrdered.TabIndex = 2;
            rbMostOrdered.TabStop = true;
            rbMostOrdered.Text = "Most Ordered Products";
            rbMostOrdered.UseVisualStyleBackColor = true;
            
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(220, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 46);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Inventory Reports";
            lblTitle.Click += this.label1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(157, 115);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(515, 267);
            dataGridView2.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(443, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 35);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back to Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += this.button1_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerate.Location = new Point(246, 397);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(159, 35);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += this.btnGenerate_Click;
            // 
            // dgvReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerate);
            Controls.Add(btnBack);
            Controls.Add(dataGridView2);
            Controls.Add(lblTitle);
            Controls.Add(rbMostOrdered);
            Controls.Add(rbStockLevels);
            Name = "dgvReports";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbStockLevels;
        private RadioButton rbMostOrdered;
        private Label lblTitle;
        private DataGridView dataGridView2;
        private Button btnBack;
        private Button btnGenerate;
    }
}