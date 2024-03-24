using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class FormMain_Bai3 : Form
    {
        public FormMain_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form tcp_server = new FormBai3TCP_Server();
            tcp_server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tcp_client = new FormBai3TCP_Client();
            tcp_client.Show();
        }
    }
}
