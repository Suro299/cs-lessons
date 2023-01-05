using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pashton = textBox2.Text;
            string ashxatavardz = textBox3.Text;
            string ser = "";

            if(name != "" && pashton != "" && ashxatavardz != "")
            {
                dataGridView1.Rows.Add(name, pashton, ashxatavardz, ser);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)

            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Pashton"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Ashxatavardz"].Value.ToString();

                if (radioButton1.Checked)
                {

                    dataGridView1.CurrentRow.Cells["Ser"].Value = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {

                    dataGridView1.CurrentRow.Cells["Ser"].Value = radioButton2.Text;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null )
            {

                dataGridView1.CurrentRow.Cells["Name"].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells["Pashton"].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells["Ashxatavardz"].Value = textBox3.Text;

                if (radioButton1.Checked)
                {
                    dataGridView1.CurrentRow.Cells["Ser"].Value = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {              
                    dataGridView1.CurrentRow.Cells["Ser"].Value = radioButton2.Text;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {


                var ms = MessageBox.Show("Uzum ek jnjel ashxatoxin ?", "esim inch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ms == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
