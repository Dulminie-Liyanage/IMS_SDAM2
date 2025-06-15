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
            label1 = new Label();
            SuspendLayout();
            // 
            // Produtlabel
            // 
            Produtlabel.AutoSize = true;
            Produtlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Produtlabel.Location = new Point(61, 254);
            Produtlabel.Margin = new Padding(5, 0, 5, 0);
            Produtlabel.Name = "Produtlabel";
            Produtlabel.Size = new Size(175, 30);
            Produtlabel.TabIndex = 1;
            Produtlabel.Text = "Product Name :";
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Location = new Point(268, 244);
            ProductNametextBox.Margin = new Padding(5);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(448, 45);
            ProductNametextBox.TabIndex = 2;
            ProductNametextBox.TextChanged += textBox1_TextChanged;
            // 
            // OrderIDtextBox
            // 
            OrderIDtextBox.Location = new Point(268, 140);
            OrderIDtextBox.Margin = new Padding(5);
            OrderIDtextBox.Name = "OrderIDtextBox";
            OrderIDtextBox.Size = new Size(448, 45);
            OrderIDtextBox.TabIndex = 4;
            OrderIDtextBox.TextChanged += OrderIDtextBox_TextChanged;
            // 
            // Supplier
            // 
            Supplier.AutoSize = true;
            Supplier.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Supplier.Location = new Point(61, 362);
            Supplier.Margin = new Padding(5, 0, 5, 0);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(111, 30);
            Supplier.TabIndex = 5;
            Supplier.Text = "Supplier :";
            // 
            // SuppliertextBox
            // 
            SuppliertextBox.Location = new Point(268, 352);
            SuppliertextBox.Margin = new Padding(5);
            SuppliertextBox.Name = "SuppliertextBox";
            SuppliertextBox.Size = new Size(448, 45);
            SuppliertextBox.TabIndex = 6;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quantity.Location = new Point(61, 468);
            Quantity.Margin = new Padding(5, 0, 5, 0);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(116, 30);
            Quantity.TabIndex = 7;
            Quantity.Text = "Quantity :";
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(268, 458);
            QuantitytextBox.Margin = new Padding(5);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(318, 45);
            QuantitytextBox.TabIndex = 8;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.Location = new Point(65, 574);
            Status.Margin = new Padding(5, 0, 5, 0);
            Status.Name = "Status";
            Status.Size = new Size(89, 30);
            Status.TabIndex = 9;
            Status.Text = "Status :";
            Status.Click += label1_Click_1;
            // 
            // StatustextBox
            // 
            StatustextBox.Location = new Point(268, 559);
            StatustextBox.Margin = new Padding(5);
            StatustextBox.Name = "StatustextBox";
            StatustextBox.Size = new Size(318, 45);
            StatustextBox.TabIndex = 10;
            // 
            // CreateBtn
            // 
            CreateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateBtn.Location = new Point(146, 799);
            CreateBtn.Margin = new Padding(5);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(122, 61);
            CreateBtn.TabIndex = 11;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBtn.Location = new Point(457, 801);
            ClearBtn.Margin = new Padding(5);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(129, 57);
            ClearBtn.TabIndex = 15;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // SKUlabel
            // 
            SKUlabel.AutoSize = true;
            SKUlabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SKUlabel.Location = new Point(65, 150);
            SKUlabel.Margin = new Padding(5, 0, 5, 0);
            SKUlabel.Name = "SKUlabel";
            SKUlabel.Size = new Size(134, 30);
            SKUlabel.TabIndex = 16;
            SKUlabel.Text = "Order SKU :";
            SKUlabel.Click += SKUlabel_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(860, 828);
            BackBtn.Margin = new Padding(5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(199, 61);
            BackBtn.TabIndex = 17;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Datelabel.Location = new Point(65, 681);
            Datelabel.Margin = new Padding(5, 0, 5, 0);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(74, 30);
            Datelabel.TabIndex = 18;
            Datelabel.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(268, 669);
            dateTimePicker1.Margin = new Padding(5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(480, 39);
            dateTimePicker1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 58);
            label1.Name = "label1";
            label1.Size = new Size(251, 38);
            label1.TabIndex = 21;
            label1.Text = "Create New Order";
            // 
            // Create_New_Order
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(868, 922);
            Controls.Add(label1);
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
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Create_New_Order";
            Text = "Create_New_Order";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
    }
}
