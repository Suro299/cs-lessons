using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_21_HW_
{
    public partial class Form1 : Form
    {

        float bydje = 0;
        public Form1()
        {
            InitializeComponent();

            string[] text = label1.Text.Split('-');
            bydje = float.Parse(text[1]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hac - 500");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Panir - 800");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("dzu - 300");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        public float verjingin = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            verjingin = 0;

            foreach (var item in listBox1.Items)
            {
                string[] apranq = item.ToString().Split('-');
                string gin = apranq[1];
                float norgin = float.Parse(gin);
                verjingin += norgin;

            }

            var esim_inch = MessageBox.Show("Apranqneri @ndanur arjeq@ kazum e " + verjingin + " dram", "Arnel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (esim_inch == DialogResult.Yes)
            {
                if (bydje >= verjingin)
                {

                    float norbyudje = bydje - verjingin;
                    //bydje = bydje - verjingin;
                    label4.Text = "Dallaqyan Suren - " + norbyudje.ToString();
                    listBox1.Items.Clear();

                }
                else
                {
                    MessageBox.Show("Etqan pox chunes", "Esim inch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
