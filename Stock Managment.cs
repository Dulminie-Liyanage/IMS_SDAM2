using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace IMS
{
    public partial class StockManagement : Form
    {
        string stockMovementType = ""; // IN or OUT
        string connStr = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;";

        public StockManagement()
        {
            //InitializeComponent();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            stockMovementType = "IN";
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            stockMovementType = "OUT";
        }

        private void btnRecordMovement_Click(object sender, EventArgs e)
        {
            string sku = productsku.Text.Trim();
            string productName = productn.Text.Trim();
            string quantityText = txtQuantity.Text.Trim();
            DateTime movementDate = dateTimePicker1.Value;

            // Validation
            if (string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(quantityText) || string.IsNullOrEmpty(stockMovementType))
            {
                MessageBox.Show("Please fill all fields and select stock movement type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantityText, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO stock_movements 
                        (sku, product_name, movement_type, quantity, movement_date)
                        VALUES (@sku, @product_name, @movement_type, @quantity, @movement_date)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@sku", sku);
                        cmd.Parameters.AddWithValue("@product_name", productName);
                        cmd.Parameters.AddWithValue("@movement_type", stockMovementType);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@movement_date", movementDate);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Stock movement recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while recording movement:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"SELECT sku AS 'SKU', product_name AS 'Product Name', movement_type AS 'Type',
                                     quantity AS 'Quantity', movement_date AS 'Date'
                                     FROM stock_movements ORDER BY id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        datagridvi.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtSKU.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            stockMovementType = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // StockManagement
            // 
            ClientSize = new Size(632, 330);
            Name = "StockManagement";
            ResumeLayout(false);

        }
    }
}
