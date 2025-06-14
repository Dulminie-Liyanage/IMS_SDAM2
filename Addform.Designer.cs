namespace IMS
{
    partial class Addform
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
            Add = new Button();
            button6 = new Button();
            button7 = new Button();
            idtextBox = new TextBox();
            nametextBox = new TextBox();
            contacttextBox = new TextBox();
            linkedproductstextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 134);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 197);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 267);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact Info :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 344);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 4;
            label5.Text = "Linked Products :";
            // 
            // Add
            // 
            Add.Location = new Point(97, 471);
            Add.Name = "Add";
            Add.Size = new Size(112, 34);
            Add.TabIndex = 9;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // button6
            // 
            button6.Location = new Point(260, 471);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 10;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(491, 471);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 11;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(348, 131);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(214, 31);
            idtextBox.TabIndex = 12;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(348, 194);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(214, 31);
            nametextBox.TabIndex = 13;
            nametextBox.TextChanged += nametextBox2_TextChanged;
            // 
            // contacttextBox
            // 
            contacttextBox.Location = new Point(348, 264);
            contacttextBox.Name = "contacttextBox";
            contacttextBox.Size = new Size(214, 31);
            contacttextBox.TabIndex = 14;
            // 
            // linkedproductstextBox
            // 
            linkedproductstextBox.Location = new Point(348, 341);
            linkedproductstextBox.Name = "linkedproductstextBox";
            linkedproductstextBox.Size = new Size(214, 31);
            linkedproductstextBox.TabIndex = 15;
            // 
            // Addform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 588);
            Controls.Add(linkedproductstextBox);
            Controls.Add(contacttextBox);
            Controls.Add(nametextBox);
            Controls.Add(idtextBox);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(Add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addform";
            Text = "Addform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Add;
        private Button button6;
        private Button button7;
        private TextBox idtextBox;
        private TextBox nametextBox;
        private TextBox contacttextBox;
        private TextBox linkedproductstextBox;
    }
}