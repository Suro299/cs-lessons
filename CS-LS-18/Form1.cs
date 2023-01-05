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

namespace CS_LS_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("C:/Xosqi papka/HorsArev.txt");
            file.Write(richTextBox1.Text);
            label1.Text = "Seyvavat exav (de piti exat lini)";
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream file;

            OpenFileDialog window = new OpenFileDialog();
            if(window.ShowDialog() == DialogResult.OK)
            {
                if ((file = window.OpenFile()) != null)
                {
                    string filename = window.FileName;
                    string text = File.ReadAllText(filename);
                    richTextBox1.Text = text;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}
