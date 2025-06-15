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
    public partial class low_stock : Form
    {
        public low_stock()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LowStockForm_Load(object sender, EventArgs e)
        {
            numLimit.Value = 5; // Default value
            btnCheck.PerformClick(); // Automatically load data
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            int limit = (int)numLimit.Value;

            DataTable result = Product_Controller.GetLowStockProducts(limit);

            if (result.Rows.Count > 0)
            {
                dgvStock.DataSource = result;
                dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("All products are in stock.");
                dgvStock.DataSource = null;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Close(); 
        }
    }
}
