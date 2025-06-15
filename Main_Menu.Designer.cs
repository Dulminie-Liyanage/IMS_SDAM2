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
            linkReports = new LinkLabel();
            linkStockAlert = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(44, 53);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(99, 439);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(253, 42);
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
            linkProductMng.Font = new Font("Segoe UI", 11F);
            linkProductMng.LinkColor = Color.FromArgb(64, 64, 64);
            linkProductMng.Location = new Point(140, 138);
            linkProductMng.Margin = new Padding(4, 0, 4, 0);
            linkProductMng.Name = "linkProductMng";
            linkProductMng.Size = new Size(223, 30);
            linkProductMng.TabIndex = 9;
            linkProductMng.TabStop = true;
            linkProductMng.Text = "Product Management";
            linkProductMng.LinkClicked += linkProductMng_LinkClicked;
            // 
            // linkSupplierMng
            // 
            linkSupplierMng.ActiveLinkColor = Color.Black;
            linkSupplierMng.AutoSize = true;
            linkSupplierMng.Font = new Font("Segoe UI", 11F);
            linkSupplierMng.LinkColor = Color.FromArgb(64, 64, 64);
            linkSupplierMng.Location = new Point(139, 185);
            linkSupplierMng.Margin = new Padding(4, 0, 4, 0);
            linkSupplierMng.Name = "linkSupplierMng";
            linkSupplierMng.Size = new Size(228, 30);
            linkSupplierMng.TabIndex = 10;
            linkSupplierMng.TabStop = true;
            linkSupplierMng.Text = "Supplier Management";
            linkSupplierMng.LinkClicked += linkSupplierMng_LinkClicked;
            // 
            // linkOrderMng
            // 
            linkOrderMng.ActiveLinkColor = Color.Black;
            linkOrderMng.AutoSize = true;
            linkOrderMng.Font = new Font("Segoe UI", 11F);
            linkOrderMng.LinkColor = Color.FromArgb(64, 64, 64);
            linkOrderMng.Location = new Point(146, 232);
            linkOrderMng.Margin = new Padding(4, 0, 4, 0);
            linkOrderMng.Name = "linkOrderMng";
            linkOrderMng.Size = new Size(206, 30);
            linkOrderMng.TabIndex = 11;
            linkOrderMng.TabStop = true;
            linkOrderMng.Text = "Order Management";
            linkOrderMng.LinkClicked += linkOrderMng_LinkClicked;
            // 
            // linkStockMove
            // 
            linkStockMove.ActiveLinkColor = Color.Black;
            linkStockMove.AutoSize = true;
            linkStockMove.Font = new Font("Segoe UI", 11F);
            linkStockMove.LinkColor = Color.FromArgb(64, 64, 64);
            linkStockMove.Location = new Point(159, 282);
            linkStockMove.Margin = new Padding(4, 0, 4, 0);
            linkStockMove.Name = "linkStockMove";
            linkStockMove.Size = new Size(177, 30);
            linkStockMove.TabIndex = 12;
            linkStockMove.TabStop = true;
            linkStockMove.Text = "Stock Movement";
            linkStockMove.UseMnemonic = false;
            linkStockMove.LinkClicked += linkStockMove_LinkClicked;
            // 
            // linkReports
            // 
            linkReports.ActiveLinkColor = Color.Black;
            linkReports.AutoSize = true;
            linkReports.Font = new Font("Segoe UI", 11F);
            linkReports.LinkColor = Color.FromArgb(64, 64, 64);
            linkReports.Location = new Point(198, 378);
            linkReports.Margin = new Padding(4, 0, 4, 0);
            linkReports.Name = "linkReports";
            linkReports.Size = new Size(87, 30);
            linkReports.TabIndex = 14;
            linkReports.TabStop = true;
            linkReports.Text = "Reports";
            linkReports.TextAlign = ContentAlignment.MiddleCenter;
            linkReports.LinkClicked += linkReports_LinkClicked;
            // 
            // linkStockAlert
            // 
            linkStockAlert.ActiveLinkColor = Color.Black;
            linkStockAlert.AutoEllipsis = true;
            linkStockAlert.AutoSize = true;
            linkStockAlert.Font = new Font("Segoe UI", 11F);
            linkStockAlert.LinkColor = Color.FromArgb(64, 64, 64);
            linkStockAlert.Location = new Point(164, 329);
            linkStockAlert.Margin = new Padding(4, 0, 4, 0);
            linkStockAlert.Name = "linkStockAlert";
            linkStockAlert.Size = new Size(162, 30);
            linkStockAlert.TabIndex = 13;
            linkStockAlert.TabStop = true;
            linkStockAlert.Text = "Low Stock Alert";
            linkStockAlert.TextAlign = ContentAlignment.MiddleCenter;
            linkStockAlert.LinkClicked += linkStockAlert_LinkClicked;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(539, 542);
            Controls.Add(linkReports);
            Controls.Add(linkStockAlert);
            Controls.Add(linkStockMove);
            Controls.Add(linkOrderMng);
            Controls.Add(linkSupplierMng);
            Controls.Add(linkProductMng);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
            Margin = new Padding(4);
            Name = "Main_Menu";
            Text = "Main_Menu";
            Load += Main_Menu_Load;
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
        private LinkLabel linkReports;
        private LinkLabel linkStockAlert;
    }
}