namespace IMS
{
    partial class Search_Product
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
            btnBack = new Button();
            btnSearch = new Button();
            txtsku = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvSearchResults = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(471, 108);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 36);
            btnBack.TabIndex = 48;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(346, 109);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 36);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtsku
            // 
            txtsku.Location = new Point(174, 110);
            txtsku.Margin = new Padding(4);
            txtsku.Name = "txtsku";
            txtsku.Size = new Size(150, 31);
            txtsku.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 44;
            label2.Text = "Search by SKU: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 43;
            label1.Text = "Search Product";
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchResults.BackgroundColor = SystemColors.Window;
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Columns.AddRange(new DataGridViewColumn[] { Product_ID, Name, Quantity, Price, Category });
            dgvSearchResults.Location = new Point(15, 176);
            dgvSearchResults.Margin = new Padding(4);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.ReadOnly = true;
            dgvSearchResults.RowHeadersWidth = 51;
            dgvSearchResults.Size = new Size(600, 100);
            dgvSearchResults.TabIndex = 49;
            // 
            // Product_ID
            // 
            Product_ID.HeaderText = "Product ID";
            Product_ID.MinimumWidth = 6;
            Product_ID.Name = "Product_ID";
            Product_ID.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category ";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Search_Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 338);
            Controls.Add(dgvSearchResults);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(txtsku);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Search_Product";
            Text = "Search_Product";
            Load += Search_Product_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtsku;
        private Label label2;
        private Label label1;
        private DataGridView dgvSearchResults;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Category;
    }
}