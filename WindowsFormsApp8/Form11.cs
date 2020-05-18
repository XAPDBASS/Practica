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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string connection = "Database=marathon-skills-2020;" + "Data Source=127.0.0.1;" + "User Id=root;" + "Password=root;";
            MySqlConnection connect = new MySqlConnection(connection);
            connect.Open();
            

                MySqlCommand command = new MySqlCommand("SELECT `CharityDescription`  FROM `charity` WHERE `CharityName` = '" + CherezJopy5.text + "';", connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    label2.Text = reader.GetString("CharityDescription");
                

                }
                reader.Close();
                connect.Close();
                label1.Text = CherezJopy4.Text;
                if (CherezJopy5.text == "Arise")
                {
                    pictureBox1.Image = Properties.Resources.arise_logo;

                }
                if (CherezJopy5.text == "Aves do Brasil")
                {
                    pictureBox1.Image = Properties.Resources.conquer_cancer_brazil;
                }
                if (CherezJopy5.text == "Clara Santos Oliveira Institute")
                {
                    pictureBox1.Image = Properties.Resources.clara_santos_oliveira_institute_logo;
                }
                if (CherezJopy5.text == "Conquer Cancer - Brazil")
                {
                    pictureBox1.Image = Properties.Resources.conquer_cancer_brazil;
                }
                if (CherezJopy5.text == "Diabetes Brazil")
                {
                    pictureBox1.Image = Properties.Resources.diabetes_brazil_logo;
                }
                if (CherezJopy5.text == "Heart Health São Paulo")
                {
                    pictureBox1.Image = Properties.Resources.heart_health_sao_paulo_logo;
                }
                if (CherezJopy5.text == "Human Rights Centre  - São Paulo")
                {
                    pictureBox1.Image = Properties.Resources.human_rights_centre_logo;
                }
                if (CherezJopy5.text == "Stay Pumped")
                {
                    pictureBox1.Image = Properties.Resources.stay_pumped_logo;
                }
                if (CherezJopy5.text == "Upbeat SP")
                {
                    pictureBox1.Image = Properties.Resources.upbeat_logo;
                }
                if (CherezJopy5.text == "WWSM Rescue")
                {
                    pictureBox1.Image = Properties.Resources.wwsm_rescue_logo;
                }
                if (CherezJopy5.text == "The Red Cross")
                {
                    pictureBox1.Image = Properties.Resources.the_red_cross_logo;
                }
                if (CherezJopy5.text == "Oxfam International")
                {
                    pictureBox1.Image = Properties.Resources.oxfam_international_logo;
                }
                if (CherezJopy5.text == "Save the Children Fund")
                {
                    pictureBox1.Image = Properties.Resources.save_the_children_fund_logo;
                }
                if (CherezJopy5.text == "Querstadtein Berlin")
                {
                    pictureBox1.Image = Properties.Resources.querstadtein_logo;
                }


            
    }

    }
}
