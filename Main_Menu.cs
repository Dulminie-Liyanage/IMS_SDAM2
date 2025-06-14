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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void linkProductMng_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PrductManagement productManagement_Form = new PrductManagement();
            productManagement_Form.Show();//Open a new add product form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loging_form loging_Form = new loging_form();
            loging_Form.Show();
        }
    }
}
