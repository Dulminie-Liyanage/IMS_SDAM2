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

            try
            {
                Convert.ToInt32(quantity);
                Convert.ToDouble(price);
            }
            catch
            {
                //check if the qun and price is valid inputs
                return "Quantity must be a number and price mush be a valid amount!";
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
                Convert.ToInt32(quantity);
                Convert.ToDouble(price);
            }
            catch
            {
                return "Quantity and Price must be numbers!";
            }

            string update = "UPDATE products SET name=@name, quantity=@qty, price=@price, category=@cat WHERE sku=@sku";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(update, conn);
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

        ////Search Product
        //public static DataTable Search_Product(string sku, string name, string quantity, string price, string category)
        //{
        //    string connStr = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;";
        //    MySqlConnection conn = new MySqlConnection(connStr);

        //    string query = "SELECT * FROM products WHERE sku LIKE @kw OR name LIKE @kw";

        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
        //}

        //Delete Product

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
    }
}
