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
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string result = Supplier_Controller.AddSupplier(
                idtextBox.Text,
                nametextBox.Text,
                contacttextBox.Text,
                linkedproductstextBox.Text
    );
            MessageBox.Show(result);
        }

        private void nametextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            idtextBox.Text = "";
            nametextBox.Text = "";
            contacttextBox.Text = "";
            linkedproductstextBox.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SupplierManagement supplierManagement = new SupplierManagement();
            supplierManagement.Show();
            this.Close();

        }
    }
}
