using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IMS
{
    internal class Report_Controller
    {
        public static DataTable GetMostOrderedProducts()
        {
            string query = @"
        SELECT p.sku, p.name, SUM(o.quantity) AS total_ordered
        FROM orders o
        JOIN products p ON o.sku = p.sku
        GROUP BY p.sku, p.name
        ORDER BY total_ordered DESC";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        static string connStr = "server=127.0.0.1;uid=root;pwd=;database=inventory_db;";
        static MySqlConnection conn = new MySqlConnection(connStr);
        public static DataTable GetStockLevels()
        {
            string query = "SELECT sku, name, quantity FROM products";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

