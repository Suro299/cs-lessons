using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            random();
        }

        public int gort;
        public int tiv_1;
        public int tiv_2;
        public int tiv_3;
        public int tiv_4;
        public int tiv_5;
        public int tiv_6;
        public int tiv_7;
        public int tiv_8;
        public int tiv_9;
        public int tiv_10;

        public int patagum;
        public int patahan;
        public int patabazm;
        public float patabaj;
        void random()
        {
            Random random = new Random();

            tiv_1 = random.Next(1, 20);
            tiv_2 = random.Next(1, 20);
            tiv_3 = random.Next(1, 20);
            tiv_4 = random.Next(1, 20);
            tiv_5 = random.Next(1, 20);
            tiv_6 = random.Next(1, 20);
            tiv_7 = random.Next(1, 20);
            tiv_8 = random.Next(1, 20);
            tiv_9 = random.Next(1, 20);
            tiv_10 = random.Next(1, 20);

            gort = random.Next(1, 4);

           
            textBox2.Text = patahan.ToString();
            textBox4.Text = patabaj.ToString();

            label2.Text = tiv
           

            patagum = tiv_1 + tiv_2;
            patahan = tiv_1 - tiv_2;
            patabazm = tiv_1 * tiv_2;
            patabaj = tiv_1 / tiv_2;

        }

        void stugel()
        {
            
            if (int.Parse(textBox1.Text) == patagum && int.Parse(textBox2.Text) == patahan && int.Parse(textBox3.Text) == patabazm && float.Parse(textBox4.Text) == patabaj)
            {
                random();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stugel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
