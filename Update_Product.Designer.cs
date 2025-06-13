namespace IMS
{
    partial class Update_Product
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
            btnAdd = new Button();
            label7 = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            txtsku = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            btnClear = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(317, 304);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 39;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(116, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Update";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 156);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 121);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 27);
            txtName.TabIndex = 35;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(179, 166);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(170, 27);
            txtQuantity.TabIndex = 34;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(179, 242);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(170, 27);
            txtCategory.TabIndex = 33;
            // 
            // txtsku
            // 
            txtsku.Location = new Point(126, 67);
            txtsku.Name = "txtsku";
            txtsku.Size = new Size(170, 27);
            txtsku.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 242);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 31;
            label6.Text = "Category :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 166);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 30;
            label4.Text = "Quantity :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 124);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 29;
            label3.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 74);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 28;
            label2.Text = "SKU : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 31);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 27;
            label1.Text = "Update Product";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(179, 201);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 27);
            txtPrice.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 201);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 40;
            label5.Text = "Price :";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(216, 304);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 29);
            btnClear.TabIndex = 38;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(36, 304);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(74, 29);
            btnLoad.TabIndex = 42;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Update_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 358);
            Controls.Add(btnLoad);
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
            Name = "Update_Product";
            Text = "Update_Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnAdd;
        private Label label7;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private TextBox txtsku;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPrice;
        private Label label5;
        private Button btnClear;
        private Button btnLoad;
    }
}