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
    public partial class Detele_Order : Form
    {
        public Detele_Order()
        {
            InitializeComponent();
        }

        private void Delete_Order_Load(object sender, EventArgs e)
        {
            // Do nothing on load — wait for user input
        }

        // DELETE Button Click
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string orderId = OrderSKUtextBox.Text.Trim();

            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Please enter the Order ID to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Call the controller to delete the order
                string result = OrderController.DeleteOrder(orderId);
                MessageBox.Show(result, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrderSKUtextBox.Clear();
            }
        }

        // CLEAR Button Click
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OrderSKUtextBox.Clear();
        }

        // BACK Button Click
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Order_Management orderManagementForm = new Order_Management();
            orderManagementForm.Show();
            this.Close(); // Close the current form
        }

        private void Detele_Order_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }
    }
}

