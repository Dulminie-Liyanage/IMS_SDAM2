namespace IMS
{
    partial class Update_Order
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
            UpdateOrderLabel = new Label();
            SKU = new Label();
            OrderIDTextbox = new TextBox();
            Productlabel = new Label();
            Supplier = new Label();
            Quantity = new Label();
            Status = new Label();
            ProductNametextBox = new TextBox();
            SuppliertextBox = new TextBox();
            QuantitytextBox = new TextBox();
            UpdateBtn = new Button();
            ClearBtn = new Button();
            BackBtn = new Button();
            StatustextBox = new TextBox();
            Datelabel = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // UpdateOrderLabel
            // 
            UpdateOrderLabel.AutoSize = true;
            UpdateOrderLabel.Location = new Point(301, 36);
            UpdateOrderLabel.Name = "UpdateOrderLabel";
            UpdateOrderLabel.Size = new Size(121, 25);
            UpdateOrderLabel.TabIndex = 0;
            UpdateOrderLabel.Text = "Update Order";
            // 
            // SKU
            // 
            SKU.AutoSize = true;
            SKU.Location = new Point(34, 114);
            SKU.Name = "SKU";
            SKU.Size = new Size(53, 25);
            SKU.TabIndex = 1;
            SKU.Text = "SKU :";
            SKU.Click += SKU_Click;
            // 
            // OrderIDTextbox
            // 
            OrderIDTextbox.Location = new Point(156, 108);
            OrderIDTextbox.Name = "OrderIDTextbox";
            OrderIDTextbox.Size = new Size(225, 31);
            OrderIDTextbox.TabIndex = 2;
            // 
            // Productlabel
            // 
            Productlabel.AutoSize = true;
            Productlabel.Location = new Point(28, 173);
            Productlabel.Name = "Productlabel";
            Productlabel.Size = new Size(83, 25);
            Productlabel.TabIndex = 3;
            Productlabel.Text = "Product :";
            // 
            // Supplier
            // 
            Supplier.AutoSize = true;
            Supplier.Location = new Point(28, 232);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(86, 25);
            Supplier.TabIndex = 4;
            Supplier.Text = "Supplier :";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(28, 299);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(89, 25);
            Quantity.TabIndex = 5;
            Quantity.Text = "Quantity :";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(28, 357);
            Status.Name = "Status";
            Status.Size = new Size(69, 25);
            Status.TabIndex = 6;
            Status.Text = "Status :";
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Location = new Point(156, 167);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(225, 31);
            ProductNametextBox.TabIndex = 7;
            // 
            // SuppliertextBox
            // 
            SuppliertextBox.Location = new Point(155, 226);
            SuppliertextBox.Name = "SuppliertextBox";
            SuppliertextBox.Size = new Size(225, 31);
            SuppliertextBox.TabIndex = 8;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(156, 293);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(226, 31);
            QuantitytextBox.TabIndex = 9;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(53, 533);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(112, 34);
            UpdateBtn.TabIndex = 11;
            UpdateBtn.Text = "Update ";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(253, 533);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(112, 34);
            ClearBtn.TabIndex = 12;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(483, 533);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(112, 34);
            BackBtn.TabIndex = 13;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // StatustextBox
            // 
            StatustextBox.Location = new Point(154, 357);
            StatustextBox.Name = "StatustextBox";
            StatustextBox.Size = new Size(226, 31);
            StatustextBox.TabIndex = 14;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.Location = new Point(34, 433);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(58, 25);
            Datelabel.TabIndex = 15;
            Datelabel.Text = "Date :";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(154, 433);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 31);
            dateTimePicker.TabIndex = 16;
            // 
            // Update_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 611);
            Controls.Add(dateTimePicker);
            Controls.Add(Datelabel);
            Controls.Add(StatustextBox);
            Controls.Add(BackBtn);
            Controls.Add(ClearBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(QuantitytextBox);
            Controls.Add(SuppliertextBox);
            Controls.Add(ProductNametextBox);
            Controls.Add(Status);
            Controls.Add(Quantity);
            Controls.Add(Supplier);
            Controls.Add(Productlabel);
            Controls.Add(OrderIDTextbox);
            Controls.Add(SKU);
            Controls.Add(UpdateOrderLabel);
            Name = "Update_Order";
            Text = "Update_Order";
            Load += Update_Order_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateOrderLabel;
        private Label SKU;
        private TextBox OrderIDTextbox;
        private Label Productlabel;
        private Label Supplier;
        private Label Quantity;
        private Label Status;
        private TextBox ProductNametextBox;
        private TextBox SuppliertextBox;
        private TextBox QuantitytextBox;
        private TextBox SKUtextBox;
        private Button UpdateBtn;
        private Button ClearBtn;
        private Button BackBtn;
        private TextBox StatustextBox;
        private Label Datelabel;
        private DateTimePicker dateTimePicker;
    }
}