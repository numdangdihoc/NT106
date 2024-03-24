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
    public partial class FormCalc2int : Form
    {
        public FormCalc2int()
        {
            InitializeComponent();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            int numA, numB;

            if (Check())
            {
                numA = int.Parse(tx_A.Text);
                numB = int.Parse(tx_B.Text);
                tx_res.Text = "A! = " + Giai_Thua(numA).ToString() + "\r\t" + "B! = " + Giai_Thua(numB).ToString();
                tx_res.Text += "\r\n\r\n" + "S1 = 1+2+3+4+...+A= " + SumTo(numA).ToString() + "\r\nS2 = 1+2+3+4+...+B = " + SumTo(numB).ToString();
                tx_res.Text += "\r\nS3 = A^1 + A^2 + A^3 +A^4 + ...+ A^B = " + SquareTo(numA, numB).ToString();

            }
        }
        private bool Check()
        {
            int ketqua, test;
            if (!((int.TryParse(tx_A.Text, out ketqua) && (int.TryParse(tx_B.Text, out ketqua)) && (int.Parse(tx_A.Text) > 0 && (int.Parse(tx_B.Text) > 0)))))
            {
                MessageBox.Show("Nhập sai định dạng, vui lòng nhập lại!");
                return false;
            }
            return true;
        }
        private int Giai_Thua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
        private int SumTo(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        private int SquareTo(int a, int b)
        {
            int res = 0;
            for (int i = 1; i <= b; i++)
            {
                res += POW(a, i);
            }


            return res;

        }
        public static int POW(int num, int exp)
        {
            int res = 1;
            int i;
            for (i = 1; i <= exp; i++)
                res = res * num;
            return res;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            tx_A.Text = tx_B.Text = tx_res.Text = string.Empty;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
