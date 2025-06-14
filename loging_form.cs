using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IMS
{
    public partial class loging_form : Form
    {
        public loging_form()
        {
            InitializeComponent();
        }

        private void loging_form_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //Get values by the user 
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            //connect to sql server 
            string connectingString = "server=127.0.0.1;uid=root;pwd=;database=log_db;";
            MySqlConnection conn = new MySqlConnection(connectingString);
            conn.Open();

            string query1 = "SELECT COUNT(*) FROM users WHERE username=@Username and password = @Password";
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@username", username);
            cmd1.Parameters.AddWithValue("@password", password);

            int usercount = Convert.ToInt32(cmd1.ExecuteScalar());

            conn.Close();
            if (usercount > 0)
            {
                MessageBox.Show("Loging Successfull!");

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
