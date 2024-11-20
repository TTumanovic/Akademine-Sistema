using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Akademine_Sistema
{
    public partial class Form3 : Form
    {
        Grupes grupes = new Grupes();
        public Form3()
        {
            InitializeComponent();
            DisplayGroups();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string groupName = textBox1.Text; 
            if (!string.IsNullOrWhiteSpace(groupName))
            {
                grupes.AddGroup(groupName);
                MessageBox.Show("Group added successfully.");
                DisplayGroups(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid group name.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string groupName = textBox1.Text; 
            if (!string.IsNullOrWhiteSpace(groupName))
            {
                grupes.DeleteGroup(groupName);
                MessageBox.Show("Group deleted successfully.");
                DisplayGroups(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid group name.");
            }
        }
        private void DisplayGroups()
        {
    
            Grupes grupes = new Grupes();

      
            DataTable dt = grupes.GetGroup();

            dataGridView1.DataSource = dt;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            DisplayGroups(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
