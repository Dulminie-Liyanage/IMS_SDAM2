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
        public static string AddSupplier(string supplier_id, string name, string contact)
        {
            if (supplier_id == "" || name == "" || contact == "")
                return "Please fill all the fields!";

            // Validate ID
            try
            {
                int sid = Convert.ToInt32(supplier_id);
                if (sid <= 0)
                    return "Supplier ID must be a positive number.";
            }
            catch
            {
                return "Supplier ID must be a number.";
            }
            try
            {
                int scontact = Convert.ToInt32(contact);
                if (scontact <= 0)
                    return "Supplier Contact must be a positive number.";
            }
            catch
            {
                return "Supplier Contact must be a number.";
            }

            string checkQuery = "SELECT COUNT(*) FROM supplier WHERE supplier_id = @supplier_id";
            conn.Open();
            MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            conn.Close();

            if (count > 0)
                return "Supplier ID already exists.";

            string insert = "INSERT INTO supplier (supplier_id, name, contact) VALUES (@supplier_id, @name, @contact)";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.ExecuteNonQuery();
            conn.Close();

            return "Supplier added!";
        }

        // Update Supplier
        public static string UpdateSupplier(string supplier_id, string name, string contact)
        {
            if (supplier_id == "" || name == "" || contact == "")
                return "Please fill all fields!";

            try
            {
                int sid = Convert.ToInt32(supplier_id);
                if (sid <= 0)
                    return "Supplier ID must be positive.";
            }
            catch
            {
                return "Supplier ID must be a number.";
            }

            try
            {
                int scontact = Convert.ToInt32(contact);
                if (scontact <= 0)
                    return "Supplier Contact must be a positive number.";
            }
            catch
            {
                return "Supplier Contact must be a number.";
            }

            string update = "UPDATE supplier SET name=@name, contact_info=@contact WHERE id=@id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@contact", contact);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
                return "Supplier updated!";
            else
                return "Supplier not found!";
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
            string query = "SELECT * FROM supplier WHERE id LIKE @kw OR name LIKE @kw";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
    

