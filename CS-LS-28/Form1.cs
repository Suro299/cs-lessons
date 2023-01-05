using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int scor = 0;
        int gravity = 20;
        int speed = 10;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool ha = false;
        private void timerfunc(object sender, EventArgs e)
        {

            label1.Text = "Score: " + scor;

            if (Trchun.Bounds.IntersectsWith(OCH.Bounds))
            {
                if(ha == false)
                {
                    scor++;
                    label1.Text = "Score: " + scor;
                    ha = true; 
                }

            }

            if (
                Trchun.Bounds.IntersectsWith(verevi_truba.Bounds) ||
                Trchun.Bounds.IntersectsWith(nerqevi_truba.Bounds) ||
                Trchun.Bounds.IntersectsWith(graund.Bounds) ||
                Trchun.Top <= 2
                )
            {
                timer1.Stop();
                label1.Text = "Game Over";
            }
            if(verevi_truba.Left <= -50)
            {
                verevi_truba.Left = 981;
                OCH.Left = 1034;
                ha = false;
            }
            else
            {
                verevi_truba.Left -= speed;
                OCH.Left -= speed;
            }
                    

            if (nerqevi_truba.Left <= -50)
            {
                nerqevi_truba.Left = 981;
                OCH.Left = 1034;
                ha = false;
            }
            else
            {
                nerqevi_truba.Left -= speed;
              
            }

            Trchun.Top += gravity;
            
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                timer1.Start();
             
            }

            if (e.KeyCode == Keys.Space)
            {
                gravity = 20;
   



            }
        }
       
        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -30;

            }

            if (e.KeyCode == Keys.Escape)
            {
                timer1.Start();
                if(label1.Text == "Game Over")
                {
                    Trchun.Location = new Point(65, 239);
                    label1.Text = "Score: " + scor;

                    verevi_truba.Location = new Point(981, -79);
                    nerqevi_truba.Location = new Point(981, 355);

                    scor = 0;
                }
            }
        }

        private void graund_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verevi_truba_Click(object sender, EventArgs e)
        {

        }
    }
}
