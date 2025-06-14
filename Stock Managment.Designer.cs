namespace IMS
{
    partial class Stock_Managment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       //// protected override void Dispose(bool disposing)
       //// {
       //     //if (disposing && (components != null))
       //     {
       //         //components.Dispose();
       //     }
       //     base.Dispose(disposing);
//}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datetimepicker = new DateTimePicker();
            datagridview1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            outbtn = new Button();
            inbtn = new Button();
            Recordmovementbtn = new Button();
            clearbtn = new Button();
            smanagment = new Label();
            quantityp = new Label();
            label4 = new Label();
            productn = new Label();
            skup = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridview1).BeginInit();
            //SuspendLayout();
            // 
            // datetimepicker
            // 
            datetimepicker.Location = new Point(42, 250);
            datetimepicker.Name = "datetimepicker";
            datetimepicker.Size = new Size(250, 27);
            datetimepicker.TabIndex = 1;
            // 
            // datagridview1
            // 
            datagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            datagridview1.Location = new Point(42, 301);
            datagridview1.Name = "datagridview1";
            datagridview1.RowHeadersWidth = 51;
            datagridview1.Size = new Size(417, 79);
            datagridview1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "SKU";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(160, 95);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(160, 53);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 10;
            // 
            // outbtn
            // 
            outbtn.Location = new Point(286, 135);
            outbtn.Name = "outbtn";
            outbtn.Size = new Size(94, 29);
            outbtn.TabIndex = 12;
            outbtn.Text = "OUT";
            outbtn.UseVisualStyleBackColor = true;
            // 
            // inbtn
            // 
            inbtn.Location = new Point(174, 135);
            inbtn.Name = "inbtn";
            inbtn.Size = new Size(94, 27);
            inbtn.TabIndex = 14;
            inbtn.Text = "IN";
            inbtn.UseVisualStyleBackColor = true;
            // 
            // Recordmovementbtn
            // 
            Recordmovementbtn.Location = new Point(501, 395);
            Recordmovementbtn.Name = "Recordmovementbtn";
            Recordmovementbtn.Size = new Size(149, 29);
            Recordmovementbtn.TabIndex = 15;
            Recordmovementbtn.Text = "Record Movement ";
            Recordmovementbtn.UseVisualStyleBackColor = true;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(656, 395);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(94, 29);
            clearbtn.TabIndex = 16;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            // 
            // smanagment
            // 
            smanagment.AutoSize = true;
            smanagment.Location = new Point(12, 9);
            smanagment.Name = "smanagment";
            smanagment.Size = new Size(129, 20);
            smanagment.TabIndex = 18;
            smanagment.Text = "Stock Managment";
            // 
            // quantityp
            // 
            quantityp.AutoSize = true;
            quantityp.Location = new Point(31, 173);
            quantityp.Name = "quantityp";
            quantityp.Size = new Size(65, 20);
            quantityp.TabIndex = 19;
            quantityp.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 138);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 20;
            label4.Text = "Stock Movements";
            // 
            // productn
            // 
            productn.AutoSize = true;
            productn.Location = new Point(31, 98);
            productn.Name = "productn";
            productn.Size = new Size(104, 20);
            productn.TabIndex = 21;
            productn.Text = "Product Name";
            // 
            // skup
            // 
            skup.AutoSize = true;
            skup.Location = new Point(31, 60);
            skup.Name = "skup";
            skup.Size = new Size(36, 20);
            skup.TabIndex = 22;
            skup.Text = "SKU";
            //skup.Click += label6_Click;
            // 
            // Stock_Managment
            // 
           //
        }

        #endregion

        private DateTimePicker datetimepicker;
        private DataGridView datagridview1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button outbtn;
        private Button inbtn;
        private Button Recordmovementbtn;
        private Button clearbtn;
        private Label smanagment;
        private Label quantityp;
        private Label label4;
        private Label productn;
        private Label skup;
    }
}