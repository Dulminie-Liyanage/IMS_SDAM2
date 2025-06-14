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
    public partial class PrductManagement : Form
    {
        public PrductManagement()
        {
            InitializeComponent();
        }

        private void linkAddPdt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); //Hide main menu
            Add_Product add_Product_Form = new Add_Product(); //Pass current form
            add_Product_Form.Show();
        }

        private void linkUpdatePdt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Update_Product update_Product_Form = new Update_Product();
            update_Product_Form.Show();
        }

        private void linkDelPdt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Delete_Product delete_Product_Form = new Delete_Product();
            delete_Product_Form.Show();
        }

        private void linkSearchPdt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Search_Product search_Product_Form = new Search_Product();
            search_Product_Form.Show();
        }

        private void btnBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
        }
    }
}
