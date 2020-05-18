using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Контакты" +
                " " +
                "Для получения дополнительной информации связитесь с координаторами" +
                " " +
                "Телефон: 55 11 9988 7766" +
                " " +
                "Email: coordinators@marathonskills.org");

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label2.Text = CherezJopy3.text;
        }
    }
}
