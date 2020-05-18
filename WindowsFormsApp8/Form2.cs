using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
            Form3 f3 = new Form3();
            CherezJopy.text = numericUpDown1.Value.ToString();
            CherezJopy2.text = comboBox1.Text;
            f3.Show();
            this.Close();

        }

        private void Cliik(object sender, EventArgs e)
        {
            CherezJopy4.Text = textBox1.Text;
            Form11 f11 = new Form11();
            f11.Show();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label14.Text = CherezJopy3.text;
            string connection = "Database=marathon-skills-2020;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=root;";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            MySqlCommand command1 = new MySqlCommand("Select concat(CharityName) from charity Where 1", connect);
            MySqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox2.Items.Add(reader1.GetString(0));
            }
            comboBox2.SelectedIndex = 0;
            reader1.Close();
            connect.Close();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CherezJopy5.text = comboBox2.Text;
        }
    }
}
