using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class FormBai1_Client : Form
    {
        public FormBai1_Client()
        {
            InitializeComponent();
            txt_IP.Text = "127.0.0.1";
            txt_Port.Text = "8080";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            string str = richTextBox1.Text;
            Byte[] sendBytes = Encoding.UTF8.GetBytes(str);
            udpClient.Send(sendBytes, sendBytes.Length, txt_IP.Text, int.Parse(txt_Port.Text));
            richTextBox1.Text = string.Empty;
        }
    }
}
