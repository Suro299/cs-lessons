using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS_TEST_3
{
    public partial class Form3 : Form
    {
        float asd;
        string gort;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asd = float.Parse(textBox2.Text);
            textBox2.Text = "";
            gort = "Bazmapaktum";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asd = float.Parse(textBox2.Text);
            textBox2.Text = "";
            gort = "Bajanum";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            asd = float.Parse(textBox2.Text);
            textBox2.Text = "";
            gort = "Hanum";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            asd = float.Parse(textBox2.Text);
            textBox2.Text = "";
            gort = "Gumarum";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gort == "Gumarum")
            {
                textBox2.Text = (float.Parse(textBox2.Text) + asd).ToString();
            }
            else if (gort == "Hanum")
            {
                textBox2.Text = (asd - float.Parse(textBox2.Text)).ToString();
            }
            else if (gort == "Bazmapaktum")
            {
                textBox2.Text = (float.Parse(textBox2.Text) * asd).ToString();
            }
            else if (gort == "Bajanum")
            {
                textBox2.Text = (asd / float.Parse(textBox2.Text)).ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            asd = '\0';
            gort = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
        }
    }
}
