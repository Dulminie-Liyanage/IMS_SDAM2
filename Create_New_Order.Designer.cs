namespace IMS
{
    partial class Create_New_Order
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateNewOrder = new Button();
            Produtlabel = new Label();
            ProductNametextBox = new TextBox();
            OrderIDtextBox = new TextBox();
            Supplier = new Label();
            SuppliertextBox = new TextBox();
            Quantity = new Label();
            QuantitytextBox = new TextBox();
            Status = new Label();
            StatustextBox = new TextBox();
            CreateBtn = new Button();
            ClearBtn = new Button();
            SKUlabel = new Label();
            BackBtn = new Button();
            Datelabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // CreateNewOrder
            // 
            CreateNewOrder.Location = new Point(234, 12);
            CreateNewOrder.Name = "CreateNewOrder";
            CreateNewOrder.Size = new Size(233, 47);
            CreateNewOrder.TabIndex = 0;
            CreateNewOrder.Text = "Create New Order";
            CreateNewOrder.UseVisualStyleBackColor = true;
            // 
            // Produtlabel
            // 
            Produtlabel.AutoSize = true;
            Produtlabel.Location = new Point(36, 167);
            Produtlabel.Name = "Produtlabel";
            Produtlabel.Size = new Size(135, 25);
            Produtlabel.TabIndex = 1;
            Produtlabel.Text = "Product Name :";
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Location = new Point(202, 164);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(265, 31);
            ProductNametextBox.TabIndex = 2;
            ProductNametextBox.TextChanged += textBox1_TextChanged;
            // 
            // OrderIDtextBox
            // 
            OrderIDtextBox.Location = new Point(202, 96);
            OrderIDtextBox.Name = "OrderIDtextBox";
            OrderIDtextBox.Size = new Size(265, 31);
            OrderIDtextBox.TabIndex = 4;
            OrderIDtextBox.TextChanged += OrderIDtextBox_TextChanged;
            // 
            // Supplier
            // 
            Supplier.AutoSize = true;
            Supplier.Location = new Point(36, 238);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(86, 25);
            Supplier.TabIndex = 5;
            Supplier.Text = "Supplier :";
            // 
            // SuppliertextBox
            // 
            SuppliertextBox.Location = new Point(202, 235);
            SuppliertextBox.Name = "SuppliertextBox";
            SuppliertextBox.Size = new Size(265, 31);
            SuppliertextBox.TabIndex = 6;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(36, 308);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(89, 25);
            Quantity.TabIndex = 7;
            Quantity.Text = "Quantity :";
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(202, 305);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(189, 31);
            QuantitytextBox.TabIndex = 8;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(46, 376);
            Status.Name = "Status";
            Status.Size = new Size(69, 25);
            Status.TabIndex = 9;
            Status.Text = "Status :";
            Status.Click += label1_Click_1;
            // 
            // StatustextBox
            // 
            StatustextBox.Location = new Point(202, 371);
            StatustextBox.Name = "StatustextBox";
            StatustextBox.Size = new Size(189, 31);
            StatustextBox.TabIndex = 10;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(67, 540);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(112, 45);
            CreateBtn.TabIndex = 11;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(286, 542);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(105, 40);
            ClearBtn.TabIndex = 15;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // SKUlabel
            // 
            SKUlabel.AutoSize = true;
            SKUlabel.Location = new Point(38, 99);
            SKUlabel.Name = "SKUlabel";
            SKUlabel.Size = new Size(104, 25);
            SKUlabel.TabIndex = 16;
            SKUlabel.Text = "Order SKU :";
            SKUlabel.Click += SKUlabel_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(506, 545);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(117, 40);
            BackBtn.TabIndex = 17;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.Location = new Point(46, 448);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(58, 25);
            Datelabel.TabIndex = 18;
            Datelabel.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(202, 448);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 20;
            // 
            // Create_New_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 622);
            Controls.Add(dateTimePicker1);
            Controls.Add(Datelabel);
            Controls.Add(BackBtn);
            Controls.Add(SKUlabel);
            Controls.Add(ClearBtn);
            Controls.Add(CreateBtn);
            Controls.Add(StatustextBox);
            Controls.Add(Status);
            Controls.Add(QuantitytextBox);
            Controls.Add(Quantity);
            Controls.Add(SuppliertextBox);
            Controls.Add(Supplier);
            Controls.Add(OrderIDtextBox);
            Controls.Add(ProductNametextBox);
            Controls.Add(Produtlabel);
            Controls.Add(CreateNewOrder);
            Name = "Create_New_Order";
            Text = "Create_New_Order";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateNewOrder;
        private Label Produtlabel;
        private TextBox ProductNametextBox;
        private TextBox OrderIDtextBox;
        private Label Supplier;
        private TextBox SuppliertextBox;
        private Label Quantity;
        private TextBox QuantitytextBox;
        private Label Status;
        private TextBox StatustextBox;
        private Button CreateBtn;
        private Button ClearBtn;
        private Label SKUlabel;
        private Button BackBtn;
        private Label Datelabel;
        private DateTimePicker dateTimePicker1;
    }
}
