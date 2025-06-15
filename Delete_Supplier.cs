using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMS
{
    public partial class Delete_Supplier : Form
    {
        public Delete_Supplier()
        {
            InitializeComponent();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            idtxt.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            SupplierManagement supplierManagement = new SupplierManagement();
            supplierManagement.Show();
            this.Close();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Supplier_Controller.DeleteSupplier(idtxt.Text));
            idtxt.Text = "";
        }
    }
}
