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
        private string userRole;

        public Main_Menu()
        {
            InitializeComponent();
        }



        //private void ApplyRoleRestrictions()
        //{
        //    if (userRole == "Admin")
        //    {
        //        // Enable all buttons
        //        linkProductMng.Enabled = true;
        //        linkSupplierMng.Enabled = true;
        //        linkOrderMng.Enabled = true;
        //        linkStockMove.Enabled = true;
        //        linkStockAlert.Enabled = true;
        //        linkReports.Enabled = true;
        //    }
        //    else if (userRole == "WarehouseStaff")
        //    {
        //        linkProductMng.Enabled = true;     // can search/view product
        //        linkSupplierMng.Enabled = false;   // no access
        //        linkOrderMng.Enabled = false;
        //        linkStockMove.Enabled = true;
        //        linkStockAlert.Enabled = true;
        //        linkReports.Enabled = false;
        //    }
        //    else if (userRole == "Supplier")
        //    {
        //        linkProductMng.Enabled = false;    // view only maybe in product form
        //        linkSupplierMng.Enabled = false;
        //        linkOrderMng.Enabled = false;
        //        linkStockMove.Enabled = false;
        //        linkStockAlert.Enabled = false;
        //        linkReports.Enabled = false;
        //    }
        //    else
        //    {
        //        linkProductMng.Enabled = false;
        //        linkSupplierMng.Enabled = false;
        //        linkOrderMng.Enabled = false;
        //        linkStockMove.Enabled = false;
        //        linkStockAlert.Enabled = false;
        //        linkReports.Enabled = false;
        //    }
        //}
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

        private void linkStockAlert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            low_stock low_Stock = new low_stock();
            low_Stock.Show();
        }

        private void linkSupplierMng_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SupplierManagement supplierManagement = new SupplierManagement();
            supplierManagement.Show();
        }

        private void linkOrderMng_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Order_Management order_Management = new Order_Management();
            order_Management.Show();
        }

        private void linkStockMove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
