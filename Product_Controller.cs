using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Product_Controller
    {
        //Define the connection string to the MySQL database
        static string connStr = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;";
        static MySqlConnection conn = new MySqlConnection(connStr);

        //Add Product
        public static string AddProduct(string sku, string name, string quantity, string price, string category)
        {
            if (sku == "" || name == "" || quantity == "" || price == "" || category == "")
                return "Please fill all the fields!"; //check if all the field are filled


            // Check if quantity is a valid number
            try
            {
                int qty = Convert.ToInt32(quantity);
                if (qty <= 0)
                    return "Quantity cannot be negative.";
            }
            catch
            {
                return "Quantity must be a whole number.";
            }

            // Check if price is a valid number
            try
            {
                double pr = Convert.ToDouble(price);
                if (pr <= 0)
                    return "Price cannot be negative.";
            }
            catch
            {
                return "Price must be a number.";
            }

            string checkQuery = "SELECT COUNT(*) FROM products WHERE sku = @sku";
            conn.Open();
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@sku", sku);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            conn.Close();

            if (count > 0)
                return "SKU already exists!";

            string insert = "INSERT INTO products (sku, name, quantity, price, category) VALUES (@sku, @name, @qty, @price, @cat)";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@sku", sku);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@qty", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@cat",category);
            cmd.ExecuteNonQuery();
            conn.Close();

            return "Product added !";
        }

        //Update Product
        public static string Update_Product(string sku, string name, string quantity, string price, string category)
        {
            if (sku == "" || name == "" || quantity == "" || price == "" || category == "")
                return "Please fill all fields!";

            try
            {
                int qty = Convert.ToInt32(quantity);
                if (qty <= 0)
                    return "Quantity cannot be negative.";
            }
            catch
            {
                return "Quantity must be a whole number.";
            }

            try
            {
                double pr = Convert.ToDouble(price);
                if (pr <= 0)
                    return "Price cannot be negative.";
            }
            catch
            {
                return "Price must be a number.";
            }


            string query = "UPDATE products SET name=@name, quantity=@qty, price=@price, category=@cat WHERE sku=@sku";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@sku", sku);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@qty", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@cat", category);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
                return "Product updated!";
            else
                return "SKU not found!";
        }

        //Search Product
        public static DataTable SearchProduct(string keyword)
        {
            string query = "SELECT * FROM products WHERE sku LIKE @kw OR name LIKE @kw";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static string Delete_Product(string sku)
        {
            //check if sku is empty
            if (sku == "")
                return "Please enter the SKU to delete.";

            //SQL query to delete a product with given sku
            string deleteQuery = "DELETE FROM products WHERE sku = @sku";

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
            cmd.Parameters.AddWithValue("@sku",sku);

            int rows = cmd.ExecuteNonQuery();//execute the delete cmd and get number of affeted rows

            conn.Close();

            if (rows > 0)
            {
                return "Product deleted successfully!";
            }
            else
            {
                return "SKU not found. Nothing deleted.";
            }
        }

        public static DataTable GetLowStockProducts(int threshold)
        {
            string query = "SELECT sku, name, quantity FROM products WHERE quantity < @limit";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@limit", threshold);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);

            return table;
        }


    }
}
