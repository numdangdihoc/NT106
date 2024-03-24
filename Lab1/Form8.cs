using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class FormInfoSV : Form
    {
        public FormInfoSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string str = txt_input.Text;

                String[] arr = str.Trim().Split(",");
                txt_HoTen.Text = arr[0];
                //int a = int.Parse(arr[1]) + 1;
                for (int i = 1; i < arr.Length; i++)
                {
                    txt_Mark.Text += "Môn " + i.ToString() + ": " + arr[i] + "   ";
                }
                Max_Min(arr);
                float dtb = DTB(arr);
                int count_pass = 0, count_fail = 0, count65 = 0, count35 = 0, count2 = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    float temp = Format_float(float.Parse(arr[i]));
                    if (temp >= 5F)
                        count_pass++;
                    if (temp >= 5 && temp < 6.5F)
                        count65++;
                    if (temp >= 2 && temp < 3.5F)
                        count35++;
                    if (temp < 2)
                        count2++;

                }
                txt_SoMonDau.Text = count_pass.ToString();
                count_fail = (arr.Length - 1) - count_pass;
                txt_SoMonKhongDau.Text = count_fail.ToString();

                XepLoai(dtb, count_fail, count65, count35, count2);

            }
        }

        private bool Check()
        {
            string pattern = @"^([\w\s.]+)(,\s*[\w\s.]+)*$";
            bool isValid = Regex.IsMatch(txt_input.Text, pattern);
            if (!isValid)
            {
                MessageBox.Show("Định dạng sai!");
                return false;
            }
            else
            {
                string str = txt_input.Text;
                String[] arr = str.Trim().Split(",");
                if (int.TryParse(arr[0], out int test))
                {
                    MessageBox.Show("Nhập Tên sai định dạng");
                    return false;
                }
                else
                {
                    for (int i = 1; i < arr.Length; i++)
                    {
                        if (!(int.TryParse(arr[i], out int test1) || float.TryParse(arr[i], out float test2)))
                        {
                            MessageBox.Show("Giá trị điểm thứ " + i + " sai");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void Max_Min(string[] arr)
        {
            float mx, mn;
            mx = Format_float(float.Parse(arr[1]));
            mn = Format_float(float.Parse(arr[1]));
            for (int i = 2; i < arr.Length; i++)
            {
                if (Format_float(float.Parse(arr[i])) > mx)
                {
                    mx = Format_float(float.Parse(arr[i]));
                }


                if (Format_float(float.Parse(arr[i])) < mn)
                {
                    mn = Format_float(float.Parse(arr[i]));
                }
            }
            txt_max.Text = mx.ToString();
            txt_min.Text = mn.ToString();


        }

        private float DTB(string[] arr)
        {
            float sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                sum += Format_float(float.Parse(arr[i]));
            }
            float DTB = sum / (arr.Length - 1);
            txt_DTB.Text = DTB.ToString();
            return DTB;
        }
        private void XepLoai(float DTB, int count_fail, int count65, int count35, int count2)
        {
            if (DTB >= 8 && count_fail == 0 && count65 == 0)
            {
                //Giỏi
                txt_XL.Text = "Giỏi";

            }
            else if (DTB >= 6.5 && DTB < 8 && count_fail == 0 || count65 > 0)
            {
                //Khá
                txt_XL.Text = "Khá";
            }
            else if (DTB >= 5 && DTB < 6.5 && count35 == 0 || (count_fail > 0))
            {
                //TB
                txt_XL.Text = "Trung bình";

            }
            else if (DTB >= 3.5 && DTB < 5 && count2 == 0 || count35 > 0)
            {
                //Yếu
                txt_XL.Text = "Yếu";
            }
            else
            {
                //Kém
                txt_XL.Text = "Kém";
            }

        }

        private float Format_float(float x)
        {
            if (x > 10 && x <= 100)
                x /= 10;
            if (x > 100)
                x /= 100;
            return x;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            txt_HoTen.Text = txt_DTB.Text = txt_input.Text = txt_XL.Text = txt_Mark.Text = txt_max.Text = txt_min.Text = txt_SoMonDau.Text = txt_SoMonKhongDau.Text = String.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
