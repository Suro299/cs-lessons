using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Barev " + textBox1.Text;
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Text = "Hors arev " + (float.Parse(textBox1.Text) + float.Parse(textBox3.Text)).ToString();
            label5.Text = "+";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Hors arev " + (float.Parse(textBox1.Text) - float.Parse(textBox3.Text)).ToString();
            label5.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Hors arev " + (float.Parse(textBox1.Text) * float.Parse(textBox3.Text)).ToString();
            label5.Text = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Hors arev " + (float.Parse(textBox1.Text) / float.Parse(textBox3.Text)).ToString();
            label5.Text = "/";
        }
    }
}
