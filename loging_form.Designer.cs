namespace IMS
{
    partial class loging_form
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            submitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(151, 109);
            usernameTextBox.Margin = new Padding(4, 4, 4, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(168, 31);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(151, 179);
            passwordTextBox.Margin = new Padding(4, 4, 4, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(168, 31);
            passwordTextBox.TabIndex = 1;
            // 
            // submitbtn
            // 
            submitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            submitbtn.Location = new Point(106, 262);
            submitbtn.Margin = new Padding(4, 4, 4, 4);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(118, 45);
            submitbtn.TabIndex = 2;
            submitbtn.Text = "Login";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(21, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(21, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(73, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(211, 38);
            label3.TabIndex = 5;
            label3.Text = "LOGING FORM";
            // 
            // loging_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(350, 354);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submitbtn);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Margin = new Padding(4, 4, 4, 4);
            Name = "loging_form";
            Text = "loging_form";
            Load += loging_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button submitbtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}