using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Akademine_Sistema
{
    public partial class Form4 : Form
    {
        private Studentai studentManager = new Studentai();
        private Connect dbConnection = new Connect();



        public Form4()
        {
            InitializeComponent();
            LoadGroups();
            DisplayStudents();
        }
        private void LoadGroups()
        {
            try
            {
                dbConnection.OpenConnection();
                string query = "USE Grupes; SELECT groupName FROM Groups";
                SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbGroups.DataSource = dt;
                cmbGroups.DisplayMember = "groupName";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading groups: {ex.Message}");
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private System.Windows.Forms.ComboBox GetCmbGroups()
        {
            return cmbGroups;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            DisplayStudents();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string groupName = ((DataRowView)cmbGroups.SelectedItem)["groupName"].ToString();

                bool success = studentManager.AddStudent(name, surname, username, password, groupName);
                if (success)
                {
                    MessageBox.Show("Student added successfully!");
                    DisplayStudents();
                }
                else
                {
                    MessageBox.Show("Error adding student.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string groupName = ((DataRowView)cmbGroups.SelectedItem)["groupName"].ToString();


                bool success = studentManager.DeleteStudent(username, password, groupName);
                if (success)
                {
                    MessageBox.Show("Student deleted successfully!");
                    DisplayStudents(); 

                }
                else
                {
                    MessageBox.Show("Error deleting student. Check if the username and password are correct.");
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled in correctly.");
            }
        }

        public void DisplayStudents()
        {
            
            Studentai stud = new Studentai();

            
            DataTable dt = stud.GetStudentai();

            
            dataGridView1.DataSource = dt;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            if (cmbGroups.SelectedItem == null)
            {
                MessageBox.Show("Please select a group.");
                return false;
            }

            return true;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
