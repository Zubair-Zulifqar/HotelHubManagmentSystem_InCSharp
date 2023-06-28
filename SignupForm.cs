using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

                string selectQuery = "insert into  dbo.Users(username,password) VALUES (@username,@password)";

                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@username", tbUsername.Text);
                        command.Parameters.AddWithValue("@password", tbPassword.Text);
                      
                        if (tbUsername.Text.Trim().Equals(""))
                        {
                            MessageBox.Show("Enter your username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (tbPassword.Text.Trim().Equals(""))
                        {
                            MessageBox.Show("Enter your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        int rowsAffected = -1;
                        rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected!=-1)
                            {
                                this.Hide();
                                HomeForm mainForm = new HomeForm();
                                mainForm.ShowDialog();
                            }
                        else
                        {
                            MessageBox.Show("Unable to signUp", "Wrong Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
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
