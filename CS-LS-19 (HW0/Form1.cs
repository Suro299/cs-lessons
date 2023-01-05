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

namespace CS_LS_19__HW0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream file;

            OpenFileDialog window = new OpenFileDialog();

            if (window.ShowDialog() == DialogResult.OK)
            {
                if((file = window.OpenFile()) != null)
                {
                    string title = window.FileName;
                    string text = File.ReadAllText(title);

                    string[] esim_inch = text.Split("\n");

                    string[] tiv_1 = esim_inch[0].Split(":");
                    string[] tiv_2 = esim_inch[1].Split(":");

                    int pat = int.Parse(tiv_1[1]) + int.Parse(tiv_2[1]);

                    label2.Text = "     " + tiv_1[1];
                    label3.Text = tiv_2[1];
                    label1.Text = "   " + pat.ToString();
                    
                    
                }
            }

        }
    }
}
