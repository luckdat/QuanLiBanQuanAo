using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibanquanao
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            createConnection();
        }

        private void createConnection()
        {
            try
            {
                String stringConnection = "Server=DESKTOP-TMCDUUR\\LUCKDAT;Database=ASM2; Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                MessageBox.Show(" Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erorr createconnection " + ex.Message);
            }

        }

        private void btnexitLogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit ?", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtusername.Text;
                string password = txtpassword.Text;

                conn.Open();
                // Create SQL command
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                // Use parameters in SQL statement to avoid SQL Injection
                cmd.CommandText = "SELECT accessRights FROM staff WHERE username = @username AND password = @password";
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Get access rights from query result
                    string accessRights = reader["accessRights"].ToString().ToLower();

                    // Check access rights and open corresponding form
                    if (accessRights == "admin")
                    {
                        MessageBox.Show("Login successful as Admin!");
                        admin adminForm = new admin();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (accessRights == "staff")
                    {
                        MessageBox.Show("Login successful as Sales!");
                        staff salesForm = new staff();
                        salesForm.Show();
                        this.Hide();
                    }
                    else if (accessRights == "warehouse")
                    {
                        MessageBox.Show("Login successful as Warehouse!");
                        warehouse warehouseForm = new warehouse();
                        warehouseForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid access rights!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in btnLogin_Click: " + ex.Message);
            }
        }
    }
}
