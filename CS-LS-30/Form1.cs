using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_LS_30
{

   
    public partial class Form1 : Form
    {

        bool go_left, go_right, shooting, is_game_over, mega_bos_rejim;
        
        int scoore = 0;
        int game_speed = 10;
        int enemy_speed = 0;
        int boolet_speed = 0;
        int mbr_speed = 3;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        void reset_game()
        {
           
            timer1.Start();
            enemy_speed = 3;

            enemy_1.Left = random.Next(10, 200);
            enemy_2.Left = random.Next(230, 520);
            enemy_1.Top = 25;
            enemy_2.Top = 25;

            scoore = 0;
            is_game_over = false;
            shooting = false;

            mbr_bullet_1.Left = random.Next(100, 280);
            mbr_bullet_2.Left = random.Next(309, 488);
            mbr_bullet_1.Top += 0;
            mbr_bullet_2.Top += 0;
            mbr_bullet_1.Top = -300;
            mbr_bullet_2.Top = -300;
            mbr_bullet_1.Visible = false;
            mbr_bullet_2.Visible = false;
            mega_bos_rejim = false;
            enemy_3.Top = -300;

        }
        private void tick(object sender, EventArgs e)
        {
            if(scoore == 5)
            {
                enemy_speed = 4;
            } else if (scoore == 10)
            {
                enemy_speed = 6;
            }
            else if (scoore == 2)
            {
                enemy_speed = 7;
                mega_bos_rejim = true;
                mbr();
            }

            if (enemy_3.Top > 64)
            {
                mbr_speed = 0;
            }

            if (mega_bos_rejim == true)
            {
                enemy_3.Top += mbr_speed;
               
            }

            label1.Text = "Score: " + scoore;

            enemy_1.Top += enemy_speed;
            enemy_2.Top += enemy_speed;

            if(enemy_1.Top > 600 || enemy_2.Top > 600)
            {
                game_over();
            }

            if(go_left == true && Player.Left > 10)
            {
                Player.Left -= game_speed;
            }

            if (go_right == true && Player.Left < 500)
            {
                Player.Left += game_speed;
            }

            if(shooting == true)
            {
                boolet_speed = 20;
                bullet.Top -= boolet_speed;
            }

            if(bullet.Top < -40)
            {
                shooting = false;
                bullet.Top = 800;
            }

            if(bullet.Bounds.IntersectsWith(enemy_1.Bounds))
            {
                scoore++;
                shooting = false;
                bullet.Visible = false;

                enemy_1.Top = -200;
                enemy_1.Left = random.Next(10, 200);
            }

            if (bullet.Bounds.IntersectsWith(enemy_2.Bounds))
            {
                scoore++;
                shooting = false;
                bullet.Visible = false;

                enemy_2.Top = -200;
                enemy_2.Left = random.Next(230, 520);
            }

            if (Player.Bounds.IntersectsWith(enemy_1.Bounds) || Player.Bounds.IntersectsWith(enemy_2.Bounds))
            {
                game_over();
            }
           

            if (mbr_bullet_1.Bounds.IntersectsWith(Player.Bounds) || mbr_bullet_2.Bounds.IntersectsWith(Player.Bounds))
            {
                game_over();
            }

            if (bullet.Bounds.IntersectsWith(enemy_3.Bounds) && mega_bos_rejim == true)
            {
                panel2.Width -= 10;
                bullet.Visible = false;
                shooting = false;
                bullet.Top = 800;
            }



            if(mega_bos_rejim == true)
            {

               
                mbr_bullet_1.Visible = true;
                mbr_bullet_2.Visible = true;
                mbr_bullet_1.Top += 7;
                mbr_bullet_2.Top += 7;

            }

            if(mbr_bullet_1.Top >= 600)
            {
                mbr_bullet_1.Top = 136;
                mbr_bullet_1.Left = random.Next(100, 280);
            }

            if (mbr_bullet_2.Top >= 600)
            {
                mbr_bullet_2.Top = 136;
                mbr_bullet_2.Left = random.Next(309, 488);
            }


            if (mega_bos_rejim == true)
            {
                panel1.Visible = true;
            }

            if (panel2.Width <= 1)
            {

                label1.Text = "You Won";
                enemy_3.Top -= 2;
                mega_bos_rejim = false;
                panel1.Visible = false;
                enemy_speed = 7;
                enemy_1.Top = -300;
                enemy_2.Top = -300;
                panel1.Top -= 2;
                mbr_bullet_1.Top += 0;
                mbr_bullet_2.Top += 0;
                mbr_bullet_1.Top = -300;
                mbr_bullet_2.Top = -300;
                mbr_bullet_1.Visible = false;
                mbr_bullet_2.Visible = false;


            }
        }

        void mbr()
        {
            enemy_3.Visible = true;
            enemy_speed = -3;
         
            enemy_1.Visible = false;
            enemy_2.Visible = false;

            mega_bos_rejim = true;

            



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mbr_bullet_2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset_game();
        }

        private void iskeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                go_right = true;

            }
            if (e.KeyCode == Keys.A)
            {
                go_left = true;

            }

            if (e.KeyCode == Keys.Enter)
            {
                if(is_game_over == true)
                {
                    reset_game();
                }
                

            }
        }

        private void iskeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                go_right = false;

            }
            if (e.KeyCode == Keys.A)
            {
                go_left = false;

            }

            if(e.KeyCode == Keys.Space && shooting == false && is_game_over == false)
            {
                shooting = true;

                bullet.Top = Player.Top - 50;
                bullet.Left = Player.Left + (Player.Width / 2) - 8;
                bullet.Visible = true;
            }
        }

        void game_over()
        {
            timer1.Stop();
            label1.Text = "Game Over";
            is_game_over = true;
            panel1.Visible = false;

           

        }
    }
}
