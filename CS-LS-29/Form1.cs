using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_29
{
    public partial class Form1 : Form
    {

        int harc = 0;
        int ochok = 0;
        public Form1()
        {
            InitializeComponent();
        }


        List<string> exbarer = new List<string>();
        string[] barer = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
        private void Form1_Load(object sender, EventArgs e)
        {
            //abel1.Text = barer[harc];
            exbarer.Add("a");
            random();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        void random()
        {

            foreach(string item in exbarer)
            {
                foreach (string baritem in barer)
                {
                    if(item != baritem)
                    {
                        Random x = new Random();
                        int norbar = x.Next(0, 10);
                        harc = norbar;
                        label1.Text = barer[harc];
                        exbarer.Add(barer[harc]);
                    }
                }
            }

        }

        private void tick(object sender, EventArgs e)
        {
            vdio();
            if (progressBar1.Value <= 100)
            {
                progressBar1.Value += 50;
            } else {
                harc++;
                label1.Text = barer[harc];
                random();
                progressBar1.Value = 0;
                textBox1.Text = "";
            }
        }

       
        void vdio()
        {
            if (harc < 9)
            {
                if (textBox1.Text == label1.Text)
                {
                    ochok++;
                    //harc++;
                    random();
                    label1.Text = barer[harc];
                    progressBar1.Value = 0;
                    textBox1.Text = "";
                   

                }
            }
            else
            {
                timer1.Stop();
                var mymess = MessageBox.Show("Duq havaqeciq " + ochok + " ochok", "Ura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if(harc < 9)
        //    {
        //        if (textBox1.Text == label1.Text)
        //        {
        //            ochok++;
        //            harc++;
        //            label1.Text = barer[harc];
        //            progressBar1.Value = 0;
        //            textBox1.Text = "";

        //        }
        //        else
        //        {
        //            harc++;
        //            label1.Text = barer[harc];
        //            progressBar1.Value = 0;
        //            textBox1.Text = "";
        //        }
        //    } else
        //    {
        //        timer1.Stop();
        //        var mymess = MessageBox.Show("Duq havaqeciq " + ochok + " ochok", "Ura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
