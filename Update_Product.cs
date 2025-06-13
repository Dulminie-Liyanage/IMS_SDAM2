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
            //string sku = txtsku.Text;
            //DataTable dt = Product_Controller.Search_Product(sku);

            //if (dt.Rows.Count > 0)
            //{
            //    txtName.Text = dt.Rows[0]["name"].ToString();
            //    txtQuantity.Text = dt.Rows[0]["quantity"].ToString();
            //    txtPrice.Text = dt.Rows[0]["price"].ToString();
            //    txtCategory.Text = dt.Rows[0]["category"].ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Product not found.");
            //}
        }
    }
}
