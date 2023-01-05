using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CS_LS_19
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        string usernamest;
        int himnakan_gumar;
        int nor_gumar;

        public void barev(string username)
        {
            usernamest = username;
            string text = File.ReadAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/" + username + ".txt");

            string[] toxer = text.Split("\n");

            string[] nametox = toxer[0].Split(":");
            string[] acnametox = toxer[1].Split(":");
            string[] moneytox = toxer[2].Split(":");

            label1.Text = label1.Text + nametox[1];
            label2.Text = label2.Text + acnametox[1];
            label3.Text = label3.Text + moneytox[1];
            himnakan_gumar = int.Parse(moneytox[1]);

        }



        private void button2_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "")
            {
                nor_gumar = int.Parse(textBox1.Text);
                int pat = himnakan_gumar + nor_gumar;

                string text = File.ReadAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/" + usernamest + ".txt");

                text = text.Replace(himnakan_gumar.ToString(), pat.ToString());
                File.WriteAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/" + usernamest + ".txt", text);

                MessageBox.Show("Karoche sax exav haves chunem grelu", "URAAAA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Greq inchqan gumar eq uzum avelacnel", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && himnakan_gumar >= int.Parse(textBox1.Text))
            {
                nor_gumar = int.Parse(textBox1.Text);
                int pat = himnakan_gumar - nor_gumar;

                string text = File.ReadAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/" + usernamest + ".txt");

                text = text.Replace(himnakan_gumar.ToString(), pat.ToString());
                File.WriteAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/" + usernamest + ".txt", text);
                MessageBox.Show("Karoche sax exav haves chunem grelu", "URAAAA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Dzer grat gumar@ chi bavararum gortoxutyun@ katarelu hamar u vabshe gna stuc um em inch asum ara", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                string text = File.ReadAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/Karen.txt");

                string[] toxer = text.Split("\n");

             
                string[] moneytox = toxer[2].Split(":");

                nor_gumar = int.Parse(textBox1.Text);
                int pat = int.Parse(moneytox[1]) + nor_gumar;


                text = text.Replace(moneytox[1], pat.ToString());
                File.WriteAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/Karen.txt", text);

                nor_gumar = int.Parse(textBox1.Text);
                int pat1 = himnakan_gumar - nor_gumar;

                string text2 = File.ReadAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/" + usernamest + ".txt");

                text2 = text2.Replace(himnakan_gumar.ToString(), pat1.ToString());
                File.WriteAllText("C:/Users/suren/OneDrive/Рабочий стол/Think/C#/CS-LS-19/" + usernamest + ".txt", text2);


                MessageBox.Show("Karoche sax exav haves chunem grelu", "URAAAA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Dzer grat gumar@ chi bavararum gortoxutyun@ katarelu hamar u vabshe gna stuc um em inch asum ara", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
