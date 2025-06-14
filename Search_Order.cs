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
    public partial class Search_Order : Form
    {
        public Search_Order()
        {
            InitializeComponent();
        }

        private void SearchOrder_Click(object sender, EventArgs e)
        {

        }

        private void Search_Order_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Order_Management order_Management = new Order_Management();
            order_Management.Show();
            this.Close(); //Close the Search Order Form
        }
    }
}
