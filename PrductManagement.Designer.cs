namespace IMS
{
    partial class PrductManagement
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
            label1 = new Label();
            linkAddPdt = new LinkLabel();
            linkUpdatePdt = new LinkLabel();
            linkDelPdt = new LinkLabel();
            linkSearchPdt = new LinkLabel();
            btnBacktoMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 47);
            label1.Name = "label1";
            label1.Size = new Size(271, 28);
            label1.TabIndex = 1;
            label1.Text = "Product Management Form";
            // 
            // linkAddPdt
            // 
            linkAddPdt.AutoSize = true;
            linkAddPdt.Location = new Point(129, 107);
            linkAddPdt.Name = "linkAddPdt";
            linkAddPdt.Size = new Size(92, 20);
            linkAddPdt.TabIndex = 2;
            linkAddPdt.TabStop = true;
            linkAddPdt.Text = "Add Product";
            linkAddPdt.TextAlign = ContentAlignment.MiddleCenter;
            linkAddPdt.LinkClicked += linkAddPdt_LinkClicked;
            // 
            // linkUpdatePdt
            // 
            linkUpdatePdt.AutoSize = true;
            linkUpdatePdt.Location = new Point(123, 148);
            linkUpdatePdt.Name = "linkUpdatePdt";
            linkUpdatePdt.Size = new Size(113, 20);
            linkUpdatePdt.TabIndex = 3;
            linkUpdatePdt.TabStop = true;
            linkUpdatePdt.Text = "Update Product";
            linkUpdatePdt.TextAlign = ContentAlignment.MiddleCenter;
            linkUpdatePdt.LinkClicked += linkUpdatePdt_LinkClicked;
            // 
            // linkDelPdt
            // 
            linkDelPdt.AutoSize = true;
            linkDelPdt.Location = new Point(123, 195);
            linkDelPdt.Name = "linkDelPdt";
            linkDelPdt.Size = new Size(108, 20);
            linkDelPdt.TabIndex = 4;
            linkDelPdt.TabStop = true;
            linkDelPdt.Text = "Delete Product";
            linkDelPdt.TextAlign = ContentAlignment.MiddleCenter;
            linkDelPdt.LinkClicked += linkDelPdt_LinkClicked;
            // 
            // linkSearchPdt
            // 
            linkSearchPdt.AutoSize = true;
            linkSearchPdt.Location = new Point(123, 237);
            linkSearchPdt.Name = "linkSearchPdt";
            linkSearchPdt.Size = new Size(108, 20);
            linkSearchPdt.TabIndex = 5;
            linkSearchPdt.TabStop = true;
            linkSearchPdt.Text = "Search Product";
            linkSearchPdt.TextAlign = ContentAlignment.MiddleCenter;
            linkSearchPdt.LinkClicked += linkSearchPdt_LinkClicked;
            // 
            // btnBacktoMenu
            // 
            btnBacktoMenu.Location = new Point(94, 279);
            btnBacktoMenu.Name = "btnBacktoMenu";
            btnBacktoMenu.Size = new Size(169, 29);
            btnBacktoMenu.TabIndex = 6;
            btnBacktoMenu.Text = "Back to Main Menu ";
            btnBacktoMenu.UseVisualStyleBackColor = true;
            btnBacktoMenu.Click += btnBacktoMenu_Click;
            // 
            // PrductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 329);
            Controls.Add(btnBacktoMenu);
            Controls.Add(linkSearchPdt);
            Controls.Add(linkDelPdt);
            Controls.Add(linkUpdatePdt);
            Controls.Add(linkAddPdt);
            Controls.Add(label1);
            Name = "PrductManagement";
            Text = "PrductManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private LinkLabel linkAddPdt;
        private LinkLabel linkUpdatePdt;
        private LinkLabel linkDelPdt;
        private LinkLabel linkSearchPdt;
        private Button btnBacktoMenu;
    }
}