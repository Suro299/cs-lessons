using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Barev";
            string password = "Hajox";
          

            if (textBox1.Text == username && textBox2.Text == password)
            {
                Form2 norforma = new Form2();
                norforma.Show();

                norforma.load(textBox1.Text, textBox2.Text, radeobuttonvalue);
            }

        }

        string radeobuttonvalue;
        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radeobuttonvalue = "Txa";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

            radeobuttonvalue = "Vinks";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            radeobuttonvalue = "Axjik";
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            } else
            {
                textBox2.PasswordChar = '*';
            }
                    
        }

    }
}
