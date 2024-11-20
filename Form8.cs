using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Akademine_Sistema
{
    public partial class Form8 : Form
    {
        PridPaz PP = new PridPaz();
        Connect dbConnection = new Connect();
        public Form8(string username, string password)
        {
            InitializeComponent();
            DisplayPazymiai();
            label5.Text = $"{username}";
            label6.Text = $"{password}";
        }

        // Form Load event


        public void DisplayPazymiai()
        {
            // Create a new instance of the Grupes class (or use the existing one)
            PridPaz pazymiai = new PridPaz();

            // Retrieve the data from the database (assuming GetGroup() returns a DataTable)
            DataTable dt = pazymiai.GetPazymiai();

            // Assuming you have a DataGridView named dataGridView1 to display the groups
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}