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
    public partial class Home : Form
    {
        private int currentUserId;
        private string currentUsername;

        public Home()
        {
            InitializeComponent();
        }

        public Home(int userId, string username)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUsername = username;
            this.Load += (sender, e) => CheckUserPermissions();

        }

        private void CheckUserPermissions()
        {
            string conn = "server=localhost;Database=cafe;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    string query = "SELECT role FROM user WHERE id = @userid";

                    using (MySqlCommand cm = new MySqlCommand(query, connection))
                    {
                        cm.Parameters.AddWithValue("@userid", currentUserId);
                        object result = cm.ExecuteScalar();

                        if (result != null)
                        {
                            string userType = result.ToString();
                            bool isAdmin = (userType == "Admin");

                            btnAdd.Visible = isAdmin;
                            btnUpdate.Visible = isAdmin;
                            btnRemove.Visible = isAdmin;
                        }
                        else
                        {
                            btnAdd.Visible = false;
                            btnUpdate.Visible = false;
                            btnRemove.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User permissions error: " + ex.Message);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            uc_add1.Visible = false;
            uc_order1.Visible = false;
            uc_update1.Visible = false;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            uc_add1.Visible = true;
            uc_add1.BringToFront();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            uc_order1.Visible = true;
            uc_order1.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            uc_update1.Visible = true;
            uc_update1.BringToFront();
        }
    }
}
