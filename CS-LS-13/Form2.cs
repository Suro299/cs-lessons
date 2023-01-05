using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS_LS_13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void load(string login, string pas, string radeoesiminch)
        {
            label2.Text = "Dzer login@: " + login;
            label3.Text = "Dzer parol@: " + pas;
            label4.Text = "Duq " + radeoesiminch + " ek";
        }
    }
}
