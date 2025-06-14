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
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrductManagement prductManagement = new PrductManagement();
            prductManagement.Show();
            this.Close(); //Close the add product form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Product_Controller.AddProduct(txtsku.Text, txtName.Text, txtQuantity.Text, txtPrice.Text, txtCategory.Text));
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
