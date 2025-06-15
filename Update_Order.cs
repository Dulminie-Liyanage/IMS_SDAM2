using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Update_Order : Form
    {
        public Update_Order()
        {
            InitializeComponent();
        }

        private void SKU_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OrderController.UpdateOrder(OrderIDTextbox.Text, ProductNametextBox.Text, SuppliertextBox.Text, QuantitytextBox.Text, StatustextBox.Text, dateTimePicker.Text));
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OrderIDTextbox.Text = "";
            ProductNametextBox.Text = "";
            SuppliertextBox.Text = "";
            QuantitytextBox.Text = "";
            StatustextBox.Text = "";

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Order_Management order_Management = new Order_Management();
            order_Management.Show();
            this.Close(); //Close the Update Order Form
        }

        private void Update_Order_Load(object sender, EventArgs e)
        {

        }
    }
}
