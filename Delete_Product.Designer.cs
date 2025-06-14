namespace IMS
{
    partial class Delete_Product
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
            txtsuk = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtsuk
            // 
            txtsuk.Location = new Point(162, 85);
            txtsuk.Name = "txtsuk";
            txtsuk.Size = new Size(170, 27);
            txtsuk.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 92);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 34;
            label2.Text = "Product SUK : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 33);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 33;
            label1.Text = "Delete Product";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(238, 142);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(48, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Delete_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 205);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(txtsuk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Delete_Product";
            Text = "Delete_Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsuk;
        private Label label2;
        private Label label1;
        private Button btnBack;
        private Button btnDelete;
    }
}