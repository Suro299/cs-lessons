using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_LS_21
{
    public partial class Form1 : Form
    {

        float bydje = 0;
        public Form1()
        {
            InitializeComponent();

            string[] text = label1.Text.Split(':');
            bydje = float.Parse(text[1]);

        }

        private void Konopka(object sender, EventArgs e)
        {
            Button my_buttion = (Button)sender;
            listBox1.Items.Add(my_buttion.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string file = File.ReadAllText("C://Gago/Gago.txt");

            string[] toxer = file.Split("\n");

            foreach (var item in toxer)
            {
                listBox2.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        public float verjingin = 0;
        private void button9_Click(object sender, EventArgs e)
        {

            verjingin = 0;

            foreach (var item in listBox1.Items)
            {
                string[] apranq = item.ToString().Split('-');
                string gin = apranq[1];
                float norgin = float.Parse(gin);
                verjingin += norgin;

            }

            if (verjingin >= 3000)
            {

                float zexjgin = verjingin / 10;
                verjingin -= zexjgin;

               
            }

            var esim_inch = MessageBox.Show("Apranqneri @ndanur arjeq@ kazum e " + verjingin + " dram", "Arnel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (esim_inch == DialogResult.Yes)
            {
                if (bydje >= verjingin)
                {

                    float norbyudje = bydje - verjingin;
                    bydje = bydje - verjingin;


                    label1.Text = "Dallaqyan Suren: " + norbyudje.ToString();
                    listBox1.Items.Clear();

                }
                else
                {
                    MessageBox.Show("Etqan pox chunes", "Esim inch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apranq = listBox2.SelectedItem.ToString();
            listBox1.Items.Add(apranq);
        }
    }
}
