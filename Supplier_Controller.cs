using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Supplier_Controller
    {
        // Define the connection string to the MySQL database
        static string connStr = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;";
        static MySqlConnection conn = new MySqlConnection(connStr);

        // Add Supplier
        public static string AddSupplier(string supplier_id, string name, string contact, string linked_product)
        {
            if (supplier_id == "" || name == "" || contact == "" || linked_product == "")
                return "Please fill all the fields including linked product SKU!";

            // Validate ID and Contact
            try
            {
                int sid = Convert.ToInt32(supplier_id);
                int phone = Convert.ToInt32(contact);
                if (sid <= 0 || phone <= 0)
                    return "ID and contact must be positive numbers.";
            }
            catch
            {
                return "Supplier ID and Contact must be numbers.";
            }

            // Check if supplier already exists
            string checkQuery = "SELECT COUNT(*) FROM supplier WHERE supplier_id = @supplier_id";
            conn.Open();
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            conn.Close();

            if (count > 0)
                return "Supplier ID already exists.";

            // Check if product SKU exists
            string checkProduct = "SELECT COUNT(*) FROM products WHERE sku = @sku";
            conn.Open();
            MySqlCommand prodCmd = new MySqlCommand(checkProduct, conn);
            prodCmd.Parameters.AddWithValue("@sku", linked_product);
            int prodCount = Convert.ToInt32(prodCmd.ExecuteScalar());
            conn.Close();

            if (prodCount == 0)
                return "Product SKU does not exist in the database!";

            // Insert supplier
            string insert = "INSERT INTO supplier (supplier_id, name, contact) VALUES (@supplier_id, @name, @contact)";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.ExecuteNonQuery();
            conn.Close();

            // Insert relation in product_supplier table
            string linkProduct = "INSERT INTO product_supplier (supplier_id, sku) VALUES (@supplier_id, @sku)";
            conn.Open();
            MySqlCommand linkCmd = new MySqlCommand(linkProduct, conn);
            linkCmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            linkCmd.Parameters.AddWithValue("@sku", linked_product);
            linkCmd.ExecuteNonQuery();
            conn.Close();

            return "Supplier added and product linked!";
            }

        

        // Update Supplier
        public static string UpdateSupplier(string supplier_id, string name, string contact, string linked_product)
        {
            if (supplier_id == "" || name == "" || contact == "" || linked_product == "")
                return "Please fill all the fields including linked product SKU!";

            // Validate ID and Contact
            try
            {
                int sid = Convert.ToInt32(supplier_id);
                int phone = Convert.ToInt32(contact);
                if (sid <= 0 || phone <= 0)
                    return "ID and contact must be positive numbers.";
            }
            catch
            {
                return "Supplier ID and Contact must be numbers.";
            }

            // Check if supplier exists
            string checkSupplier = "SELECT COUNT(*) FROM supplier WHERE supplier_id = @supplier_id";
            conn.Open();
            MySqlCommand checkCmd = new MySqlCommand(checkSupplier, conn);
            checkCmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            int supplierCount = Convert.ToInt32(checkCmd.ExecuteScalar());
            conn.Close();

            if (supplierCount == 0)
                return "Supplier ID does not exist.";

            // Check if product SKU exists
            string checkProduct = "SELECT COUNT(*) FROM products WHERE sku = @sku";
            conn.Open();
            MySqlCommand prodCmd = new MySqlCommand(checkProduct, conn);
            prodCmd.Parameters.AddWithValue("@sku", linked_product);
            int prodCount = Convert.ToInt32(prodCmd.ExecuteScalar());
            conn.Close();

            if (prodCount == 0)
                return "Product SKU does not exist in the database!";

            // Update supplier info
            string updateSupplier = "UPDATE supplier SET name = @name, contact = @contact WHERE supplier_id = @supplier_id";
            conn.Open();
            MySqlCommand updateCmd = new MySqlCommand(updateSupplier, conn);
            updateCmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            updateCmd.Parameters.AddWithValue("@name", name);
            updateCmd.Parameters.AddWithValue("@contact", contact);
            int rowsUpdated = updateCmd.ExecuteNonQuery();
            conn.Close();

            if (rowsUpdated == 0)
                return "Supplier update failed.";

            // Update product_supplier link:
            string insertLink = "INSERT INTO product_supplier (supplier_id, sku) VALUES (@supplier_id, @sku)";
            conn.Open();
            MySqlCommand insertCmd = new MySqlCommand(insertLink, conn);
            insertCmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            insertCmd.Parameters.AddWithValue("@sku", linked_product);
            insertCmd.ExecuteNonQuery();
            conn.Close();

            return "Supplier updated and product linked!";
        }

        // Delete Supplier
        public static string DeleteSupplier(string supplier_id)
        {
            if (supplier_id == "")
                return "Please enter Supplier ID.";

            string query = "DELETE FROM supplier WHERE supplier_id = @supplier_id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
                return "Supplier deleted.";
            else
                return "Supplier ID not found.";
        }

        // Search Supplier
        public static DataTable SearchSupplier(string keyword)
        {
            string query = "SELECT * FROM supplier WHERE supplier_ID = @keyword";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@keyword", keyword);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       

    }
}
    

