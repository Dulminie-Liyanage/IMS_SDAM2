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
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Connect to MySQL
            string connectingString = "server=127.0.0.1;uid=root;pwd=;database=log_db;";
            MySqlConnection conn = new MySqlConnection(connectingString);
            conn.Open();

            // Check login and get role
            string query = "SELECT role FROM users WHERE username = @username AND password = @password";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            object roleObj = cmd.ExecuteScalar();
            conn.Close();

            if (roleObj != null)
            {
                string role = roleObj.ToString();

                // Store user data in session
                Session.UserRole = role;
                Session.Username = username;

                MessageBox.Show("Login Successful as " + role);
                this.Hide();
                Main_Menu main_Menu = new Main_Menu();
                main_Menu.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

        }
    }
}
