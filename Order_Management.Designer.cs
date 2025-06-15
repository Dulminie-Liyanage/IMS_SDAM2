namespace IMS
{
    partial class Order_Management
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
            OrderManagementLabel = new Label();
            CreateNewOrder = new LinkLabel();
            UpdateOrder = new LinkLabel();
            DeleteOrder = new LinkLabel();
            SearchOrder = new LinkLabel();
            backtomainmenuBtn = new Button();
            SuspendLayout();
            // 
            // OrderManagementLabel
            // 
            OrderManagementLabel.AutoSize = true;
            OrderManagementLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            OrderManagementLabel.Location = new Point(67, 70);
            OrderManagementLabel.Margin = new Padding(5, 0, 5, 0);
            OrderManagementLabel.Name = "OrderManagementLabel";
            OrderManagementLabel.Size = new Size(304, 32);
            OrderManagementLabel.TabIndex = 0;
            OrderManagementLabel.Text = "Order Management Form";
            OrderManagementLabel.Click += OrderManagementLabel_Click;
            // 
            // CreateNewOrder
            // 
            CreateNewOrder.ActiveLinkColor = Color.Black;
            CreateNewOrder.AutoSize = true;
            CreateNewOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CreateNewOrder.LinkColor = Color.FromArgb(64, 64, 64);
            CreateNewOrder.Location = new Point(118, 133);
            CreateNewOrder.Margin = new Padding(5, 0, 5, 0);
            CreateNewOrder.Name = "CreateNewOrder";
            CreateNewOrder.Size = new Size(171, 25);
            CreateNewOrder.TabIndex = 1;
            CreateNewOrder.TabStop = true;
            CreateNewOrder.Text = "Create New Order";
            CreateNewOrder.LinkClicked += CreateNewOrder_LinkClicked;
            // 
            // UpdateOrder
            // 
            UpdateOrder.ActiveLinkColor = Color.Black;
            UpdateOrder.AutoSize = true;
            UpdateOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            UpdateOrder.LinkColor = Color.FromArgb(64, 64, 64);
            UpdateOrder.Location = new Point(129, 191);
            UpdateOrder.Margin = new Padding(5, 0, 5, 0);
            UpdateOrder.Name = "UpdateOrder";
            UpdateOrder.Size = new Size(134, 25);
            UpdateOrder.TabIndex = 2;
            UpdateOrder.TabStop = true;
            UpdateOrder.Text = "Update Order";
            UpdateOrder.LinkClicked += UpdateOrder_LinkClicked;
            // 
            // DeleteOrder
            // 
            DeleteOrder.ActiveLinkColor = Color.Black;
            DeleteOrder.AutoSize = true;
            DeleteOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            DeleteOrder.LinkColor = Color.FromArgb(64, 64, 64);
            DeleteOrder.Location = new Point(129, 255);
            DeleteOrder.Margin = new Padding(5, 0, 5, 0);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(125, 25);
            DeleteOrder.TabIndex = 3;
            DeleteOrder.TabStop = true;
            DeleteOrder.Text = "Delete Order";
            DeleteOrder.LinkClicked += DeleteOrder_LinkClicked;
            // 
            // SearchOrder
            // 
            SearchOrder.ActiveLinkColor = Color.Black;
            SearchOrder.AutoSize = true;
            SearchOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            SearchOrder.LinkColor = Color.FromArgb(64, 64, 64);
            SearchOrder.Location = new Point(126, 325);
            SearchOrder.Margin = new Padding(5, 0, 5, 0);
            SearchOrder.Name = "SearchOrder";
            SearchOrder.Size = new Size(128, 25);
            SearchOrder.TabIndex = 4;
            SearchOrder.TabStop = true;
            SearchOrder.Text = "Search Order";
            SearchOrder.LinkClicked += SearchOrder_LinkClicked;
            // 
            // backtomainmenuBtn
            // 
            backtomainmenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backtomainmenuBtn.Location = new Point(67, 397);
            backtomainmenuBtn.Margin = new Padding(5);
            backtomainmenuBtn.Name = "backtomainmenuBtn";
            backtomainmenuBtn.Size = new Size(270, 51);
            backtomainmenuBtn.TabIndex = 5;
            backtomainmenuBtn.Text = "Back To Main Menu";
            backtomainmenuBtn.UseVisualStyleBackColor = true;
            backtomainmenuBtn.Click += backtomainmenuBtn_Click;
            // 
            // Order_Management
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(418, 481);
            Controls.Add(backtomainmenuBtn);
            Controls.Add(SearchOrder);
            Controls.Add(DeleteOrder);
            Controls.Add(UpdateOrder);
            Controls.Add(CreateNewOrder);
            Controls.Add(OrderManagementLabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Order_Management";
            Text = "Order_Management";
            Load += Order_Management_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrderManagementLabel;
        private LinkLabel CreateNewOrder;
        private LinkLabel UpdateOrder;
        private LinkLabel DeleteOrder;
        private LinkLabel SearchOrder;
        private Button backtomainmenuBtn;
    }
}