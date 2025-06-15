using IMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Movement
{
    public partial class Stock_Movement : Form
    {
        public Stock_Movement()
        {
            InitializeComponent();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Stock_Controller.LoadStockMovements();
        }

        private StockManagement_Load(object sender, EventArgs e)
        {
            cmbMovementType.Items.Clear(); // optional: reset
            cmbMovementType.Items.Add("IN");
            cmbMovementType.Items.Add("OUT");
            cmbMovementType.SelectedIndex = 0; // default selection
        }

        private void btnRecordMovement_Click(object sender, EventArgs e)
        {
            string result = Stock_Controller.RecordMovement(
                skutextBox.Text.Trim(),
                producttextBox.Text.Trim(),
                QuantitytextBox.Text.Trim(),
                cmbMovementType.SelectedItem?.ToString(),
                dateTimePicker1.Value
            );

            if (result == "success")
            {
                MessageBox.Show("Stock movement recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = Stock_Controller.LoadStockMovements();
                ClearFields();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            skutextBox.Clear();
            producttextBox.Clear();
            QuantitytextBox.Clear();
            cmbMovementType.SelectedIndex = 0;
        }
    }
}