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
            txtsuk.Location = new Point(343, 161);
            txtsuk.Margin = new Padding(7, 6, 7, 6);
            txtsuk.Name = "txtsuk";
            txtsuk.Size = new Size(358, 45);
            txtsuk.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 175);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 38);
            label2.TabIndex = 34;
            label2.Text = "Product SUK : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 62);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 33;
            label1.Text = "Delete Product";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(507, 271);
            btnBack.Margin = new Padding(7, 6, 7, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 55);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(102, 271);
            btnDelete.Margin = new Padding(7, 6, 7, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 55);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Delete_Product
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(801, 389);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(txtsuk);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Delete_Product";
            Text = "Delete_Product";
            Load += Delete_Product_Load;
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