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
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            FormBai1_Client client = new FormBai1_Client();
            client.Show();
        }

        private void UDP_Server_Click(object sender, EventArgs e)
        {
            FormBai1_Server server = new FormBai1_Server();
            server.Show();
        }
    }
}
