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
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 85);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(434, 45);
            label1.TabIndex = 1;
            label1.Text = "Product Management Form";
            // 
            // linkAddPdt
            // 
            linkAddPdt.ActiveLinkColor = Color.Black;
            linkAddPdt.AutoSize = true;
            linkAddPdt.LinkColor = Color.FromArgb(64, 64, 64);
            linkAddPdt.Location = new Point(275, 199);
            linkAddPdt.Margin = new Padding(7, 0, 7, 0);
            linkAddPdt.Name = "linkAddPdt";
            linkAddPdt.Size = new Size(182, 38);
            linkAddPdt.TabIndex = 2;
            linkAddPdt.TabStop = true;
            linkAddPdt.Text = "Add Product";
            linkAddPdt.TextAlign = ContentAlignment.MiddleCenter;
            linkAddPdt.LinkClicked += linkAddPdt_LinkClicked;
            // 
            // linkUpdatePdt
            // 
            linkUpdatePdt.ActiveLinkColor = Color.Black;
            linkUpdatePdt.AutoSize = true;
            linkUpdatePdt.LinkColor = Color.FromArgb(64, 64, 64);
            linkUpdatePdt.Location = new Point(262, 281);
            linkUpdatePdt.Margin = new Padding(7, 0, 7, 0);
            linkUpdatePdt.Name = "linkUpdatePdt";
            linkUpdatePdt.Size = new Size(223, 38);
            linkUpdatePdt.TabIndex = 3;
            linkUpdatePdt.TabStop = true;
            linkUpdatePdt.Text = "Update Product";
            linkUpdatePdt.TextAlign = ContentAlignment.MiddleCenter;
            linkUpdatePdt.LinkClicked += linkUpdatePdt_LinkClicked;
            // 
            // linkDelPdt
            // 
            linkDelPdt.ActiveLinkColor = Color.Black;
            linkDelPdt.AutoSize = true;
            linkDelPdt.LinkColor = Color.FromArgb(64, 64, 64);
            linkDelPdt.Location = new Point(262, 371);
            linkDelPdt.Margin = new Padding(7, 0, 7, 0);
            linkDelPdt.Name = "linkDelPdt";
            linkDelPdt.Size = new Size(213, 38);
            linkDelPdt.TabIndex = 4;
            linkDelPdt.TabStop = true;
            linkDelPdt.Text = "Delete Product";
            linkDelPdt.TextAlign = ContentAlignment.MiddleCenter;
            linkDelPdt.LinkClicked += linkDelPdt_LinkClicked;
            // 
            // linkSearchPdt
            // 
            linkSearchPdt.ActiveLinkColor = Color.Black;
            linkSearchPdt.AutoSize = true;
            linkSearchPdt.LinkColor = Color.FromArgb(64, 64, 64);
            linkSearchPdt.Location = new Point(262, 450);
            linkSearchPdt.Margin = new Padding(7, 0, 7, 0);
            linkSearchPdt.Name = "linkSearchPdt";
            linkSearchPdt.Size = new Size(215, 38);
            linkSearchPdt.TabIndex = 5;
            linkSearchPdt.TabStop = true;
            linkSearchPdt.Text = "Search Product";
            linkSearchPdt.TextAlign = ContentAlignment.MiddleCenter;
            linkSearchPdt.LinkClicked += linkSearchPdt_LinkClicked;
            // 
            // btnBacktoMenu
            // 
            btnBacktoMenu.Location = new Point(201, 530);
            btnBacktoMenu.Margin = new Padding(7, 6, 7, 6);
            btnBacktoMenu.Name = "btnBacktoMenu";
            btnBacktoMenu.Size = new Size(359, 55);
            btnBacktoMenu.TabIndex = 6;
            btnBacktoMenu.Text = "Back to Main Menu ";
            btnBacktoMenu.UseVisualStyleBackColor = true;
            btnBacktoMenu.Click += btnBacktoMenu_Click;
            // 
            // PrductManagement
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 625);
            Controls.Add(btnBacktoMenu);
            Controls.Add(linkSearchPdt);
            Controls.Add(linkDelPdt);
            Controls.Add(linkUpdatePdt);
            Controls.Add(linkAddPdt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
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