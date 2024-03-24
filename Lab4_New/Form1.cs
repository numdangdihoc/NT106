using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBai1 bai1 = new FormBai1();
            bai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBai2 bai2 = new FormBai2();
            bai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBai3 bai3 = new FormBai3();
            bai3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBai4 bai4 = new FormBai4("https://google.com");
            bai4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBai5 bai5 = new FormBai5();
            bai5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBai6 bai6 = new FormBai6();
            bai6.ShowDialog();
        }
    }
}
