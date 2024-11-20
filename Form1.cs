using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;


namespace Akademine_Sistema
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

private void button1_Click(object sender, EventArgs e)
        {
   
            Connect connection = new Connect();
            SqlConnection con = connection.GetConnection();
            connection.OpenConnection();

            string username = textBox1.Text; // "Vartotojo kodas"
            string password = textBox2.Text; // "Slaptažodis"
            

            string query = ""; 
            bool isValidLogin = false; 

            // Admin Login
            if (!checkBoxStudent.Checked && !checkBoxProfessor.Checked)
            {
                query = "USE users; SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    isValidLogin = true;
                    Form2 adminForm = new Form2(); 
                    adminForm.Show();
                    this.Hide();
                }
            }
            // Student Login
            else if (checkBoxStudent.Checked)
            {
                query = "USE Studentai; SELECT COUNT(*) FROM Studentas WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    isValidLogin = true;
                    Form8 studentForm = new Form8(username, password); 
                    studentForm.Show();
                    this.Hide();
                }
            }
      
            else if (checkBoxProfessor.Checked)
            {
                query = "USE Destytojai; SELECT COUNT(*) FROM Destytojas WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    isValidLogin = true;
                    Form7 professorForm = new Form7(username, password);
                    professorForm.Show();
                    this.Hide();
                }
            }

         
            if (!isValidLogin)
            {
                MessageBox.Show("Login failed. Check your credentials or checkbox selection.");
            }

            connection.CloseConnection();
        }


    }
}