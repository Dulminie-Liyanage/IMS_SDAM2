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
            lblTitle.Location = new Point(50, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(61, 333);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(248, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // linkProductMng
            // 
            linkProductMng.AutoSize = true;
            linkProductMng.Location = new Point(125, 97);
            linkProductMng.Name = "linkProductMng";
            linkProductMng.Size = new Size(152, 20);
            linkProductMng.TabIndex = 9;
            linkProductMng.TabStop = true;
            linkProductMng.Text = "Product Management";
            linkProductMng.LinkClicked += linkProductMng_LinkClicked;
            // 
            // linkSupplierMng
            // 
            linkSupplierMng.AutoSize = true;
            linkSupplierMng.Location = new Point(124, 135);
            linkSupplierMng.Name = "linkSupplierMng";
            linkSupplierMng.Size = new Size(156, 20);
            linkSupplierMng.TabIndex = 10;
            linkSupplierMng.TabStop = true;
            linkSupplierMng.Text = "Supplier Management";
            linkSupplierMng.LinkClicked += linkSupplierMng_LinkClicked;
            // 
            // linkOrderMng
            // 
            linkOrderMng.AutoSize = true;
            linkOrderMng.Location = new Point(130, 173);
            linkOrderMng.Name = "linkOrderMng";
            linkOrderMng.Size = new Size(139, 20);
            linkOrderMng.TabIndex = 11;
            linkOrderMng.TabStop = true;
            linkOrderMng.Text = "Order Management";
            linkOrderMng.LinkClicked += linkOrderMng_LinkClicked;
            // 
            // linkStockMove
            // 
            linkStockMove.AutoSize = true;
            linkStockMove.Location = new Point(131, 213);
            linkStockMove.Name = "linkStockMove";
            linkStockMove.Size = new Size(120, 20);
            linkStockMove.TabIndex = 12;
            linkStockMove.TabStop = true;
            linkStockMove.Text = "Stock Movement";
            linkStockMove.UseMnemonic = false;
            linkStockMove.LinkClicked += linkStockMove_LinkClicked;
            // 
            // linkStockAlert
            // 
            linkStockAlert.AutoEllipsis = true;
            linkStockAlert.AutoSize = true;
            linkStockAlert.Location = new Point(135, 250);
            linkStockAlert.Name = "linkStockAlert";
            linkStockAlert.Size = new Size(112, 20);
            linkStockAlert.TabIndex = 13;
            linkStockAlert.TabStop = true;
            linkStockAlert.Text = "Low Stock Alert";
            linkStockAlert.TextAlign = ContentAlignment.MiddleCenter;
            linkStockAlert.LinkClicked += linkStockAlert_LinkClicked;
            // 
            // linkReports
            // 
            linkReports.AutoSize = true;
            linkReports.Location = new Point(161, 289);
            linkReports.Name = "linkReports";
            linkReports.Size = new Size(60, 20);
            linkReports.TabIndex = 14;
            linkReports.TabStop = true;
            linkReports.Text = "Reports";
            linkReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(401, 392);
            Controls.Add(linkReports);
            Controls.Add(linkStockAlert);
            Controls.Add(linkStockMove);
            Controls.Add(linkOrderMng);
            Controls.Add(linkSupplierMng);
            Controls.Add(linkProductMng);
            Controls.Add(btnExit);
            Controls.Add(lblTitle);
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