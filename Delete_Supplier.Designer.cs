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
            delbtn = new Button();
            clearbtn = new Button();
            backbtn = new Button();
            idtxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 114);
            label1.Name = "label1";
            label1.Size = new Size(219, 38);
            label1.TabIndex = 0;
            label1.Text = "Delete Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 230);
            label2.Name = "label2";
            label2.Size = new Size(180, 38);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID :";
            // 
            // delbtn
            // 
            delbtn.Location = new Point(99, 336);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(190, 52);
            delbtn.TabIndex = 3;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += delbtn_Click;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(366, 336);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(190, 52);
            clearbtn.TabIndex = 4;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(615, 336);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(190, 52);
            backbtn.TabIndex = 5;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // idtxt
            // 
            idtxt.Location = new Point(440, 230);
            idtxt.Margin = new Padding(7, 6, 7, 6);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(325, 45);
            idtxt.TabIndex = 6;
            // 
            // Delete_Supplier
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(870, 462);
            Controls.Add(idtxt);
            Controls.Add(backbtn);
            Controls.Add(clearbtn);
            Controls.Add(delbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Delete_Supplier";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button delbtn;
        private Button clearbtn;
        private Button backbtn;
        private TextBox idtxt;
    }
}