using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string hatk = "";
            label1.Text = comboBox1.Text + " " + comboBox2.Text + " Guyni";

            
            if (checkBox1.Checked == true)
            {
                hatk = hatk + " " + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                hatk = hatk + " " + checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                hatk = hatk + " " + checkBox3.Text;
            }

            label2.Text = "Indz dur e galis" + hatk;
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
