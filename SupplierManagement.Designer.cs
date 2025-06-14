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
            label1.Location = new Point(193, 47);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 0;
            label1.Text = "Supplier Management Form";
            // 
            // updatelink
            // 
            updatelink.AutoSize = true;
            updatelink.Location = new Point(241, 243);
            updatelink.Name = "updatelink";
            updatelink.Size = new Size(140, 25);
            updatelink.TabIndex = 2;
            updatelink.TabStop = true;
            updatelink.Text = "Update Supplier";
            updatelink.LinkClicked += linkLabel2_LinkClicked;
            // 
            // deletelink
            // 
            deletelink.AutoSize = true;
            deletelink.Location = new Point(241, 327);
            deletelink.Name = "deletelink";
            deletelink.Size = new Size(132, 25);
            deletelink.TabIndex = 3;
            deletelink.TabStop = true;
            deletelink.Text = "Delete Supplier";
            deletelink.LinkClicked += deletelink_LinkClicked;
            // 
            // searchlink
            // 
            searchlink.AutoSize = true;
            searchlink.Location = new Point(241, 409);
            searchlink.Name = "searchlink";
            searchlink.Size = new Size(134, 25);
            searchlink.TabIndex = 4;
            searchlink.TabStop = true;
            searchlink.Text = "Search Supplier";
            searchlink.LinkClicked += searchlink_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(203, 494);
            button1.Name = "button1";
            button1.Size = new Size(224, 34);
            button1.TabIndex = 5;
            button1.Text = "Back to Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addsupplierlink
            // 
            addsupplierlink.AutoSize = true;
            addsupplierlink.Location = new Point(241, 159);
            addsupplierlink.Name = "addsupplierlink";
            addsupplierlink.Size = new Size(116, 25);
            addsupplierlink.TabIndex = 6;
            addsupplierlink.TabStop = true;
            addsupplierlink.Text = "Add Supplier";
            addsupplierlink.LinkClicked += addsupplierlink_LinkClicked;
            // 
            // SupplierManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 634);
            Controls.Add(addsupplierlink);
            Controls.Add(button1);
            Controls.Add(searchlink);
            Controls.Add(deletelink);
            Controls.Add(updatelink);
            Controls.Add(label1);
            Name = "SupplierManagement";
            Text = "SupplierManagementForm1";
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