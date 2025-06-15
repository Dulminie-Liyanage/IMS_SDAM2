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
    public partial class dgvReports : Form
    {
        public dgvReports()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DataTable dt;

            if (rbMostOrdered.Checked)
            {
                dt = Report_Controller.GetMostOrderedProducts();
            }
            else if (rbStockLevels.Checked)
            {
                dt = Report_Controller.GetStockLevels();
            }
            else
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            if (dt.Rows.Count > 0)
            {
                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found.");
                dataGridView2.DataSource = null;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {


            Main_Menu menu = new Main_Menu();
            menu.Show();
            this.Close();
        }

        private void rbStockLevels_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}    


