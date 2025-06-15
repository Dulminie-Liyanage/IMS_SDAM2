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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 24);
            label1.Name = "label1";
            label1.Size = new Size(229, 38);
            label1.TabIndex = 0;
            label1.Text = "Update Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 138);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 235);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 319);
            label4.Name = "label4";
            label4.Size = new Size(153, 30);
            label4.TabIndex = 3;
            label4.Text = "Contact Info :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 398);
            label5.Name = "label5";
            label5.Size = new Size(230, 30);
            label5.TabIndex = 4;
            label5.Text = "Linked Product SKU :";
            // 
            // textid
            // 
            textid.Location = new Point(196, 133);
            textid.Name = "textid";
            textid.Size = new Size(238, 37);
            textid.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.Location = new Point(367, 231);
            txtname.Name = "txtname";
            txtname.Size = new Size(302, 37);
            txtname.TabIndex = 6;
            // 
            // textcontact
            // 
            textcontact.Location = new Point(367, 314);
            textcontact.Name = "textcontact";
            textcontact.Size = new Size(302, 37);
            textcontact.TabIndex = 7;
            // 
            // txtproduct
            // 
            txtproduct.Location = new Point(367, 395);
            txtproduct.Name = "txtproduct";
            txtproduct.Size = new Size(302, 37);
            txtproduct.TabIndex = 8;
            // 
            // Updatebtn
            // 
            Updatebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.Location = new Point(636, 133);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(146, 41);
            Updatebtn.TabIndex = 9;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += button1_Click;
            // 
            // clearbtn
            // 
            clearbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearbtn.Location = new Point(162, 506);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(146, 41);
            clearbtn.TabIndex = 10;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += button2_Click;
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(481, 506);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(146, 41);
            backbtn.TabIndex = 11;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += button3_Click;
            // 
            // loadbtn
            // 
            loadbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadbtn.Location = new Point(465, 133);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(146, 41);
            loadbtn.TabIndex = 12;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += button4_Click;
            // 
            // Update_Supplier
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 611);
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
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
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