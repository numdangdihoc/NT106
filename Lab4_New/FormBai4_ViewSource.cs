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
    public partial class FormBai4_ViewSource : Form
    {
        public FormBai4_ViewSource(string url)
        {
            InitializeComponent();
            try
            {
                richTextBox1.Text = getHTML(url);
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

    }
}
