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
            SearchOrder.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchOrder.Location = new Point(419, 31);
            SearchOrder.Margin = new Padding(4, 0, 4, 0);
            SearchOrder.Name = "SearchOrder";
            SearchOrder.Size = new Size(215, 45);
            SearchOrder.TabIndex = 0;
            SearchOrder.Text = "Search Order";
            SearchOrder.Click += SearchOrder_Click;
            // 
            // OrderSKU
            // 
            OrderSKU.AutoSize = true;
            OrderSKU.Location = new Point(59, 154);
            OrderSKU.Margin = new Padding(4, 0, 4, 0);
            OrderSKU.Name = "OrderSKU";
            OrderSKU.Size = new Size(264, 32);
            OrderSKU.TabIndex = 1;
            OrderSKU.Text = "Search by Order SKU :";
            // 
            // SKUtextBox
            // 
            SKUtextBox.Location = new Point(364, 146);
            SKUtextBox.Margin = new Padding(4, 4, 4, 4);
            SKUtextBox.Name = "SKUtextBox";
            SKUtextBox.Size = new Size(368, 39);
            SKUtextBox.TabIndex = 2;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(785, 142);
            SearchBtn.Margin = new Padding(4, 4, 4, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(157, 44);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(969, 142);
            BackBtn.Margin = new Padding(4, 4, 4, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(157, 44);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(188, 279);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(812, 106);
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
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1187, 451);
            Controls.Add(dataGridView1);
            Controls.Add(BackBtn);
            Controls.Add(SearchBtn);
            Controls.Add(SKUtextBox);
            Controls.Add(OrderSKU);
            Controls.Add(SearchOrder);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
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