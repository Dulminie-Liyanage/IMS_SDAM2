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
    public partial class Search_Supplier : Form
    {
        public Search_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = searchtextBox.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Please enter ID");
                return;
            }

            DataTable result = Supplier_Controller.SearchSupplier(keyword);

            if (result.Rows.Count > 0)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Supplier_Controller.SearchSupplier(searchtextBox.Text);

            }
            else
            {
                MessageBox.Show("No matching product found.");
                dataGridView1.DataSource = null;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            SupplierManagement supplierManagement = new SupplierManagement();
            supplierManagement.Show();
            this.Close();
        }
    }
}
