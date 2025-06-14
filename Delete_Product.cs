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
    public partial class Delete_Product : Form
    {
        public Delete_Product()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //confirm delete
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);

            //if yes
            if (confirm == DialogResult.Yes)
            {
                string result = Product_Controller.Delete_Product(txtsuk.Text);

                MessageBox.Show(result);

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
