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
            OrderManagementLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderManagementLabel.Location = new Point(274, 71);
            OrderManagementLabel.Margin = new Padding(5, 0, 5, 0);
            OrderManagementLabel.Name = "OrderManagementLabel";
            OrderManagementLabel.Size = new Size(402, 45);
            OrderManagementLabel.TabIndex = 0;
            OrderManagementLabel.Text = "Order Management Form";
            OrderManagementLabel.Click += OrderManagementLabel_Click;
            // 
            // CreateNewOrder
            // 
            CreateNewOrder.ActiveLinkColor = Color.Black;
            CreateNewOrder.AutoSize = true;
            CreateNewOrder.LinkColor = Color.FromArgb(64, 64, 64);
            CreateNewOrder.Location = new Point(352, 188);
            CreateNewOrder.Margin = new Padding(5, 0, 5, 0);
            CreateNewOrder.Name = "CreateNewOrder";
            CreateNewOrder.Size = new Size(251, 38);
            CreateNewOrder.TabIndex = 1;
            CreateNewOrder.TabStop = true;
            CreateNewOrder.Text = "Create New Order";
            CreateNewOrder.LinkClicked += CreateNewOrder_LinkClicked;
            // 
            // UpdateOrder
            // 
            UpdateOrder.ActiveLinkColor = Color.Black;
            UpdateOrder.AutoSize = true;
            UpdateOrder.LinkColor = Color.FromArgb(64, 64, 64);
            UpdateOrder.Location = new Point(372, 278);
            UpdateOrder.Margin = new Padding(5, 0, 5, 0);
            UpdateOrder.Name = "UpdateOrder";
            UpdateOrder.Size = new Size(195, 38);
            UpdateOrder.TabIndex = 2;
            UpdateOrder.TabStop = true;
            UpdateOrder.Text = "Update Order";
            UpdateOrder.LinkClicked += UpdateOrder_LinkClicked;
            // 
            // DeleteOrder
            // 
            DeleteOrder.ActiveLinkColor = Color.Black;
            DeleteOrder.AutoSize = true;
            DeleteOrder.LinkColor = Color.FromArgb(64, 64, 64);
            DeleteOrder.Location = new Point(372, 375);
            DeleteOrder.Margin = new Padding(5, 0, 5, 0);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(185, 38);
            DeleteOrder.TabIndex = 3;
            DeleteOrder.TabStop = true;
            DeleteOrder.Text = "Delete Order";
            DeleteOrder.LinkClicked += DeleteOrder_LinkClicked;
            // 
            // SearchOrder
            // 
            SearchOrder.ActiveLinkColor = Color.Black;
            SearchOrder.AutoSize = true;
            SearchOrder.LinkColor = Color.FromArgb(64, 64, 64);
            SearchOrder.Location = new Point(372, 470);
            SearchOrder.Margin = new Padding(5, 0, 5, 0);
            SearchOrder.Name = "SearchOrder";
            SearchOrder.Size = new Size(187, 38);
            SearchOrder.TabIndex = 4;
            SearchOrder.TabStop = true;
            SearchOrder.Text = "Search Order";
            SearchOrder.LinkClicked += SearchOrder_LinkClicked;
            // 
            // backtomainmenuBtn
            // 
            backtomainmenuBtn.Location = new Point(299, 573);
            backtomainmenuBtn.Margin = new Padding(5, 5, 5, 5);
            backtomainmenuBtn.Name = "backtomainmenuBtn";
            backtomainmenuBtn.Size = new Size(367, 68);
            backtomainmenuBtn.TabIndex = 5;
            backtomainmenuBtn.Text = "Back To Main Menu";
            backtomainmenuBtn.UseVisualStyleBackColor = true;
            backtomainmenuBtn.Click += backtomainmenuBtn_Click;
            // 
            // Order_Management
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(960, 684);
            Controls.Add(backtomainmenuBtn);
            Controls.Add(SearchOrder);
            Controls.Add(DeleteOrder);
            Controls.Add(UpdateOrder);
            Controls.Add(CreateNewOrder);
            Controls.Add(OrderManagementLabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
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