namespace IMS
{
    partial class Search_Order
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
            SearchOrder = new Label();
            OrderSKU = new Label();
            SKUtextBox = new TextBox();
            SearchBtn = new Button();
            BackBtn = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchOrder
            // 
            SearchOrder.AutoSize = true;
            SearchOrder.Location = new Point(304, 36);
            SearchOrder.Name = "SearchOrder";
            SearchOrder.Size = new Size(115, 25);
            SearchOrder.TabIndex = 0;
            SearchOrder.Text = "Search Order";
            SearchOrder.Click += SearchOrder_Click;
            // 
            // OrderSKU
            // 
            OrderSKU.AutoSize = true;
            OrderSKU.Location = new Point(42, 120);
            OrderSKU.Name = "OrderSKU";
            OrderSKU.Size = new Size(186, 25);
            OrderSKU.TabIndex = 1;
            OrderSKU.Text = "Search by Order SKU :";
            // 
            // SKUtextBox
            // 
            SKUtextBox.Location = new Point(260, 114);
            SKUtextBox.Name = "SKUtextBox";
            SKUtextBox.Size = new Size(264, 31);
            SKUtextBox.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(561, 111);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(112, 34);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(692, 111);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(112, 34);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(812, 95);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product SKU";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Search_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 352);
            Controls.Add(dataGridView1);
            Controls.Add(BackBtn);
            Controls.Add(SearchBtn);
            Controls.Add(SKUtextBox);
            Controls.Add(OrderSKU);
            Controls.Add(SearchOrder);
            Name = "Search_Order";
            Text = "Search_Order";
            Load += Search_Order_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchOrder;
        private Label OrderSKU;
        private TextBox SKUtextBox;
        private Button SearchBtn;
        private Button BackBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}