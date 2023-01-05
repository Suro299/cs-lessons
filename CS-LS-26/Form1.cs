using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace CS_LS_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://gorest.co.in/public/v2/";
            string key = "users";

            WebRequest req = WebRequest.Create(url + key);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader data = new StreamReader(res.GetResponseStream());
            string jt = data.ReadToEnd();

            var js = JsonConvert.DeserializeObject<List<Users>>(jt);

            for (int i = 0; i < js.Count; i++)
            {
                if (js[i].gen == "male")
                {
                    listBox1.Items.Add(js[i].name);
                    listBox1.Items.Add(js[i].email);
                }


            }

            res.Close();

            data.Close();
        }
    }
}
