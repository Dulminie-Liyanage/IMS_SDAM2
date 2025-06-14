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
    public partial class Search_Product : Form
    {
        public Search_Product()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtsku.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Please enter SKU or product name to search.");
                return;
            }

            DataTable result = Product_Controller.SearchProduct(keyword);

            if (result.Rows.Count > 0)
            {
                dgvSearchResults.Columns.Clear(); 
                dgvSearchResults.DataSource = null;
                dgvSearchResults.DataSource = Product_Controller.SearchProduct(txtsku.Text);

            }
            else
            {
                MessageBox.Show("No matching product found.");
                dgvSearchResults.DataSource = null;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrductManagement prductManagement = new PrductManagement();
            prductManagement.Show();
            this.Close(); //Close the add product form
        }

    }
}
