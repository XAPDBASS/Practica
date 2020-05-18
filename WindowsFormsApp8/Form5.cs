using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp8
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
       
        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = CherezJopy3.text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Database=marathon-skills-2020;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=root;";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `charity`;", connect);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            


        }
    }
}
