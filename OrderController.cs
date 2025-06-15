using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class OrderController
    {
        //Define the connection string to the MySQL database
        static string connStr = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;";
        static MySqlConnection conn = new MySqlConnection(connStr);

        // Create New Order
        public static string CreateNewOrder(string orderID, string product, string supplier, string quantity, string status, string date)
        {
            if (orderID == "" || product == "" ||quantity == "" || status == "" || date == "" )
                return "Please fill all fields!"; //check if all the field are filled

            // Check if quantity is a valid number
            try
            {
                int qty = Convert.ToInt32(quantity);
                if (qty <= 0)
                    return "Quantity cannot be negative!";
            }
            catch
            {
                return "Quantity must be a number!";
            }

            string insert = "INSERT INTO orders (id, product_sku, quantity, status, order_date) " +
                            "VALUES (@id, @product_sku, @quantity, @status, @orderDate)";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@id", orderID);
            cmd.Parameters.AddWithValue("@product_sku", product);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderDate", DateTime.Now);
            cmd.ExecuteNonQuery();
            conn.Close();

            return "Order placed successfully!";
        }

        // Update Order
        public static string UpdateOrder(string orderId, string product, string supplier, string quantity, string status, string date)
        {
            if (orderId == "" || product == "" || supplier == "" || quantity == "" || status == "" || date == "" )
                return "Please fill all fields!";

            try
            {
                int qty = Convert.ToInt32(quantity);
                if (qty <= 0)
                    return "Quantity cannot be negative!";
                
            }
            catch
            {
                return "Quantity must be valid number!";
            }

            try
            {
                int id = Convert.ToInt32(orderId);
                if (id <= 0)
                    return "Order ID must be a positive number!";
            }

            catch
            {
                return "Order ID must be a valid number!";
            }

            string update = "UPDATE orders SET orderId=@orderId, product=@product, quantity=@quantity, status=@status, date=@orderdate WHERE order_id=@orderId";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@product", product);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderdate", date);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
                return "Order updated!";
            else
                return "Order ID not found!";
        }

        // Delete Order
        public static string DeleteOrder(string orderId)
        {
            //check if sku is empty
            if (orderId == "")
                return "Please enter Order ID to delete.";

            string delete = "DELETE FROM orders WHERE order_id=@orderId";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(delete, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                return "Order deleted!";
            }
            else
            {
                return "Order ID not found!";
            }
        }

        // Load Orders to View
        public static DataTable LoadOrders()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM orders";

            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        // Search Order by ID
        public static DataTable SearchOrder(string keyword)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM orders WHERE order_id = @orderId";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            return dt;
        }
    }
}
