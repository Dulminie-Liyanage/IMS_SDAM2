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
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 59);
            label1.Name = "label1";
            label1.Size = new Size(551, 54);
            label1.TabIndex = 0;
            label1.Text = "Supplier Management Form";
            // 
            // updatelink
            // 
            updatelink.ActiveLinkColor = SystemColors.ActiveCaptionText;
            updatelink.AutoSize = true;
            updatelink.LinkColor = Color.FromArgb(64, 64, 64);
            updatelink.Location = new Point(262, 281);
            updatelink.Name = "updatelink";
            updatelink.Size = new Size(229, 38);
            updatelink.TabIndex = 2;
            updatelink.TabStop = true;
            updatelink.Text = "Update Supplier";
            updatelink.LinkClicked += updatelink_LinkClicked;
            // 
            // deletelink
            // 
            deletelink.ActiveLinkColor = Color.Black;
            deletelink.AutoSize = true;
            deletelink.LinkColor = Color.FromArgb(64, 64, 64);
            deletelink.Location = new Point(262, 380);
            deletelink.Name = "deletelink";
            deletelink.Size = new Size(219, 38);
            deletelink.TabIndex = 3;
            deletelink.TabStop = true;
            deletelink.Text = "Delete Supplier";
            deletelink.LinkClicked += deletelink_LinkClicked;
            // 
            // searchlink
            // 
            searchlink.ActiveLinkColor = Color.Black;
            searchlink.AutoSize = true;
            searchlink.LinkColor = Color.FromArgb(64, 64, 64);
            searchlink.Location = new Point(262, 480);
            searchlink.Name = "searchlink";
            searchlink.Size = new Size(221, 38);
            searchlink.TabIndex = 4;
            searchlink.TabStop = true;
            searchlink.Text = "Search Supplier";
            searchlink.LinkClicked += searchlink_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(180, 568);
            button1.Name = "button1";
            button1.Size = new Size(381, 52);
            button1.TabIndex = 5;
            button1.Text = "Back to Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addsupplierlink
            // 
            addsupplierlink.ActiveLinkColor = Color.Black;
            addsupplierlink.AutoSize = true;
            addsupplierlink.LinkColor = Color.FromArgb(64, 64, 64);
            addsupplierlink.Location = new Point(280, 185);
            addsupplierlink.Name = "addsupplierlink";
            addsupplierlink.Size = new Size(188, 38);
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
            ClientSize = new Size(756, 682);
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