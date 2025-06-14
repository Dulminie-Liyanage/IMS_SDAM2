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
            txtName.Location = new Point(172, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 27);
            txtName.TabIndex = 22;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(172, 174);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(170, 27);
            txtQuantity.TabIndex = 21;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(172, 273);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(170, 27);
            txtCategory.TabIndex = 19;
            // 
            // txtsku
            // 
            txtsku.Location = new Point(172, 87);
            txtsku.Name = "txtsku";
            txtsku.Size = new Size(170, 27);
            txtsku.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 273);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 17;
            label6.Text = "Category :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 174);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 15;
            label4.Text = "Quantity :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 132);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 14;
            label3.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 94);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 13;
            label2.Text = "SKU : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 39);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 12;
            label1.Text = "Add Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 164);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 23;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 333);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(155, 333);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(272, 333);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(172, 224);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 27);
            txtPrice.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 224);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 27;
            label5.Text = "Price :";
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 393);
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
            Name = "Add_Product";
            Text = "Add_Product";
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