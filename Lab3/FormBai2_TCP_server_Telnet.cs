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

namespace Lab3
{
    public partial class FormBai2_TCP_server_Telnet : Form
    {
        public FormBai2_TCP_server_Telnet()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            serverThread.IsBackground = true;
        }
        private void StartUnsafeThread()
        {
            int bytesReceievd = 0;
            byte[] recv = new byte[1];

            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(txt_port.Text));
            listenerSocket.Bind(ipEndPoint);
            listenerSocket.Listen(-1);

            clientSocket = listenerSocket.Accept();
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceievd = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                richTextBox1.Text += text;
            }
            listenerSocket.Close();
        }
    }
}
