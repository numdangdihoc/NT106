using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_New
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
            txtFileUrl.Text = "C:\\Users\\DELL\\Downloads\\";
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            Stream respone = myClient.OpenRead(txtUrl.Text);
            StreamReader sr = new StreamReader(respone);

            string responeFromServer = sr.ReadToEnd();
            richTextBox1.Text = responeFromServer;
            //read to file
            try
            {
                myClient.DownloadFile(txtUrl.Text, txtFileUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
