namespace IMS
{
    partial class Update_Supplier
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textid = new TextBox();
            txtname = new TextBox();
            textcontact = new TextBox();
            txtproduct = new TextBox();
            Updatebtn = new Button();
            clearbtn = new Button();
            backbtn = new Button();
            loadbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 26);
            label1.Name = "label1";
            label1.Size = new Size(263, 45);
            label1.TabIndex = 0;
            label1.Text = "Update Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 147);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 251);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 340);
            label4.Name = "label4";
            label4.Size = new Size(170, 32);
            label4.TabIndex = 3;
            label4.Text = "Contact Info :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 424);
            label5.Name = "label5";
            label5.Size = new Size(254, 32);
            label5.TabIndex = 4;
            label5.Text = "Linked Product SKU :";
            // 
            // textid
            // 
            textid.Location = new Point(211, 142);
            textid.Name = "textid";
            textid.Size = new Size(256, 39);
            textid.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.Location = new Point(395, 246);
            txtname.Name = "txtname";
            txtname.Size = new Size(325, 39);
            txtname.TabIndex = 6;
            // 
            // textcontact
            // 
            textcontact.Location = new Point(395, 335);
            textcontact.Name = "textcontact";
            textcontact.Size = new Size(325, 39);
            textcontact.TabIndex = 7;
            // 
            // txtproduct
            // 
            txtproduct.Location = new Point(395, 421);
            txtproduct.Name = "txtproduct";
            txtproduct.Size = new Size(325, 39);
            txtproduct.TabIndex = 8;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(685, 142);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(157, 44);
            Updatebtn.TabIndex = 9;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += button1_Click;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(175, 540);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(157, 44);
            clearbtn.TabIndex = 10;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += button2_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(518, 540);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(157, 44);
            backbtn.TabIndex = 11;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += button3_Click;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(501, 142);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(157, 44);
            loadbtn.TabIndex = 12;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += button4_Click;
            // 
            // Update_Supplier
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(861, 652);
            Controls.Add(loadbtn);
            Controls.Add(backbtn);
            Controls.Add(clearbtn);
            Controls.Add(Updatebtn);
            Controls.Add(txtproduct);
            Controls.Add(textcontact);
            Controls.Add(txtname);
            Controls.Add(textid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Update_Supplier";
            Text = "Update_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textid;
        private TextBox txtname;
        private TextBox textcontact;
        private TextBox txtproduct;
        private Button Updatebtn;
        private Button clearbtn;
        private Button backbtn;
        private Button loadbtn;
    }
}