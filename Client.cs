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
using System.Security.Cryptography;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{

   
   public class Client
    {

        public bool InsertClient(String fname, String lname, String phone, String address)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "insert into  dbo.Clients(fname,lname,phone,address) VALUES (@fname,@lname,@phone,@address)";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);

                    if (command.ExecuteNonQuery() >= 1)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }

           

        //get all clients
        public DataTable GetAllClients()
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "SELECT * FROM Clients ";
            DataTable table = new DataTable();
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {

                    using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                    {

                        table.Load(reader);
                    }
                }
                connection.Close();
            }
            return table;

        }


        //edit client data
        public bool EditClient(int id, String fname, String lname, String phone, String address)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "UPDATE Clients SET fname=@fname, lname=@lname, phone=@phone, address=@address WHERE id=@myid";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {
                   
                    command.Parameters.AddWithValue("@myid", id);
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);

                    if (command.ExecuteNonQuery() >= 1)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }

        //remove client
        public bool RemoveClient(int id)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "DELETE FROM Clients WHERE id = @myid";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {
                   
                    command.Parameters.AddWithValue("@myid", id);


                    if (command.ExecuteNonQuery() >= 1)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }
    }
}
