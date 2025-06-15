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
            UpdateOrderLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateOrderLabel.Location = new Point(370, 20);
            UpdateOrderLabel.Margin = new Padding(4, 0, 4, 0);
            UpdateOrderLabel.Name = "UpdateOrderLabel";
            UpdateOrderLabel.Size = new Size(225, 45);
            UpdateOrderLabel.TabIndex = 0;
            UpdateOrderLabel.Text = "Update Order";
            // 
            // SKU
            // 
            SKU.AutoSize = true;
            SKU.Location = new Point(48, 146);
            SKU.Margin = new Padding(4, 0, 4, 0);
            SKU.Name = "SKU";
            SKU.Size = new Size(74, 32);
            SKU.TabIndex = 1;
            SKU.Text = "SKU :";
            SKU.Click += SKU_Click;
            // 
            // OrderIDTextbox
            // 
            OrderIDTextbox.Location = new Point(218, 138);
            OrderIDTextbox.Margin = new Padding(4, 4, 4, 4);
            OrderIDTextbox.Name = "OrderIDTextbox";
            OrderIDTextbox.Size = new Size(313, 39);
            OrderIDTextbox.TabIndex = 2;
            // 
            // Productlabel
            // 
            Productlabel.AutoSize = true;
            Productlabel.Location = new Point(39, 221);
            Productlabel.Margin = new Padding(4, 0, 4, 0);
            Productlabel.Name = "Productlabel";
            Productlabel.Size = new Size(119, 32);
            Productlabel.TabIndex = 3;
            Productlabel.Text = "Product :";
            // 
            // Supplier
            // 
            Supplier.AutoSize = true;
            Supplier.Location = new Point(39, 297);
            Supplier.Margin = new Padding(4, 0, 4, 0);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(123, 32);
            Supplier.TabIndex = 4;
            Supplier.Text = "Supplier :";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(39, 383);
            Quantity.Margin = new Padding(4, 0, 4, 0);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(127, 32);
            Quantity.TabIndex = 5;
            Quantity.Text = "Quantity :";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(39, 457);
            Status.Margin = new Padding(4, 0, 4, 0);
            Status.Name = "Status";
            Status.Size = new Size(97, 32);
            Status.TabIndex = 6;
            Status.Text = "Status :";
            // 
            // ProductNametextBox
            // 
            ProductNametextBox.Location = new Point(218, 214);
            ProductNametextBox.Margin = new Padding(4, 4, 4, 4);
            ProductNametextBox.Name = "ProductNametextBox";
            ProductNametextBox.Size = new Size(313, 39);
            ProductNametextBox.TabIndex = 7;
            // 
            // SuppliertextBox
            // 
            SuppliertextBox.Location = new Point(217, 289);
            SuppliertextBox.Margin = new Padding(4, 4, 4, 4);
            SuppliertextBox.Name = "SuppliertextBox";
            SuppliertextBox.Size = new Size(313, 39);
            SuppliertextBox.TabIndex = 8;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(218, 375);
            QuantitytextBox.Margin = new Padding(4, 4, 4, 4);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(315, 39);
            QuantitytextBox.TabIndex = 9;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(74, 682);
            UpdateBtn.Margin = new Padding(4, 4, 4, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(157, 44);
            UpdateBtn.TabIndex = 11;
            UpdateBtn.Text = "Update ";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(354, 682);
            ClearBtn.Margin = new Padding(4, 4, 4, 4);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(157, 44);
            ClearBtn.TabIndex = 12;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(676, 682);
            BackBtn.Margin = new Padding(4, 4, 4, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(157, 44);
            BackBtn.TabIndex = 13;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // StatustextBox
            // 
            StatustextBox.Location = new Point(216, 457);
            StatustextBox.Margin = new Padding(4, 4, 4, 4);
            StatustextBox.Name = "StatustextBox";
            StatustextBox.Size = new Size(315, 39);
            StatustextBox.TabIndex = 14;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.Location = new Point(48, 554);
            Datelabel.Margin = new Padding(4, 0, 4, 0);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(81, 32);
            Datelabel.TabIndex = 15;
            Datelabel.Text = "Date :";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(216, 554);
            dateTimePicker.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(418, 39);
            dateTimePicker.TabIndex = 16;
            // 
            // Update_Order
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(977, 782);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
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