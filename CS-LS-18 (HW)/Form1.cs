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

namespace CS_LS_18__HW_
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

            OpenFileDialog esiminch = new OpenFileDialog();
            if (esiminch.ShowDialog() == DialogResult.OK)
            {
                if ((file = esiminch.OpenFile()) != null)
                {
                    string filename = esiminch.FileName;
                    string text = File.ReadAllText(filename);
                    richTextBox1.Text = text;
                }
            }
        }
    }
}

