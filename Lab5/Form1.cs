using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            FormBai1 frm1 = new FormBai1();
            frm1.ShowDialog();  
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            FormBai2 frm2 = new FormBai2();
            frm2.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            FormBai4 frm4 = new FormBai4();
            frm4.ShowDialog();
        }
    }
}
