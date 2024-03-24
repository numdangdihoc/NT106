using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormSum2num : Form
    {
        public FormSum2num()
        {
            InitializeComponent();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int result, so1, so2;
                so1 = int.Parse(txt_so1.Text);
                so2 = int.Parse(txt_so2.Text);
                result = so1 + so2;
                txt_result.Text = result.ToString();
            }

        }
        private bool Check()
        {
            if (txt_so1.Text == "" || txt_so2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ!");
                return false;
            }
            if (!int.TryParse(txt_so1.Text, out int test) || !int.TryParse(txt_so2.Text, out int test2))
            {
                MessageBox.Show("Số nhập bị lỗi!");
                return false;
            }

            return true;

        }


    }
}
