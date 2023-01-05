
namespace CS_LS_30
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.enemy_2 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy_3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mbr_bullet_1 = new System.Windows.Forms.PictureBox();
            this.mbr_bullet_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbr_bullet_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbr_bullet_2)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player.BackgroundImage")));
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player.Location = new System.Drawing.Point(242, 555);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(106, 150);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.Color.Transparent;
            this.enemy_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_1.BackgroundImage")));
            this.enemy_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_1.Location = new System.Drawing.Point(201, 24);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(90, 130);
            this.enemy_1.TabIndex = 1;
            this.enemy_1.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy_2.BackColor = System.Drawing.Color.Transparent;
            this.enemy_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_2.BackgroundImage")));
            this.enemy_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_2.Location = new System.Drawing.Point(511, 24);
            this.enemy_2.Name = "enemy_2";
            this.enemy_2.Size = new System.Drawing.Size(90, 130);
            this.enemy_2.TabIndex = 2;
            this.enemy_2.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bullet.BackgroundImage")));
            this.bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bullet.Location = new System.Drawing.Point(700, 418);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(17, 41);
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            this.bullet.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.tick);
            // 
            // enemy_3
            // 
            this.enemy_3.BackColor = System.Drawing.Color.Transparent;
            this.enemy_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy_3.BackgroundImage")));
            this.enemy_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy_3.Location = new System.Drawing.Point(85, -210);
            this.enemy_3.Name = "enemy_3";
            this.enemy_3.Size = new System.Drawing.Size(407, 208);
            this.enemy_3.TabIndex = 5;
            this.enemy_3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(173, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 23);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 17);
            this.panel2.TabIndex = 7;
            // 
            // mbr_bullet_1
            // 
            this.mbr_bullet_1.BackColor = System.Drawing.Color.Transparent;
            this.mbr_bullet_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbr_bullet_1.BackgroundImage")));
            this.mbr_bullet_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbr_bullet_1.Location = new System.Drawing.Point(121, 24);
            this.mbr_bullet_1.Name = "mbr_bullet_1";
            this.mbr_bullet_1.Size = new System.Drawing.Size(10, 41);
            this.mbr_bullet_1.TabIndex = 7;
            this.mbr_bullet_1.TabStop = false;
            this.mbr_bullet_1.Visible = false;
            // 
            // mbr_bullet_2
            // 
            this.mbr_bullet_2.BackColor = System.Drawing.Color.Transparent;
            this.mbr_bullet_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbr_bullet_2.BackgroundImage")));
            this.mbr_bullet_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mbr_bullet_2.Location = new System.Drawing.Point(488, 24);
            this.mbr_bullet_2.Name = "mbr_bullet_2";
            this.mbr_bullet_2.Size = new System.Drawing.Size(17, 41);
            this.mbr_bullet_2.TabIndex = 8;
            this.mbr_bullet_2.TabStop = false;
            this.mbr_bullet_2.Visible = false;
            this.mbr_bullet_2.Click += new System.EventHandler(this.mbr_bullet_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mbr_bullet_1);
            this.Controls.Add(this.enemy_3);
            this.Controls.Add(this.mbr_bullet_2);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemy_2);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.Player);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iskeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.iskeyup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mbr_bullet_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbr_bullet_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox enemy_2;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy_3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox mbr_bullet_1;
        private System.Windows.Forms.PictureBox mbr_bullet_2;
    }
}

