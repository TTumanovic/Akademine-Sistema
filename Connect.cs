using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademine_Sistema
{
    class Connect
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-8P3E6TQ\\SQLEXPRESS;Integrated Security=True;Encrypt=False");

        public SqlConnection GetConnection()
        {
            return con;
        }

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
