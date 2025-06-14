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
    public partial class SupplierManagement : Form
    {
        public SupplierManagement()
        {
            InitializeComponent();
        }

        private void addsupplierlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Add_Supplier addform = new Add_Supplier();
            addform.Show();
        }


        private void deletelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Delete_Supplier delete = new Delete_Supplier();
            delete.Show();
        }

        private void searchlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Search_form search_Form = new Search_form();
            search_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
        }

        private void SupplierManagement_Load(object sender, EventArgs e)
        {

        }

        private void updatelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Update_Form update_Form = new Update_Form();
            update_Form.Show();
        }
    }

}

