namespace IMS
{
    partial class Add_Product
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
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            txtsku = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnBack = new Button();
            txtPrice = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(366, 245);
            txtName.Margin = new Padding(7, 6, 7, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(358, 45);
            txtName.TabIndex = 22;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(366, 331);
            txtQuantity.Margin = new Padding(7, 6, 7, 6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(358, 45);
            txtQuantity.TabIndex = 21;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(366, 518);
            txtCategory.Margin = new Padding(7, 6, 7, 6);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(358, 45);
            txtCategory.TabIndex = 19;
            // 
            // txtsku
            // 
            txtsku.Location = new Point(366, 166);
            txtsku.Margin = new Padding(7, 6, 7, 6);
            txtsku.Name = "txtsku";
            txtsku.Size = new Size(358, 45);
            txtsku.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(122, 518);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 30);
            label6.TabIndex = 17;
            label6.Text = "Category :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 331);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 15;
            label4.Text = "Quantity :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 251);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 14;
            label3.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 179);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 13;
            label2.Text = "SKU : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 74);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 38);
            label1.TabIndex = 12;
            label1.Text = "Add Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 312);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 38);
            label7.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(122, 632);
            btnAdd.Margin = new Padding(7, 6, 7, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 55);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(343, 632);
            btnClear.Margin = new Padding(7, 6, 7, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 55);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(591, 632);
            btnBack.Margin = new Padding(7, 6, 7, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 55);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(366, 426);
            txtPrice.Margin = new Padding(7, 6, 7, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(358, 45);
            txtPrice.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(122, 426);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 27;
            label5.Text = "Price :";
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(873, 746);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(txtQuantity);
            Controls.Add(txtCategory);
            Controls.Add(txtsku);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Add_Product";
            Text = "Add_Product";
            Load += Add_Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private TextBox txtsku;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button btnAdd;
        private Button btnClear;
        private Button btnBack;
        private TextBox txtPrice;
        private Label label5;
    }
}