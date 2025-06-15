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
            OrderManagementLabel.Location = new Point(186, 45);
            OrderManagementLabel.Name = "OrderManagementLabel";
            OrderManagementLabel.Size = new Size(215, 25);
            OrderManagementLabel.TabIndex = 0;
            OrderManagementLabel.Text = "Order Management Form";
            // 
            // CreateNewOrder
            // 
            CreateNewOrder.AutoSize = true;
            CreateNewOrder.Location = new Point(207, 124);
            CreateNewOrder.Name = "CreateNewOrder";
            CreateNewOrder.Size = new Size(153, 25);
            CreateNewOrder.TabIndex = 1;
            CreateNewOrder.TabStop = true;
            CreateNewOrder.Text = "Create New Order";
            CreateNewOrder.LinkClicked += CreateNewOrder_LinkClicked;
            // 
            // UpdateOrder
            // 
            UpdateOrder.AutoSize = true;
            UpdateOrder.Location = new Point(219, 183);
            UpdateOrder.Name = "UpdateOrder";
            UpdateOrder.Size = new Size(121, 25);
            UpdateOrder.TabIndex = 2;
            UpdateOrder.TabStop = true;
            UpdateOrder.Text = "Update Order";
            UpdateOrder.LinkClicked += UpdateOrder_LinkClicked;
            // 
            // DeleteOrder
            // 
            DeleteOrder.AutoSize = true;
            DeleteOrder.Location = new Point(219, 247);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(113, 25);
            DeleteOrder.TabIndex = 3;
            DeleteOrder.TabStop = true;
            DeleteOrder.Text = "Delete Order";
            DeleteOrder.LinkClicked += DeleteOrder_LinkClicked;
            // 
            // SearchOrder
            // 
            SearchOrder.AutoSize = true;
            SearchOrder.Location = new Point(219, 309);
            SearchOrder.Name = "SearchOrder";
            SearchOrder.Size = new Size(115, 25);
            SearchOrder.TabIndex = 4;
            SearchOrder.TabStop = true;
            SearchOrder.Text = "Search Order";
            SearchOrder.LinkClicked += SearchOrder_LinkClicked;
            // 
            // backtomainmenuBtn
            // 
            backtomainmenuBtn.Location = new Point(176, 377);
            backtomainmenuBtn.Name = "backtomainmenuBtn";
            backtomainmenuBtn.Size = new Size(216, 45);
            backtomainmenuBtn.TabIndex = 5;
            backtomainmenuBtn.Text = "Back To Main Menu";
            backtomainmenuBtn.UseVisualStyleBackColor = true;
            backtomainmenuBtn.Click += backtomainmenuBtn_Click;
            // 
            // Order_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(backtomainmenuBtn);
            Controls.Add(SearchOrder);
            Controls.Add(DeleteOrder);
            Controls.Add(UpdateOrder);
            Controls.Add(CreateNewOrder);
            Controls.Add(OrderManagementLabel);
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