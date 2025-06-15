namespace IMS
{
    partial class Main_Menu
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
            lblTitle = new Label();
            btnExit = new Button();
            linkProductMng = new LinkLabel();
            linkSupplierMng = new LinkLabel();
            linkOrderMng = new LinkLabel();
            linkStockMove = new LinkLabel();
            linkStockAlert = new LinkLabel();
            linkReports = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(62, 51);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(371, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(76, 416);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(310, 36);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // linkProductMng
            // 
            linkProductMng.ActiveLinkColor = Color.Black;
            linkProductMng.AutoSize = true;
            linkProductMng.LinkColor = Color.FromArgb(64, 64, 64);
            linkProductMng.Location = new Point(156, 121);
            linkProductMng.Margin = new Padding(4, 0, 4, 0);
            linkProductMng.Name = "linkProductMng";
            linkProductMng.Size = new Size(184, 25);
            linkProductMng.TabIndex = 9;
            linkProductMng.TabStop = true;
            linkProductMng.Text = "Product Management";
            linkProductMng.LinkClicked += linkProductMng_LinkClicked;
            // 
            // linkSupplierMng
            // 
            linkSupplierMng.ActiveLinkColor = Color.Black;
            linkSupplierMng.AutoSize = true;
            linkSupplierMng.LinkColor = Color.FromArgb(64, 64, 64);
            linkSupplierMng.Location = new Point(155, 169);
            linkSupplierMng.Margin = new Padding(4, 0, 4, 0);
            linkSupplierMng.Name = "linkSupplierMng";
            linkSupplierMng.Size = new Size(187, 25);
            linkSupplierMng.TabIndex = 10;
            linkSupplierMng.TabStop = true;
            linkSupplierMng.Text = "Supplier Management";
            linkSupplierMng.LinkClicked += linkSupplierMng_LinkClicked;
            // 
            // linkOrderMng
            // 
            linkOrderMng.ActiveLinkColor = Color.Black;
            linkOrderMng.AutoSize = true;
            linkOrderMng.LinkColor = Color.FromArgb(64, 64, 64);
            linkOrderMng.Location = new Point(162, 216);
            linkOrderMng.Margin = new Padding(4, 0, 4, 0);
            linkOrderMng.Name = "linkOrderMng";
            linkOrderMng.Size = new Size(168, 25);
            linkOrderMng.TabIndex = 11;
            linkOrderMng.TabStop = true;
            linkOrderMng.Text = "Order Management";
            linkOrderMng.LinkClicked += linkOrderMng_LinkClicked;
            // 
            // linkStockMove
            // 
            linkStockMove.ActiveLinkColor = Color.Black;
            linkStockMove.AutoSize = true;
            linkStockMove.LinkColor = Color.FromArgb(64, 64, 64);
            linkStockMove.Location = new Point(164, 266);
            linkStockMove.Margin = new Padding(4, 0, 4, 0);
            linkStockMove.Name = "linkStockMove";
            linkStockMove.Size = new Size(146, 25);
            linkStockMove.TabIndex = 12;
            linkStockMove.TabStop = true;
            linkStockMove.Text = "Stock Movement";
            linkStockMove.UseMnemonic = false;
            linkStockMove.LinkClicked += linkStockMove_LinkClicked;
            // 
            // linkStockAlert
            // 
            linkStockAlert.ActiveLinkColor = Color.Black;
            linkStockAlert.AutoEllipsis = true;
            linkStockAlert.AutoSize = true;
            linkStockAlert.LinkColor = Color.FromArgb(64, 64, 64);
            linkStockAlert.Location = new Point(169, 312);
            linkStockAlert.Margin = new Padding(4, 0, 4, 0);
            linkStockAlert.Name = "linkStockAlert";
            linkStockAlert.Size = new Size(134, 25);
            linkStockAlert.TabIndex = 13;
            linkStockAlert.TabStop = true;
            linkStockAlert.Text = "Low Stock Alert";
            linkStockAlert.TextAlign = ContentAlignment.MiddleCenter;
            linkStockAlert.LinkClicked += linkStockAlert_LinkClicked;
            // 
            // linkReports
            // 
            linkReports.ActiveLinkColor = Color.Black;
            linkReports.AutoSize = true;
            linkReports.LinkColor = Color.FromArgb(64, 64, 64);
            linkReports.Location = new Point(201, 361);
            linkReports.Margin = new Padding(4, 0, 4, 0);
            linkReports.Name = "linkReports";
            linkReports.Size = new Size(73, 25);
            linkReports.TabIndex = 14;
            linkReports.TabStop = true;
            linkReports.Text = "Reports";
            linkReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(501, 490);
            Controls.Add(linkReports);
            Controls.Add(linkStockAlert);
            Controls.Add(linkStockMove);
            Controls.Add(linkOrderMng);
            Controls.Add(linkSupplierMng);
            Controls.Add(linkProductMng);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Main_Menu";
            Text = "Main_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Button btnExit;
        private LinkLabel linkProductMng;
        private LinkLabel linkSupplierMng;
        private LinkLabel linkOrderMng;
        private LinkLabel linkStockMove;
        private LinkLabel linkStockAlert;
        private LinkLabel linkReports;
    }
}