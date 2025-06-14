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
    public partial class low_stock : Form
    {
        public low_stock()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void subbtn_Click(object sender, EventArgs e)
        {
            // Get data from textboxes and DateTimePicker
            string sku = skuTextBox.Text;
            string status = statusTextBox.Text;
            DateTime selectedDate = dateTimePicker.Value;

            // Here you can add functionality to store or process the data, such as saving to a database
            MessageBox.Show($"SKU: {sku}\nStatus: {status}\nDate: {selectedDate.ToShortDateString()}",
                "Low Stock Alert Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, clear the fields after submission
            skuTextBox.Clear();
            statusTextBox.Clear();
            dateTimePicker.Value = DateTime.Now; // Reset the date picker to the current date
        }
    }
}
