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
    public partial class Bai5FormMain : Form
    {
        public Bai5FormMain()
        {
            InitializeComponent();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            Form bai4_server = new Bai5_Server();
            bai4_server.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Form bai4_client = new Bai5_Client();
            bai4_client.Show();
        }
    }
}
