using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab6
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
            tbShift.Text = "11";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = rtbPlaintext.Text;
            char[] enc_data = new char[plaintext.Length];
            int key = int.Parse(tbShift.Text);
            for (int i = 0; i < plaintext.Length; i++)
            {

                if ((plaintext[i] >= 'A' && plaintext[i] <= 'Z') || (plaintext[i] >= 'a' && plaintext[i] <= 'z'))
                {
                    if (plaintext[i] >= 'A' && plaintext[i] <= 'Z') // chuyển chữ hoa -> hoa
                    {
                        char index = (char)(plaintext[i] - 'A'); // lấy thứ tự trong bảng chữ cái 
                        index = (char)((index + key) % 26); // CT = (PT+key )%26
                        index += 'A'; // chuyển về index stt alphabet về char bằng cách cộng A
                        enc_data[i] = index; // gán vào từng từ 1
                    }
                    else
                    {
                        char index = (char)(plaintext[i] - 'a'); // thường -> thường
                        index = (char)((index + key) % 26); // tương tự
                        index += 'a'; //tương tự
                        enc_data[i] = index;
                    }
                }
                else
                {
                    enc_data[i] = plaintext[i];
                }

            }
            rtbCipher.Text = new string(enc_data);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = rtbCipher.Text;
            char[] plain = new char[ciphertext.Length];
            int key = int.Parse(tbShift.Text);
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if ((ciphertext[i] >= 'A' && ciphertext[i] <= 'Z') || (ciphertext[i] >= 'a' && ciphertext[i] <= 'z'))
                {
                    if (ciphertext[i] >= 'A' && ciphertext[i] <= 'Z')
                    {
                        char index = (char)(ciphertext[i] - 'A');
                        index = (char)((index - key + 26) % 26);
                        index += 'A';
                        plain[i] = index;
                    }
                    else
                    {
                        char index = (char)(ciphertext[i] - 'a');
                        index = (char)((index - key + 26) % 26);
                        index += 'a';
                        plain[i] = index;
                    }
                }
                else
                {
                    plain[i] = ciphertext[i]; // Giữ nguyên các ký tự không thuộc bảng chữ cái
                }
            }
            rtbDec.Text = new string(plain);

        }
    }
}
