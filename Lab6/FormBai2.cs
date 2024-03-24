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
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text.ToUpper();
            rtbCipher.Text= Encrypt(rtbPlaintext.Text, key);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text.ToUpper();
            rtbDec.Text = Decrypt(rtbCipher.Text,key);
        }
        //
        string Encrypt(string text, string key)
        {
            string encrypted_text = "";
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsLetter(ch))
                {
                    ch = char.ToUpper(ch);
                    ch = (char)((ch + key[j] - (2 * 'A')) % 26 + 'A'); // (plaintext+key) mod 26 = ciphertext
                    j = (j + 1) % key.Length; // lấy char key tiếp theo, nếu hết thì lặp lại
                }
                encrypted_text += ch;
            }
            return encrypted_text;
        }
        //
        string Decrypt(string text, string key)
        {
            string decrypted_text = "";
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsLetter(ch))
                {
                    ch = char.ToUpper(ch);
                    ch = (char)((ch - key[j] + 26) % 26 + 'A'); // (ciphertext-key)mod26 = plaintext
                    j = (j + 1) % key.Length;
                }
                decrypted_text += ch;
            }
            return decrypted_text;
        }

        //

    }
}
