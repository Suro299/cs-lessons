using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TEST_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string surname;
            string login;
            string password;

            name = textBox1.Text;
            surname = textBox2.Text;
            login = textBox3.Text;
            password = textBox4.Text;

            Form2 norforma = new Form2();
            norforma.Show();

            norforma.load(name, surname, login, password);



        }
    }
}
