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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "Database=marathon-skills-2020;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=root;";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            try
            {
                
                MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `Email`= '" + textBox1.Text + "' AND `Password`= '" + textBox2.Text + "';", connect);
                string countuser;
                string Role = "";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countuser = reader.GetString(0);
                    Role = reader.GetString("RoleId");
                    
                }
                reader.Close();
               // if (countuser == 1)
              //  {
                    if (Role == "R")
                    {
                        Form7 f7 = new Form7();
                        f7.Show();
                        
                    }
                if (Role == "A")
                {
                    Form7 f9 = new Form7();
                    f9.Show();

                }
                if (Role == "C")
                {
                    Form7 f8 = new Form7();
                    f8.Show();

                }
                //  }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox3.Text = CherezJopy3.text;
        }
    }
}
