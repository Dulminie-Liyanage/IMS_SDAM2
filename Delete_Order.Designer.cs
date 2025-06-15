namespace IMS
{
    partial class Detele_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DeleteOrder = new Label();
            OrderID = new Label();
            OrderSKUtextBox = new TextBox();
            DeleteBtn = new Button();
            ClearBtn = new Button();
            BackBtn = new Button();
            DeleteOrderLabel = new Label();
            OrderSKU = new Label();
            OSKUtextBox = new TextBox();
            btnclear = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // DeleteOrder
            // 
            DeleteOrder.AutoSize = true;
            DeleteOrder.Location = new Point(283, 31);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(113, 25);
            DeleteOrder.TabIndex = 0;
            DeleteOrder.Text = "Delete Order";
            // 
            // OrderID
            // 
            OrderID.AutoSize = true;
            OrderID.Location = new Point(58, 120);
            OrderID.Name = "OrderID";
            OrderID.Size = new Size(104, 25);
            OrderID.TabIndex = 1;
            OrderID.Text = "Order SKU :";
            // 
            // OrderSKUtextBox
            // 
            OrderSKUtextBox.Location = new Point(207, 120);
            OrderSKUtextBox.Name = "OrderSKUtextBox";
            OrderSKUtextBox.Size = new Size(235, 31);
            OrderSKUtextBox.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(30, 212);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(112, 34);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(228, 212);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(112, 34);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(462, 212);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(112, 34);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteOrderLabel
            // 
            DeleteOrderLabel.AutoSize = true;
            DeleteOrderLabel.Location = new Point(246, 29);
            DeleteOrderLabel.Name = "DeleteOrderLabel";
            DeleteOrderLabel.Size = new Size(185, 38);
            DeleteOrderLabel.TabIndex = 0;
            DeleteOrderLabel.Text = "Delete Order";
            // 
            // OrderSKU
            // 
            OrderSKU.AutoSize = true;
            OrderSKU.Location = new Point(33, 104);
            OrderSKU.Name = "OrderSKU";
            OrderSKU.Size = new Size(170, 38);
            OrderSKU.TabIndex = 1;
            OrderSKU.Text = "Order SKU :";
            // 
            // OSKUtextBox
            // 
            OSKUtextBox.Location = new Point(207, 98);
            OSKUtextBox.Name = "OSKUtextBox";
            OSKUtextBox.Size = new Size(225, 45);
            OSKUtextBox.TabIndex = 2;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(232, 224);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(131, 51);
            btnclear.TabIndex = 4;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(462, 224);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 51);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(42, 224);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 51);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Detele_Order
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(661, 308);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnclear);
            Controls.Add(OSKUtextBox);
            Controls.Add(OrderSKU);
            Controls.Add(DeleteOrderLabel);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Detele_Order";
            Load += Detele_Order_Load;
            ResumeLayout(false);
            PerformLayout();
            //BackBtn.Click += BackBtn_Click;
            // 
            // Detele_Order
            // 
            //AutoScaleDimensions = new SizeF(10F, 25F);
            //AutoScaleMode = AutoScaleMode.Font;
            //ClientSize = new Size(707, 281);
            //Controls.Add(BackBtn);
            //Controls.Add(ClearBtn);
            //Controls.Add(DeleteBtn);
            //Controls.Add(OrderSKUtextBox);
            //Controls.Add(OrderID);
            //Controls.Add(DeleteOrder);
            //Name = "Detele_Order";
            //Text = "Detele_Order";
            //Load += Detele_Order_Load;
            //ResumeLayout(false);
            //PerformLayout();
        }

        #endregion

        private Label DeleteOrder;
        private Label OrderID;
        private TextBox OrderSKUtextBox;
        private Button DeleteBtn;
        private Button ClearBtn;
        private Button BackBtn;
        private Label DeleteOrderLabel;
        private Label OrderSKU;
        private TextBox OSKUtextBox;
        private Button btnclear;
        private Button btnBack;
        private Button btnDelete;
    }
}