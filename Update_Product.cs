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
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sku = txtsku.Text.Trim();

            if (sku == "")
            {
                MessageBox.Show("Please enter a SKU to load.");
                return;
            }
            DataTable result = Product_Controller.SearchProduct(sku);

            if (result.Rows.Count > 0)
            {
                txtName.Text = result.Rows[0]["name"].ToString();
                txtQuantity.Text = result.Rows[0]["quantity"].ToString();
                txtPrice.Text = result.Rows[0]["price"].ToString();
                txtCategory.Text = result.Rows[0]["category"].ToString();
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string result = Product_Controller.Update_Product(
                txtsku.Text,
                txtName.Text,
                txtQuantity.Text,
                txtPrice.Text,
                txtCategory.Text
                );
            MessageBox.Show(result);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrductManagement prductManagement = new PrductManagement();
            prductManagement.Show();
            this.Close(); //Close the add product form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsku.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtCategory.Text = "";
        }
    }
}
