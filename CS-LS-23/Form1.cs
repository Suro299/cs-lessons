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
using Newtonsoft.Json;
using System.Net;

namespace CS_LS_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ha = File.ReadAllText("C:/Barev/json1.json");
            var myjson = JsonConvert.DeserializeObject<List<Esiminch>>(ha);

            WebRequest myreq = WebRequest.Create(myjson[1].url);
            HttpWebResponse myrespons = (HttpWebResponse)myreq.GetResponse();

            Stream datastram = myrespons.GetResponseStream();
            StreamReader myReader = new StreamReader(datastram);
            string myString = myReader.ReadToEnd();
            richTextBox1.Text = myString;
            myrespons.Close();
            datastram.Close();
            myReader.Close();
        }
    }
}
