using Microsoft.VisualBasic.Devices;
using Mysqlx.Crud;
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
    public partial class Search_Order : Form
    {
        public Search_Order()
        {
            InitializeComponent();
        }

        private void SearchOrder_Click(object sender, EventArgs e)
        {

        }

        private void Search_Order_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = SKUtextBox.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Please enter SKU or product name to search.");
                return;
            }

            DataTable result = Product_Controller.SearchProduct(keyword);

            if (result.Rows.Count > 0)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product_Controller.SearchProduct(SKUtextBox.Text);

            }
            else
            {
                MessageBox.Show("No matching product found.");
                dataGridView1.DataSource = null;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Order_Management order_Management = new Order_Management();
            order_Management.Show();
            this.Close(); //Close the Search Order Form
        }
    }
}
