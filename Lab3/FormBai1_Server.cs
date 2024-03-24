using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class FormBai1_Server : Form
    {
        public FormBai1_Server()
        {

            InitializeComponent();
            txt_port.Text = "8080";


        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread udpServerThread = new Thread(new ThreadStart(ServerThread));
            udpServerThread.Start();
            udpServerThread.IsBackground = true;
        }
        public void ServerThread()
        {

            UdpClient udpClient = new UdpClient(int.Parse(txt_port.Text));
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {

                Byte[] receivedBytes = udpClient.Receive(ref remoteEndPoint);

                string mesg = Encoding.UTF8.GetString(receivedBytes);
                string str = remoteEndPoint.Address.ToString();
                richTextBox1.Text += str + ":";
                richTextBox1.Text += mesg + "\r\n";

            }
        }
    }
}
