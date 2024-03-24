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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_New
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
            txtUrl.Text += "https://";
        }

        private void bntGet_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = getHTML(txtUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private string getHTML(string szUrl)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szUrl);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntGet.PerformClick();
            }
        }
    }
}
