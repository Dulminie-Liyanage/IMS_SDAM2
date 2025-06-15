namespace IMS
{
    partial class Search_Supplier
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
            label2 = new Label();
            searchtextBox = new TextBox();
            searchbtn = new Button();
            backbtn = new Button();
            dataGridView1 = new DataGridView();
            SupplierID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            ContactInfo = new DataGridViewTextBoxColumn();
            LinkedProduct = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Search Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 1;
            label2.Text = "Search by Supplier ID :";
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(251, 92);
            searchtextBox.Margin = new Padding(2);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(206, 27);
            searchtextBox.TabIndex = 2;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(491, 90);
            searchbtn.Margin = new Padding(2);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(90, 27);
            searchbtn.TabIndex = 3;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += button1_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(611, 90);
            backbtn.Margin = new Padding(2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(90, 27);
            backbtn.TabIndex = 4;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SupplierID, Name, ContactInfo, LinkedProduct });
            dataGridView1.Location = new Point(33, 156);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(663, 81);
            dataGridView1.TabIndex = 5;
            // 
            // SupplierID
            // 
            SupplierID.HeaderText = "Supplier ID";
            SupplierID.MinimumWidth = 8;
            SupplierID.Name = "SupplierID";
            SupplierID.Width = 150;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // ContactInfo
            // 
            ContactInfo.HeaderText = "Contact Info";
            ContactInfo.MinimumWidth = 8;
            ContactInfo.Name = "ContactInfo";
            ContactInfo.Width = 150;
            // 
            // LinkedProduct
            // 
            LinkedProduct.HeaderText = "Linked Product";
            LinkedProduct.MinimumWidth = 8;
            LinkedProduct.Name = "LinkedProduct";
            LinkedProduct.Width = 150;
            // 
            // Search_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 272);
            Controls.Add(dataGridView1);
            Controls.Add(backbtn);
            Controls.Add(searchbtn);
            Controls.Add(searchtextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Text = "delete_form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox searchtextBox;
        private Button searchbtn;
        private Button backbtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ContactInfo;
        private DataGridViewTextBoxColumn LinkedProduct;
    }
}