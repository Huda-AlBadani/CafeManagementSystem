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

namespace CafeManagementSystem
{
    public partial class Form1 : Form
    {
        string conn = "server=localhost;Database=cafe;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("The inputs should not be Empty!");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();

                    string query = "SELECT id,name FROM user WHERE name = @username AND passwrd = @password";

                    using (MySqlCommand cm = new MySqlCommand(query, connection))
                    {
                        cm.Parameters.AddWithValue("@username", username);
                        cm.Parameters.AddWithValue("@password", password);
                        using (MySqlDataReader reader = cm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32("id");
                                string loggedInUsername = reader.GetString("name");

                                MessageBox.Show("correct login!");
                            }
                            else
                            {
                                MessageBox.Show("username or password incorrecte!");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
