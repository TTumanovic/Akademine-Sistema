using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Akademine_Sistema
{
    internal class Destytojai
    {
        private Connect dbConnection = new Connect();

        public bool AddProfessor(string name, string surname, string username, string password)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = @"
                USE Destytojai; INSERT INTO Destytojas (name, surname, username, password)
                VALUES (@Name, @Surname, @Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
     
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding professor: {ex.Message}");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        public bool DeleteProfessor(string username, string password)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = @"
                USE Destytojai; 
                DELETE FROM Destytojas 
                WHERE LOWER(username) = LOWER(@Username) AND password = @Password";

                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting professor: {ex.Message}");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        public DataTable GetProfessors()
        {
            try
            {
                string query = "USE Destytojai; SELECT * FROM Destytojas";
                SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.GetConnection());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching professors: {ex.Message}");
                return null;
            }
        }
    }
}
