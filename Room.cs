using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Diagnostics;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{
    class Room
    {

        //get all roomTypes
      
        public bool SetRoomFree(int number, String isFree)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "UPDATE Rooms SET occupied=@isFree WHERE number=@number";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@number", number);
                    command.Parameters.AddWithValue("@isFree", isFree);

                   
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

        //insert new room
        public bool InsertRoom(int number, String type,  String capacity, String price, String occupied)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "INSERT INTO Rooms(number, type,  capacity,price,occupied) VALUES (@number, @type,  @capacity,@price,@occupied)";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@number", number);
                    command.Parameters.AddWithValue("@occupied", occupied);
                    command.Parameters.AddWithValue("@type", type);
                   
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@price", price);

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

        //get all rooms
        public DataTable GetAllRooms()
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "SELECT * FROM Rooms";
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


        //edit ROOM data
        public bool EditRoom(int number, String type, String capacity, String price, String occupied)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "UPDATE Rooms SET type=@type, capacity=@capacity,price=@price,occupied=@occupied WHERE number=@number";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@number", number);
                    command.Parameters.AddWithValue("@occupied", occupied);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@price", price);

                    
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

        //remove room
        public bool RemoveRoom(int number)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "DELETE FROM Rooms WHERE number=@number";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {

                    command.Parameters.AddWithValue("@number", number);


                    
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
