using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_17__new_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            random();
        }

        public int tiv_1;
        public int tiv_2;
        public int tiv_3;
        public int tiv_4;
        public int tiv_5;
        public int tiv_6;
        public int tiv_7;
        public int tiv_8;


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


            label2.Text = tiv_1.ToString();
            label3.Text = tiv_2.ToString();
            label8.Text = tiv_3.ToString();
            label7.Text = tiv_4.ToString();
            label12.Text = tiv_5.ToString();
            label11.Text = tiv_6.ToString();
            label16.Text = tiv_7.ToString();
            label15.Text = tiv_8.ToString();

            patagum = tiv_1 + tiv_2;
            patahan = tiv_1 - tiv_2;
            patabazm = tiv_1 * tiv_2;
            patabaj = tiv_1 / tiv_2;

            textBox2.Text = (tiv_1 / tiv_2).ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
