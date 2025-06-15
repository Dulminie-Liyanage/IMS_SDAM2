using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace IMS
{
    internal class Stock_Controller
    {
        static string connStr = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;";

        // Record a stock movement
        public static string RecordMovement(string sku, string productName, string quantityText, string movementType, DateTime movementDate)
        {
            if (string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(quantityText) || string.IsNullOrEmpty(movementType))
                return "Please fill all fields and select stock movement type.";

            if (!int.TryParse(quantityText, out int quantity) || quantity <= 0)
                return "Quantity must be a valid positive number.";

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
                        cmd.Parameters.AddWithValue("@movement_type", movementType);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@movement_date", movementDate);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "success"; // special code to tell form it's okay
            }
            catch (Exception ex)
            {
                return "Database error: " + ex.Message;
            }
        }

        // Load all stock movement records
        public static DataTable LoadStockMovements()
        {
            DataTable dt = new DataTable();

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
                        adapter.Fill(dt);
                    }
                }
            }
            catch
            {
                // You can also log the error here
            }

            return dt;
        }
    }
}