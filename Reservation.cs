using System;
using System.Data;

namespace Hotel_Managment_System_ZubairZulfiqar_bsef20a504
{

    class Reservation
    {

        public DataTable GetAllReservations()
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "SELECT * FROM Reservations";
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

        public DataTable ShowAllReservations()
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "Select c.fname As FisrtName,c.lname As LastName,c.phone As PhoneNumber,c.address As Address,res.date_in As DateCheck_In,res.date_out As DateCheck_Out,res.payment As Payment,r.number As RoomNumber,r.type As Type from Users.dbo.Clients As c INNER JOIN Users.dbo.Reservations As res ON c.id=res.guestId INNER JOIN Users.dbo.Rooms As r ON res.roomId=r.roomId;";
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

        //make new reservation
        public bool MakeReservation(int guest, int room, DateTime dateIn, DateTime dateOut, String payment)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";
            String queryInsert = "INSERT INTO Reservations (guestId, roomId, date_in, date_out,payment) VALUES (@guest, @room, @dateIn, @dateOut,@payment)";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(queryInsert, connection))
                {
                    command.Parameters.AddWithValue("@guest", guest);
                    command.Parameters.AddWithValue("@room", room);
                    command.Parameters.AddWithValue("@dateIn", dateIn);

                    command.Parameters.AddWithValue("@dateOut", dateOut);
                    command.Parameters.AddWithValue("@payment", payment);


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

        //edit reservation
        public bool EditReservation(int id, int guest, int room, DateTime dateIn, DateTime dateOut, String payment)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";
            String query = "UPDATE Reservations SET guestId= @guest,roomId= @room,date_in= @dateIn,date_out= @dateOut,payment=@payment WHERE reservId = @id";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@guest", guest);
                    command.Parameters.AddWithValue("@room", room);
                    command.Parameters.AddWithValue("@dateIn", dateIn);

                    command.Parameters.AddWithValue("@dateOut", dateOut);
                    command.Parameters.AddWithValue("@payment", payment);


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
        public bool RemoveReservation(int id)
        {
            string connectionString = "Data Source=DESKTOP-U51LCFC\\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

            string selectQuery = "DELETE FROM Reservations WHERE reservId=@id";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                connection.Open();
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(selectQuery, connection))
                {

                    command.Parameters.AddWithValue("@id", id);



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
