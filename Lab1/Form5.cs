using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormPetro : Form
    {
        List<string> List_loaixe = new List<string>() { "Chọn", "Wave Alpha", "Sirius", "Vision", "Lead", "Winner", "AirBlade 150", "Xe tải 9 tấn" };
        List<string> List_loaixang = new List<string>() { "Chọn", "RON 95-III", "E5 RON 92-II", "DO 0,05S-II" };
        float[] WA, SR, VS, LD, WN, AB, XT;


        public FormPetro()
        {
            InitializeComponent();
            //Public:

            WA = new float[2] { 1.6F, 3.7F };
            SR = new float[2] { 1.99F, 3.8F };
            VS = new float[2] { 1.87F, 5.2F };
            LD = new float[2] { 2.2F, 6.0F };
            WN = new float[2] { 1.7F, 4.5F };
            AB = new float[2] { 2.17F, 4.4F };
            XT = new float[2] { 13F, 70F };
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmb_loaixe.DataSource = List_loaixe;
            cmb_loaixang.DataSource = List_loaixang;


        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (Check())
            {
                So_Tien_Tra();
                So_Km();

            }

        }


        private bool Check()
        {
            if (cmb_loaixe.Text == "Chọn" || cmb_loaixang.Text == "Chọn")
            {
                MessageBox.Show("Bạn chưa chọn gì, vui lòng lựa chọn!!");
                return false;
            }
            else
            {
                if (cmb_loaixe.Text == "Wave Alpha" || cmb_loaixe.Text == "Sirius" || cmb_loaixe.Text == "Vision")
                {
                    if (cmb_loaixang.Text == "DO 0,05S-II")
                    {
                        MessageBox.Show("Xe này không thể đổ loại xăng/dầu này được huhu!");
                        return false;
                    }
                }
                if (cmb_loaixe.Text == "Lead" || cmb_loaixe.Text == "Winner" || cmb_loaixe.Text == "AirBlade 150")
                {
                    if (cmb_loaixang.Text != "RON 95-III")
                    {
                        MessageBox.Show("Xe này không thể đổ loại xăng/dầu này được huhu!");
                        return false;
                    }
                }
                if (cmb_loaixe.Text == "Xe tải 9 tấn")
                {
                    if (cmb_loaixang.Text != "DO 0,05S-II")
                    {
                        MessageBox.Show("Xe này không thể đổ loại xăng/dầu này được huhu!");
                        return false;
                    }
                }
            }
            return true;
        }
        private float So_Tien_Tra()
        {
            float r95, r92, dauDo;
            r95 = 26830F;
            r92 = 26070F;
            dauDo = 21310F;
            if (cmb_loaixang.Text == "RON 95-III")
            {

                switch (cmb_loaixe.SelectedIndex)
                {
                    case 1:
                        tx_Money.Text = (r95 * WA[1]).ToString();
                        break;
                    case 2:
                        tx_Money.Text = (r95 * SR[1]).ToString();
                        break;
                    case 3:
                        tx_Money.Text = (r95 * VS[1]).ToString();
                        break;
                    case 4:
                        tx_Money.Text = (r95 * LD[1]).ToString();
                        break;
                    case 5:
                        tx_Money.Text = (r95 * WN[1]).ToString();
                        break;
                    case 6:
                        tx_Money.Text = (r95 * AB[1]).ToString();
                        break;


                }
            }
            if (cmb_loaixang.Text == "E5 RON 92-II")
            {
                switch (cmb_loaixe.SelectedIndex)
                {
                    case 1:
                        tx_Money.Text = (r92 * WA[1]).ToString();
                        break;
                    case 2:
                        tx_Money.Text = (r92 * SR[1]).ToString();
                        break;
                    case 3:
                        tx_Money.Text = (r92 * VS[1]).ToString();
                        break;
                }
            }
            if (cmb_loaixang.Text == "DO 0,05S-II")
            {
                if (cmb_loaixe.Text == "Xe tải 9 tấn")
                {
                    tx_Money.Text = (dauDo * XT[1]).ToString();
                }

            }
            return 0;
        }
        private float So_Km()
        {
            switch (cmb_loaixe.SelectedIndex)
            {
                case 1:
                    tx_Km_Go.Text = ((WA[1] * 100) / WA[0]).ToString();
                    break;
                case 2:
                    tx_Km_Go.Text = ((SR[1] * 100) / SR[0]).ToString();
                    break;
                case 3:
                    tx_Km_Go.Text = ((VS[1] * 100) / VS[0]).ToString();
                    break;
                case 4:
                    tx_Km_Go.Text = ((LD[1] * 100) / LD[0]).ToString();
                    break;
                case 5:
                    tx_Km_Go.Text = ((WN[1] * 100) / WN[0]).ToString();
                    break;
                case 6:
                    tx_Km_Go.Text = ((AB[1] * 100) / AB[0]).ToString();
                    break;
                case 7:
                    tx_Km_Go.Text = ((XT[1] * 100) / XT[0]).ToString();
                    break;
            }
            return 0;
        }

        private void btn_DEL_Click(object sender, EventArgs e)
        {
            tx_Km_Go.Text = string.Empty;
            tx_Money.Text = string.Empty;
            cmb_loaixang.SelectedIndex = 0;
            cmb_loaixe.SelectedIndex = 0;
        }
    }
}
