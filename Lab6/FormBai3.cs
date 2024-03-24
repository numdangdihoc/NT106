using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            FormServer sv = new FormServer();
            sv.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormClient clt = new FormClient();
            clt.Show();
        }
    }
}
