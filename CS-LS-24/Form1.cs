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
using System.Net;
using Newtonsoft.Json;

namespace CS_LS_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string esiminch = File.ReadAllText("C:/Barev/json2.json");

            var myjson = JsonConvert.DeserializeObject <List<Esiminch>>(esiminch);

            WebRequest MyReq = WebRequest.Create(myjson[0].img);

            HttpWebResponse myresp = (HttpWebResponse)MyReq.GetResponse();
            Stream datastr = myresp.GetResponseStream();
            pictureBox1.Image = Bitmap.FromStream(datastr);
        }
    }
}
