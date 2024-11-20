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
    internal class Dalykai
    {
        private Connect dbConnection = new Connect();

        public bool AddSubject(string subjectName, string groupName, string professor)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = @"
                USE Dalykai; 
                INSERT INTO Dalykas (dalykoName, dalykoDest, groupName) 
                VALUES (@SubjectName, @Professor, @GroupName)";

                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                cmd.Parameters.AddWithValue("@Professor", professor);
                cmd.Parameters.AddWithValue("@GroupName", groupName);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding subject: {ex.Message}");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        public bool DeleteSubject(string subjectName, string groupName, string professor)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = @"
                USE Dalykai;
                DELETE FROM Dalykas
                WHERE dalykoName = @SubjectName 
                  AND groupName = @GroupName 
                  AND dalykoDest = @Professor";

                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                cmd.Parameters.AddWithValue("@GroupName", groupName);
                cmd.Parameters.AddWithValue("@Professor", professor);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting subject: {ex.Message}");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        public DataTable GetDalykai()
        {
            string query = "USE Dalykai; SELECT * FROM Dalykas";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetGroups()
        {
            string query = "USE Grupes; SELECT groupName FROM Groups";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetProfessors()
        {
            string query = "USE Destytojai; SELECT name FROM Destytojas";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
