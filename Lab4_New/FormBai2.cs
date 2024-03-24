using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_New
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
            //txtUrl.Text = "http://www.contoso.com/PostAccepter.aspx";
            txtUrl.Text = "https://reqres.in/api/register";
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            HttpClient httpCLient = new HttpClient();
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("email", "eve.holt@reqres.in");
            values.Add("password", "pistol");

            var content = new FormUrlEncodedContent(values);
            var response = httpCLient.PostAsync(txtUrl.Text, content);
            var responeFromServer = response.Result.Content.ReadAsStringAsync().Result;
            richTextBox1.Text = responeFromServer;
        }
    }
}
