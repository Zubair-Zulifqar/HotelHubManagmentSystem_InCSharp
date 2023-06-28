using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }





        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

                string selectQuery = "SELECT * FROM users WHERE username = @username AND password = @password"; ;

                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@username", tbUsername.Text);
                        command.Parameters.AddWithValue("@password", tbPassword.Text);
                        using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                this.Hide();
                                HomeForm mainForm = new HomeForm();
                                mainForm.ShowDialog();
                            }
                            else
                            {
                                if (tbUsername.Text.Trim().Equals(""))
                                {
                                    MessageBox.Show("Enter your username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (tbPassword.Text.Trim().Equals(""))
                                {
                                    MessageBox.Show("Enter your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("This username or password does not exists", "Wrong Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            Console.ReadLine();

        }
    }
}
                        
                 
