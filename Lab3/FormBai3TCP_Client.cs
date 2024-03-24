using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class FormBai3TCP_Client : Form
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream stream;

        public FormBai3TCP_Client()
        {
            InitializeComponent();
        }

        private void btn_Con_Click(object sender, EventArgs e)
        {
            // khoi tao ket noi


            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEndpoint = new IPEndPoint(iPAddress, 8080);
            tcpClient.Connect(iPEndpoint);
            stream = tcpClient.GetStream();

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(str+ "\n");
            this.stream.Write(data, 0, data.Length);
            richTextBox1.Text = string.Empty;
        }

        private void btn_discon_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("quit\n");
            stream.Write(data, 0, data.Length);
            stream.Close();
            tcpClient.Close(); 

        }
    }
}
