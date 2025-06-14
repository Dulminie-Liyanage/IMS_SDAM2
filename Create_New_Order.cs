namespace IMS
{
    public partial class Create_New_Order : Form
    {
        public Create_New_Order()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OrderID_Click(object sender, EventArgs e)
        {

        }

        private void SKUlabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OrderController.CreateNewOrder(OrderIDtextBox.Text, ProductNametextBox.Text, SuppliertextBox.Text, QuantitytextBox.Text, StatustextBox.Text, dateTimePicker1.Text));
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Order_Management order_Management = new Order_Management();
            order_Management.Show();
            this.Close(); //Close the Create New Product Form
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OrderIDtextBox.Text = "";
            ProductNametextBox.Text = "";
            SuppliertextBox.Text = "";
            QuantitytextBox.Text = "";
            StatustextBox.Text = "";
        }

        private void OrderIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
