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
            btnUpdate = new Button();
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
            btnBack.Location = new Point(331, 379);
            btnBack.Margin = new Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 36);
            btnBack.TabIndex = 39;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(396, 86);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 36);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 195);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Location = new Point(224, 151);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 31);
            txtName.TabIndex = 35;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(224, 208);
            txtQuantity.Margin = new Padding(4, 4, 4, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(212, 31);
            txtQuantity.TabIndex = 34;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(224, 302);
            txtCategory.Margin = new Padding(4, 4, 4, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(212, 31);
            txtCategory.TabIndex = 33;
            // 
            // txtsku
            // 
            txtsku.Location = new Point(81, 90);
            txtsku.Margin = new Padding(4, 4, 4, 4);
            txtsku.Name = "txtsku";
            txtsku.Size = new Size(160, 31);
            txtsku.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 302);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 31;
            label6.Text = "Category :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 30;
            label4.Text = "Quantity :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 29;
            label3.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 28;
            label2.Text = "SKU : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 27;
            label1.Text = "Update Product";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(224, 251);
            txtPrice.Margin = new Padding(4, 4, 4, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(212, 31);
            txtPrice.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 251);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 40;
            label5.Text = "Price :";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(188, 379);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 36);
            btnClear.TabIndex = 38;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(280, 89);
            btnLoad.Margin = new Padding(4, 4, 4, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(92, 36);
            btnLoad.TabIndex = 42;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Update_Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 448);
            Controls.Add(btnLoad);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "Update_Product";
            Text = "Update_Product";
            Load += Update_Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnUpdate;
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