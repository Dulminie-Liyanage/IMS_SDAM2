namespace IMS
{
    partial class low_stock
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
            skuTextBox = new TextBox();
            statusTextBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            subbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(266, 49);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 0;
            label1.Text = "Low Stock Alerts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(155, 170);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "SKU           :  ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(155, 231);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Status       :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(155, 283);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "Date         :";
            // 
            // skuTextBox
            // 
            skuTextBox.Location = new Point(299, 163);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(250, 27);
            skuTextBox.TabIndex = 4;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(299, 228);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(250, 27);
            statusTextBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(299, 283);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // subbtn
            // 
            subbtn.BackColor = SystemColors.Info;
            subbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            subbtn.Location = new Point(446, 352);
            subbtn.Name = "subbtn";
            subbtn.Size = new Size(94, 29);
            subbtn.TabIndex = 7;
            subbtn.Text = "SUBMIT";
            subbtn.UseVisualStyleBackColor = false;
            subbtn.Click += subbtn_Click;
            // 
            // low_stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(subbtn);
            Controls.Add(dateTimePicker);
            Controls.Add(statusTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "low_stock";
            Text = "low_stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox skuTextBox;
        private TextBox statusTextBox;
        private DateTimePicker dateTimePicker;
        private Button subbtn;
    }
}