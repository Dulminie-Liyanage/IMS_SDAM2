using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IMS
{
    public partial class Update_Supplier : Form
    {
        public Update_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = Supplier_Controller.UpdateSupplier(
                textid.Text,
                txtname.Text,
                textcontact.Text,
                txtproduct.Text           
                );
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textid.Text = "";
            txtname.Text = "";
            textcontact.Text = "";
            txtproduct.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupplierManagement supplierManagement = new SupplierManagement();
            supplierManagement.Show();
            this.Close(); //Close the add product form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = textid.Text.Trim();

            if (id == "")
            {
                MessageBox.Show("Please enter a ID to load.");
                return;
            }
            DataTable result = Supplier_Controller.SearchSupplier(id);

            if (result.Rows.Count > 0)
            {
                txtname.Text = result.Rows[0]["name"].ToString();
                textcontact.Text = result.Rows[0]["contact"].ToString();
                txtproduct.Text = ""; 
            }
            else
            {
                MessageBox.Show("Supplier not found.");
            }

        }
    }
}
