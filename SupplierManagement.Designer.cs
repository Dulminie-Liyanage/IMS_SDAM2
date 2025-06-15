namespace IMS
{
    partial class SupplierManagement
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
            updatelink = new LinkLabel();
            deletelink = new LinkLabel();
            searchlink = new LinkLabel();
            button1 = new Button();
            addsupplierlink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 59);
            label1.Name = "label1";
            label1.Size = new Size(386, 38);
            label1.TabIndex = 0;
            label1.Text = "Supplier Management Form";
            // 
            // updatelink
            // 
            updatelink.ActiveLinkColor = SystemColors.ActiveCaptionText;
            updatelink.AutoSize = true;
            updatelink.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatelink.LinkColor = Color.FromArgb(64, 64, 64);
            updatelink.Location = new Point(162, 281);
            updatelink.Name = "updatelink";
            updatelink.Size = new Size(182, 30);
            updatelink.TabIndex = 2;
            updatelink.TabStop = true;
            updatelink.Text = "Update Supplier";
            updatelink.LinkClicked += updatelink_LinkClicked;
            // 
            // deletelink
            // 
            deletelink.ActiveLinkColor = Color.Black;
            deletelink.AutoSize = true;
            deletelink.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletelink.LinkColor = Color.FromArgb(64, 64, 64);
            deletelink.Location = new Point(162, 377);
            deletelink.Name = "deletelink";
            deletelink.Size = new Size(172, 30);
            deletelink.TabIndex = 3;
            deletelink.TabStop = true;
            deletelink.Text = "Delete Supplier";
            deletelink.LinkClicked += deletelink_LinkClicked;
            // 
            // searchlink
            // 
            searchlink.ActiveLinkColor = Color.Black;
            searchlink.AutoSize = true;
            searchlink.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchlink.LinkColor = Color.FromArgb(64, 64, 64);
            searchlink.Location = new Point(162, 475);
            searchlink.Name = "searchlink";
            searchlink.Size = new Size(174, 30);
            searchlink.TabIndex = 4;
            searchlink.TabStop = true;
            searchlink.Text = "Search Supplier";
            searchlink.LinkClicked += searchlink_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(78, 566);
            button1.Name = "button1";
            button1.Size = new Size(332, 52);
            button1.TabIndex = 5;
            button1.Text = "Back to Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addsupplierlink
            // 
            addsupplierlink.ActiveLinkColor = Color.Black;
            addsupplierlink.AutoSize = true;
            addsupplierlink.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addsupplierlink.LinkColor = Color.FromArgb(64, 64, 64);
            addsupplierlink.Location = new Point(171, 186);
            addsupplierlink.Name = "addsupplierlink";
            addsupplierlink.Size = new Size(148, 30);
            addsupplierlink.TabIndex = 6;
            addsupplierlink.TabStop = true;
            addsupplierlink.Text = "Add Supplier";
            addsupplierlink.LinkClicked += addsupplierlink_LinkClicked;
            // 
            // SupplierManagement
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(532, 682);
            Controls.Add(addsupplierlink);
            Controls.Add(button1);
            Controls.Add(searchlink);
            Controls.Add(deletelink);
            Controls.Add(updatelink);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "SupplierManagement";
            Text = "SupplierManagementForm1";
            Load += SupplierManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkaddsupplier;
        private LinkLabel updatelink;
        private LinkLabel deletelink;
        private LinkLabel searchlink;
        private Button button1;
        private LinkLabel addsupplierlink;
    }
}