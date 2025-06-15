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
            label1.Location = new Point(203, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Update Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 157);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 213);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Contact Info :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 265);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 4;
            label5.Text = "Linked Product SKU :";
            // 
            // textid
            // 
            textid.Location = new Point(121, 89);
            textid.Margin = new Padding(2);
            textid.Name = "textid";
            textid.Size = new Size(148, 27);
            textid.TabIndex = 5;
            // 
            // txtname
            // 
            txtname.Location = new Point(226, 154);
            txtname.Margin = new Padding(2);
            txtname.Name = "txtname";
            txtname.Size = new Size(187, 27);
            txtname.TabIndex = 6;
            // 
            // textcontact
            // 
            textcontact.Location = new Point(226, 210);
            textcontact.Margin = new Padding(2);
            textcontact.Name = "textcontact";
            textcontact.Size = new Size(187, 27);
            textcontact.TabIndex = 7;
            // 
            // txtproduct
            // 
            txtproduct.Location = new Point(226, 263);
            txtproduct.Margin = new Padding(2);
            txtproduct.Name = "txtproduct";
            txtproduct.Size = new Size(187, 27);
            txtproduct.TabIndex = 8;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(391, 89);
            Updatebtn.Margin = new Padding(2);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(90, 27);
            Updatebtn.TabIndex = 9;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += button1_Click;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(100, 338);
            clearbtn.Margin = new Padding(2);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(90, 27);
            clearbtn.TabIndex = 10;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += button2_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(296, 338);
            backbtn.Margin = new Padding(2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(90, 27);
            backbtn.TabIndex = 11;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += button3_Click;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(286, 89);
            loadbtn.Margin = new Padding(2);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(90, 27);
            loadbtn.TabIndex = 12;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += button4_Click;
            // 
            // Update_Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 407);
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
            Margin = new Padding(2);
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