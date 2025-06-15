namespace IMS
{
    partial class low_stock
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
            lblTitle = new Label();
            btnCheck = new Button();
            numLimit = new NumericUpDown();
            dgvStock = new DataGridView();
            SKU = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            lblLimit = new Label();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
            lblTitle.Location = new Point(221, 70);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Low Stock Alert";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.Info;
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheck.Location = new Point(485, 141);
            btnCheck.Margin = new Padding(4, 4, 4, 4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(118, 36);
            btnCheck.TabIndex = 7;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += subbtn_Click;
            // 
            // numLimit
            // 
            numLimit.Location = new Point(394, 144);
            numLimit.Margin = new Padding(4, 4, 4, 4);
            numLimit.Name = "numLimit";
            numLimit.Size = new Size(65, 31);
            numLimit.TabIndex = 8;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { SKU, Name, Quantity });
            dgvStock.Location = new Point(32, 220);
            dgvStock.Margin = new Padding(4, 4, 4, 4);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(427, 91);
            dgvStock.TabIndex = 9;
            // 
            // SKU
            // 
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 6;
            SKU.Name = "SKU";
            SKU.ReadOnly = true;
            SKU.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // lblLimit
            // 
            lblLimit.AutoSize = true;
            lblLimit.Font = new Font("Segoe UI", 11F);
            lblLimit.Location = new Point(32, 144);
            lblLimit.Margin = new Padding(4, 0, 4, 0);
            lblLimit.Name = "lblLimit";
            lblLimit.Size = new Size(381, 30);
            lblLimit.TabIndex = 10;
            lblLimit.Text = "Show products with quantity less than:";
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.Info;
            backbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            backbtn.Location = new Point(610, 141);
            backbtn.Margin = new Padding(4, 4, 4, 4);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(118, 36);
            backbtn.TabIndex = 11;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // low_stock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(761, 389);
            Controls.Add(backbtn);
            Controls.Add(lblLimit);
            Controls.Add(dgvStock);
            Controls.Add(numLimit);
            Controls.Add(btnCheck);
            Controls.Add(lblTitle);
            Cursor = Cursors.Hand;
            Margin = new Padding(4, 4, 4, 4);
            Name = "low_stock";
            Text = "low_stock";
            ((System.ComponentModel.ISupportInitialize)numLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnCheck;
        private NumericUpDown numLimit;
        private DataGridView dgvStock;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private Label lblLimit;
        private Button backbtn;
    }
}