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
    public partial class Order_Management : Form
    {
        public Order_Management()
        {
            InitializeComponent();
        }

        private void CreateNewOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Create_New_Order create_New_Order = new Create_New_Order();
            create_New_Order.Show();
        }

        private void UpdateOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Update_Order update_Order = new Update_Order();
            update_Order.Show();
        }

        private void DeleteOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Detele_Order delete_Order = new Detele_Order();
            delete_Order.Show();
        }

        private void SearchOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Search_Order search_Order = new Search_Order();
            search_Order.Show();
        }

        private void backtomainmenuBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Main_Menu main_Menu = new Main_Menu();
            //main_Menu.Show();
        }

        private void Order_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
