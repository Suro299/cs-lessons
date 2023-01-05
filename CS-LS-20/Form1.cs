using System;
using System.Windows.Forms;

namespace CS_LS_20
{


    public partial class Form1 : Form
    {

        int quest = 1;
        int rightA = 2;
        int hash = 0;


        void rand()
        {
            Random rnd = new Random();
            quest = rnd.Next();
        }


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genquest(quest);
        }

        private void CheckA(object sender, EventArgs e)
        {
            var esiminchobject = (Button)sender;
            int tag = Convert.ToInt32(esiminchobject.Tag);

            if (tag == rightA)
            {

                quest++;
                hash++;
                
                genquest(quest);

                progressBar1.Value += 10;


            }
            else
            {
                MessageBox.Show("Chura", "esim inch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        public void genquest(int num)
        {

            if (num > 10)
            {             
                //MessageBox.Show("Du havaqecir ==> " + hash.ToString() + " Ball", "esim inch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (num)
            {
                case 1:


                    label1.Text = "Erb e stextve Hayastani hanrapetutyan@";
                    button1.Text = "1910 Maisi 35";
                    button2.Text = "1918 maisi 21";
                    button3.Text = "Barev Ape";
                    button4.Text = "Chem asi";



                    rightA = 2;

                    break;

                case 2:


                    label1.Text = "Erb e Karucvel Erevan qaxaq@";
                    button1.Text = "mta 153";
                    button2.Text = "mta 351";
                    button3.Text = "chem asi";
                    button4.Text = "mta 782";



                    rightA = 4;

                    break;

                case 3:


                    label1.Text = "Erb e Karavarel Tigram M. Tagavor@";
                    button1.Text = "mta 125";
                    button2.Text = "mta 300";
                    button3.Text = "mt 12";
                    button4.Text = "mta 95";


                    rightA = 4;

                    break;


                case 4:


                    label1.Text = "Erb e sks Sardaramarti Herosamart@";
                    button1.Text = "1918";
                    button2.Text = "1950";
                    button3.Text = "1910";
                    button4.Text = "2085";



                    rightA = 1;

                    break;

                case 5:


                    label1.Text = "Erb e avartve Erkrord hamarsharhain Paterazm@ \n ev erb e tnve  Karoi Tatii maman";
                    button1.Text = "卐";
                    button2.Text = "1045";
                    button3.Text = "卐";
                    button4.Text = "卐";



                    rightA = 2;

                    break;

                case 6:


                    label1.Text = "ppzat napasstak vonc a ruserenq (@ S. Arzoyan)";
                    button1.Text = "Chem asi";
                    button2.Text = "Lava";
                    button3.Text = "Barev";
                    button4.Text = "Ha";



                    rightA = 2;

                    break;

                case 7:


                    label1.Text = "Erb a tvne Geyb@ (@ K. Andryan)";
                    button1.Text = "Et ova";
                    button2.Text = "Mi or";
                    button3.Text = "Chem asi";
                    button4.Text = "MTA 700 Petrvari 31 ";



                    rightA = 4;

                    break;

                case 8:


                    label1.Text = "Suron Karoin xexdi ?";
                    button1.Text = "che";
                    button2.Text = "che";
                    button3.Text = "Che";
                    button4.Text = "ha";



                    rightA = 4;

                    break;

                case 9:


                    label1.Text = "Saqoi anun@ inch a";
                    button1.Text = "Saqo";
                    button2.Text = "Suro";
                    button3.Text = "Karen";
                    button4.Text = "Arman";



                    rightA = 1;

                    break;

                case 10:


                    label1.Text = "barev";
                    button1.Text = "barev";
                    button2.Text = "hajox";
                    button3.Text = "ha";
                    button4.Text = "Sur Sur Sur";



                    rightA = 1;

                    break;
            }
        }
    }
}
