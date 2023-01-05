using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS_TEST_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string pas;
        string log;
        public void load(string name, string surname, string login, string password)
        {
            label1.Text = "Hello " + name + " " + surname;
            pas = password;
            log = login;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == log && textBox4.Text == pas)
            {
                Form3 myforum = new Form3();
                myforum.Show();
            } else
            {
                if (textBox3.Text != log)
                {
                    MessageBox.Show("Dzer login@ sxal e grvat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox3.Text = "";
                 
                } else if (textBox4.Text != pas)
                {
                    MessageBox.Show("Dzer parol@ sxal e grvat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

             
                    textBox4.Text = "";
                }

            }
        }

        
    }
}
