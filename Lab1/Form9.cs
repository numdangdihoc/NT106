using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class FormReadNumAdvance : Form
    {
        public FormReadNumAdvance()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            string[] Ones = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
            string[] Tens = { "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            if (Check())
            {
                string strNum = txt_input.Text;
                int intNum = int.Parse(txt_input.Text);
                string strWords = "";
                if (intNum >= 10000 && intNum < 100000)
                {
                    int i = intNum / 1000;
                    if (i % 10 == 0)
                    {
                        strWords = strWords + Tens[i / 10 - 1] + " ngàn, ";
                    }
                    else
                    {
                        strWords = strWords + Tens[i / 10 - 1] + " ";
                        i = i % 10;
                        strWords = strWords + Ones[i] + " ngàn ";
                    }
                    intNum = intNum % 10000;
                }
                if (intNum > 999 && intNum < 10000 && !(int.Parse(txt_input.Text) >= 10000))
                {
                    int i = intNum / 1000;
                    strWords = strWords + Ones[i] + " ngàn, ";
                    intNum = intNum % 1000;
                }
                else
                {
                    intNum = intNum % 1000;
                }


                if (intNum > 99 && intNum < 1000)
                {
                    int i = intNum / 100;
                    strWords = strWords + Ones[i] + " trăm ";
                    intNum = intNum % 100;
                }
                char tmp = strNum[0];
                if (strNum.Length > 2)
                {

                    int index = strNum.Length - 3;
                    tmp = strNum[index];
                }
                bool check_hundred = false;
                if (intNum > 19 && intNum < 100)
                {
                    if (tmp == (char)48)
                    {
                        strWords += "không trăm ";
                        check_hundred = true;
                    }

                    int i = intNum / 10;
                    strWords = strWords + Tens[i - 1] + " ";

                    intNum = intNum % 10;
                }

                if (intNum > 0 && intNum < 20)
                {
                    if (tmp == (char)48 && check_hundred == false)
                    {
                        strWords += "không trăm ";
                        check_hundred = true;
                    }
                    if (strNum.Length > 2)
                    {
                        tmp = strNum[strNum.Length - 2];
                    }
                    char tmp2 = strNum[strNum.Length - 1];
                    if (tmp == (char)48 && !(tmp2 == (char)48))
                    {
                        strWords += "linh " + Ones[intNum];
                    }
                    else
                    {
                        strWords = strWords + Ones[intNum];
                    }
                }
                if (int.Parse(strNum) == 0)
                {
                    strWords += Ones[0];
                }

                txt_result.Text = strWords.ToString();
            }
        }
        private bool Check()
        {
            if (txt_input.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập gì cả, vui lòng nhập lại!");
                return false;
            }

            if (!int.TryParse(txt_input.Text, out int test))
            {
                MessageBox.Show("Số nhập không hợp lệ, xin vui lòng nhập lại!");
                return false;

            }
            if (int.Parse(txt_input.Text) < 0 || int.Parse(txt_input.Text) >= 100000)
            {
                MessageBox.Show("Số đã nhập quá giới hạn yêu cầu!");
                return false;
            }
            return true;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_result.Text = string.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
