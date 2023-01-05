
namespace CS_LS_28
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
            this.Trchun = new System.Windows.Forms.PictureBox();
            this.nerqevi_truba = new System.Windows.Forms.PictureBox();
            this.verevi_truba = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.graund = new System.Windows.Forms.Panel();
            this.OCH = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Trchun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerqevi_truba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verevi_truba)).BeginInit();
            this.SuspendLayout();
            // 
            // Trchun
            // 
            this.Trchun.BackColor = System.Drawing.Color.Transparent;
            this.Trchun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Trchun.BackgroundImage")));
            this.Trchun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Trchun.Location = new System.Drawing.Point(65, 239);
            this.Trchun.Name = "Trchun";
            this.Trchun.Size = new System.Drawing.Size(71, 51);
            this.Trchun.TabIndex = 0;
            this.Trchun.TabStop = false;
            // 
            // nerqevi_truba
            // 
            this.nerqevi_truba.BackColor = System.Drawing.Color.Transparent;
            this.nerqevi_truba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nerqevi_truba.BackgroundImage")));
            this.nerqevi_truba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nerqevi_truba.Location = new System.Drawing.Point(981, 355);
            this.nerqevi_truba.Name = "nerqevi_truba";
            this.nerqevi_truba.Size = new System.Drawing.Size(125, 256);
            this.nerqevi_truba.TabIndex = 2;
            this.nerqevi_truba.TabStop = false;
            // 
            // verevi_truba
            // 
            this.verevi_truba.BackColor = System.Drawing.Color.Transparent;
            this.verevi_truba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verevi_truba.BackgroundImage")));
            this.verevi_truba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verevi_truba.Location = new System.Drawing.Point(981, -79);
            this.verevi_truba.Name = "verevi_truba";
            this.verevi_truba.Size = new System.Drawing.Size(125, 256);
            this.verevi_truba.TabIndex = 3;
            this.verevi_truba.TabStop = false;
            this.verevi_truba.Click += new System.EventHandler(this.verevi_truba_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timerfunc);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Russo One", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: 0";
            // 
            // graund
            // 
            this.graund.BackColor = System.Drawing.Color.Transparent;
            this.graund.Location = new System.Drawing.Point(12, 494);
            this.graund.Name = "graund";
            this.graund.Size = new System.Drawing.Size(250, 89);
            this.graund.TabIndex = 5;
            this.graund.Paint += new System.Windows.Forms.PaintEventHandler(this.graund_Paint);
            // 
            // OCH
            // 
            this.OCH.BackColor = System.Drawing.Color.Transparent;
            this.OCH.Location = new System.Drawing.Point(1034, 183);
            this.OCH.Name = "OCH";
            this.OCH.Size = new System.Drawing.Size(26, 166);
            this.OCH.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 574);
            this.Controls.Add(this.Trchun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nerqevi_truba);
            this.Controls.Add(this.verevi_truba);
            this.Controls.Add(this.graund);
            this.Controls.Add(this.OCH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.Trchun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerqevi_truba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verevi_truba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Trchun;
        private System.Windows.Forms.PictureBox nerqevi_truba;
        private System.Windows.Forms.PictureBox verevi_truba;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel graund;
        private System.Windows.Forms.Panel OCH;
    }
}

