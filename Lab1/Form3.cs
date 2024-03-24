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
    public partial class FormMaxMin : Form
    {
        public FormMaxMin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[] arr;
            arr = new float[3];

            if (Check())
            {

                arr[0] = float.Parse(tx_so1.Text.Trim());
                arr[1] = float.Parse((tx_so2.Text.Trim()));
                arr[2] = float.Parse(tx_so3.Text.Trim());
                float mx = arr[0];
                float mn = arr[0];
                for (int i = 1; i < 3; i++)
                {
                    if (arr[i] > mx)
                    {
                        mx = arr[i];
                    }


                    if (arr[i] < mn)
                    {
                        mn = arr[i];
                    }
                }
                tx_res_max.Text = mx.ToString();
                tx_res_min.Text = mn.ToString();
            }

        }
        private bool Check()
        {

            float ketqua;
            string in_num1, in_num2, in_num3;
            in_num1 = tx_so1.Text;
            in_num2 = tx_so2.Text;
            in_num3 = tx_so3.Text;
            if (!(float.TryParse(in_num1, out ketqua) && float.TryParse(in_num2, out ketqua) && float.TryParse(in_num3, out ketqua)))
            {
                MessageBox.Show("Nhập sai định dạng số rồi!");
                tx_so1.Focus();
                tx_so2.Focus();
                tx_so3.Focus();

                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_so1.Text = string.Empty;
            tx_so2.Text = string.Empty;
            tx_so3.Text = string.Empty;
            tx_res_max.Text = string.Empty;
            tx_res_min.Text = string.Empty; // button xóa

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close(); // button thoát
        }


    }
}
