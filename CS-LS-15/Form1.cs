using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var message = MessageBox.Show("Hamozvat es aperik ???", "Error unes hets ara ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            //if(message == DialogResult.Yes)
            //{
            //    var newmes = MessageBox.Show("Kori ha stuc ara ", "Vates ara ? ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    if(newmes == DialogResult.OK)
            //    {
            //        Application.Exit();
            //    }
            //}
            //else
            //{
            //    Application.Exit();
            //}
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure ?", "Chgitem inch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if (message == DialogResult.Yes)
            {
                MessageBox.Show("Chgitrm inch", "Chgitem inch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
