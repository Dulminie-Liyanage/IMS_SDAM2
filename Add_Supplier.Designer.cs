namespace IMS
{
    partial class Add_Supplier
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
            label1.Location = new Point(530, 78);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "Add Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 204);
            label2.Name = "label2";
            label2.Size = new Size(180, 38);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 301);
            label3.Name = "label3";
            label3.Size = new Size(111, 38);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 407);
            label4.Name = "label4";
            label4.Size = new Size(196, 38);
            label4.TabIndex = 3;
            label4.Text = "Contact Info :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 523);
            label5.Name = "label5";
            label5.Size = new Size(297, 38);
            label5.TabIndex = 4;
            label5.Text = "Linked Products SKU:";
            // 
            // Add
            // 
            Add.Location = new Point(167, 716);
            Add.Name = "Add";
            Add.Size = new Size(190, 52);
            Add.TabIndex = 9;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // button6
            // 
            button6.Location = new Point(442, 716);
            button6.Name = "button6";
            button6.Size = new Size(190, 52);
            button6.TabIndex = 10;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(835, 716);
            button7.Name = "button7";
            button7.Size = new Size(190, 52);
            button7.TabIndex = 11;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(592, 199);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(361, 45);
            idtextBox.TabIndex = 12;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(592, 295);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(361, 45);
            nametextBox.TabIndex = 13;
            nametextBox.TextChanged += nametextBox2_TextChanged;
            // 
            // contacttextBox
            // 
            contacttextBox.Location = new Point(592, 401);
            contacttextBox.Name = "contacttextBox";
            contacttextBox.Size = new Size(361, 45);
            contacttextBox.TabIndex = 14;
            // 
            // linkedproductstextBox
            // 
            linkedproductstextBox.Location = new Point(592, 518);
            linkedproductstextBox.Name = "linkedproductstextBox";
            linkedproductstextBox.Size = new Size(361, 45);
            linkedproductstextBox.TabIndex = 15;
            // 
            // Add_Supplier
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1275, 887);
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
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Add_Supplier";
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