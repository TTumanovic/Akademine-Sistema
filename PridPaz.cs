using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Akademine_Sistema
{
   
    internal class PridPaz
    {
        Connect dbConnection = new Connect();
        public bool AddGrade(string groupName, string studentName, string studentSurname, string subjectName, string grade)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "USE Pazymiai;INSERT INTO Pazymys (grupe,vardas,pavarde,dalykas,paz) VALUES (@Grupe,@Vardas,@Pavarde,@Dalykas,@Paz)";
                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
            
                cmd.Parameters.AddWithValue("@Grupe", groupName);
                cmd.Parameters.AddWithValue("@Vardas", studentName);
                cmd.Parameters.AddWithValue("@Pavarde", studentSurname);
                cmd.Parameters.AddWithValue("@Dalykas", subjectName);
                cmd.Parameters.AddWithValue("@Paz", grade);

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

        public bool EditGrade(int pazID, int grade)
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "USE Pazymiai; UPDATE Pazymys SET paz = @grade WHERE pazID = @pazID";
                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());

                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@pazID", pazID);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error editing grade: {ex.Message}");
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        public DataTable GetPazymiai()
        {
            string query = "USE Pazymiai; SELECT * FROM Pazymys";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetSubjects()
        {
            string query = "USE Dalykai; SELECT dalykoName FROM Dalykas";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetStudents()
        {
            string query = "USE Studentai; SELECT studentName, studentSur  FROM Studentas";
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
    }
}


