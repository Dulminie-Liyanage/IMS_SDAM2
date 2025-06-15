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
            CreateNewOrder.Location = new Point(398, 18);
            CreateNewOrder.Margin = new Padding(5, 5, 5, 5);
            CreateNewOrder.Name = "CreateNewOrder";
            CreateNewOrder.Size = new Size(396, 71);
            CreateNewOrder.TabIndex = 0;
            CreateNewOrder.Text = "Create New Order";
            CreateNewOrder.UseVisualStyleBackColor = true;
            // 
            // Produtlabel
            // 
            Produtlabel.AutoSize = true;
            Produtlabel.Location = new Point(61, 254);
            Produtlabel.Margin = new Padding(5, 0, 5, 0);
            Produtlabel.Name = "Produtlabel";
            Produtlabel.Size = new Size(222, 38);
            Produtlabel.TabIndex = 1;
            Produtlabel.Text = "Product Name :";
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Location = new Point(343, 249);
            ProductNametextBox.Margin = new Padding(5, 5, 5, 5);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(448, 45);
            ProductNametextBox.TabIndex = 2;
            ProductNametextBox.TextChanged += textBox1_TextChanged;
            // 
            // OrderIDtextBox
            // 
            OrderIDtextBox.Location = new Point(343, 146);
            OrderIDtextBox.Margin = new Padding(5, 5, 5, 5);
            OrderIDtextBox.Name = "OrderIDtextBox";
            OrderIDtextBox.Size = new Size(448, 45);
            OrderIDtextBox.TabIndex = 4;
            OrderIDtextBox.TextChanged += OrderIDtextBox_TextChanged;
            // 
            // Supplier
            // 
            Supplier.AutoSize = true;
            Supplier.Location = new Point(61, 362);
            Supplier.Margin = new Padding(5, 0, 5, 0);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(142, 38);
            Supplier.TabIndex = 5;
            Supplier.Text = "Supplier :";
            // 
            // SuppliertextBox
            // 
            SuppliertextBox.Location = new Point(343, 357);
            SuppliertextBox.Margin = new Padding(5, 5, 5, 5);
            SuppliertextBox.Name = "SuppliertextBox";
            SuppliertextBox.Size = new Size(448, 45);
            SuppliertextBox.TabIndex = 6;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(61, 468);
            Quantity.Margin = new Padding(5, 0, 5, 0);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(148, 38);
            Quantity.TabIndex = 7;
            Quantity.Text = "Quantity :";
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(343, 464);
            QuantitytextBox.Margin = new Padding(5, 5, 5, 5);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(318, 45);
            QuantitytextBox.TabIndex = 8;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(78, 572);
            Status.Margin = new Padding(5, 0, 5, 0);
            Status.Name = "Status";
            Status.Size = new Size(114, 38);
            Status.TabIndex = 9;
            Status.Text = "Status :";
            Status.Click += label1_Click_1;
            // 
            // StatustextBox
            // 
            StatustextBox.Location = new Point(343, 564);
            StatustextBox.Margin = new Padding(5, 5, 5, 5);
            StatustextBox.Name = "StatustextBox";
            StatustextBox.Size = new Size(318, 45);
            StatustextBox.TabIndex = 10;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(114, 821);
            CreateBtn.Margin = new Padding(5, 5, 5, 5);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(190, 68);
            CreateBtn.TabIndex = 11;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(486, 824);
            ClearBtn.Margin = new Padding(5, 5, 5, 5);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(178, 61);
            ClearBtn.TabIndex = 15;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // SKUlabel
            // 
            SKUlabel.AutoSize = true;
            SKUlabel.Location = new Point(65, 150);
            SKUlabel.Margin = new Padding(5, 0, 5, 0);
            SKUlabel.Name = "SKUlabel";
            SKUlabel.Size = new Size(170, 38);
            SKUlabel.TabIndex = 16;
            SKUlabel.Text = "Order SKU :";
            SKUlabel.Click += SKUlabel_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(860, 828);
            BackBtn.Margin = new Padding(5, 5, 5, 5);
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
            Datelabel.Location = new Point(78, 681);
            Datelabel.Margin = new Padding(5, 0, 5, 0);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(95, 38);
            Datelabel.TabIndex = 18;
            Datelabel.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(343, 681);
            dateTimePicker1.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(507, 45);
            dateTimePicker1.TabIndex = 20;
            // 
            // Create_New_Order
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1203, 922);
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
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
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
