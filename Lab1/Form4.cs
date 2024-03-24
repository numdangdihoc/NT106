using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormReadNum : Form
    {
        public FormReadNum()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int num = int.Parse(textBox1.Text.Trim());
                switch (num)
                {
                    case 0:
                        tx_kq.Text = "Không";
                        break;
                    case 1:
                        tx_kq.Text = "Một";
                        break;
                    case 2:
                        tx_kq.Text = "Hai";
                        break;
                    case 3:
                        tx_kq.Text = "Ba";
                        break;
                    case 4:
                        tx_kq.Text = "Bốn";
                        break;
                    case 5:
                        tx_kq.Text = "Năm";
                        break;
                    case 6:
                        tx_kq.Text = "Sáu";
                        break;
                    case 7:
                        tx_kq.Text = "Bảy";
                        break;
                    case 8:
                        tx_kq.Text = "Tám";
                        break;
                    case 9:
                        tx_kq.Text = "Chín";
                        break;

                }
            }
        }
        private bool Check()
        {

            int ketqua;
            String num;
            num = textBox1.Text;
            if (!(int.TryParse(num, out ketqua) && (int.Parse(num) >= 0 && int.Parse(num) <= 9)))
            {
                MessageBox.Show("Nhap sai yêu cầu!");
                textBox1.Focus();
                return false;
            }
            return true;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            tx_kq.Text = string.Empty;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

            Close();
        }


    }
}
