using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace CS_LS_25
{

    class Mard
    {
        public string anun;
        public string gender;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverurl = "https://gorest.co.in/public/v2/";
            string key = "users";

            WebRequest Myreq = WebRequest.Create(serverurl + key);
            HttpWebResponse myRespons = (HttpWebResponse)Myreq.GetResponse();

            StreamReader jss = new StreamReader(myRespons.GetResponseStream());
            string jst = jss.ReadToEnd();

            jss.Close();
            myRespons.Close();

            var myJson = JsonConvert.DeserializeObject<List<Users>>(jst);

            label1.Text = myJson[0].name + " : " + myJson[0].gender;

            Mard newmard = new Mard();

            newmard.anun = myJson[0].name;
            newmard.gender = myJson[1].gender;

            label1.Text = newmard.anun + " " + newmard.gender;
             
        }

        
    }
}
