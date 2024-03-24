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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FormBai1 frm1 = new FormBai1();
            frm1.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FormBai2 frm2 = new FormBai2();
            frm2.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FormBai3 frm3 = new FormBai3();
            frm3.ShowDialog();
        }
    }
}
