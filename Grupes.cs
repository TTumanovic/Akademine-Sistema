using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Akademine_Sistema
{
    public class Grupes
    {
        Connect connect = new Connect();

      
        public void AddGroup(string groupName)
        {
            string query = "USE Grupes; INSERT INTO Groups (groupName) VALUES (@groupName)";
            using (SqlCommand cmd = new SqlCommand(query, connect.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@groupName", groupName);
                connect.OpenConnection();
                cmd.ExecuteNonQuery();
                connect.CloseConnection();
            }
        }

        public void DeleteGroup(string groupName)
        {
            string query = "USE Grupes; DELETE FROM Groups WHERE groupName = @groupName";
            using (SqlCommand cmd = new SqlCommand(query, connect.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@groupName", groupName);
                connect.OpenConnection();
                cmd.ExecuteNonQuery();
                connect.CloseConnection();
            }
        }

        public DataTable GetGroup()
        {
            string query = "USE Grupes; SELECT * FROM Groups";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect.GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        internal DataTable GetGroups()
        {
            throw new NotImplementedException();
        }
    }
}