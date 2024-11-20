using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


       namespace Akademine_Sistema
    {
        public class Studentai
        {
            private Connect dbConnection = new Connect();

            public bool AddStudent(string name, string surname, string username, string password, string groupName)
            {
                try
                {
                    dbConnection.OpenConnection();
                    string query = @"
                    USE Studentai; INSERT INTO Studentas (studentName, studentSur, username, password, groupName)
                    VALUES (@Name, @Surname, @Username, @Password, @GroupName)";
                    SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@GroupName", groupName);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding student: {ex.Message}");
                    return false;
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }

        public bool DeleteStudent(string username, string password, string groupName)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = @"
        USE Studentai; 
        DELETE FROM Studentas 
        WHERE LOWER(username) = LOWER(@Username) AND password = @Password AND groupName = @GroupName";

                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@GroupName", groupName);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student: {ex.Message}");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
            public DataTable GetStudentai()
        {
            string query = "USE Studentai; SELECT * FROM Studentas";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        }

    
}
