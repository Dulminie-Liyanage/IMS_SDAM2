namespace IMS
{
    partial class Delete_Supplier
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
            ordersupplierbutton1 = new Button();
            delbtn = new Button();
            clearbtn = new Button();
            backbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Delete Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 150);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID :";
            // 
            // ordersupplierbutton1
            // 
            ordersupplierbutton1.Location = new Point(205, 146);
            ordersupplierbutton1.Margin = new Padding(2);
            ordersupplierbutton1.Name = "ordersupplierbutton1";
            ordersupplierbutton1.Size = new Size(217, 27);
            ordersupplierbutton1.TabIndex = 2;
            ordersupplierbutton1.UseVisualStyleBackColor = true;
            // 
            // delbtn
            // 
            delbtn.Location = new Point(88, 218);
            delbtn.Margin = new Padding(2);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(90, 27);
            delbtn.TabIndex = 3;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += this.delbtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(214, 218);
            clearbtn.Margin = new Padding(2);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(90, 27);
            clearbtn.TabIndex = 4;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += this.clearbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(332, 218);
            backbtn.Margin = new Padding(2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(90, 27);
            backbtn.TabIndex = 5;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += this.backbtn_Click;
            // 
            // Delete_Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 316);
            Controls.Add(backbtn);
            Controls.Add(clearbtn);
            Controls.Add(delbtn);
            Controls.Add(ordersupplierbutton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Delete_Supplier";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ordersupplierbutton1;
        private Button delbtn;
        private Button clearbtn;
        private Button backbtn;
    }
}