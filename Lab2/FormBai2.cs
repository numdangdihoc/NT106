using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btn_readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != null)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);
                richTextBox1.Text = reader.ReadToEnd();
                reader.BaseStream.Position = 0; //đặt lại vị trí
                reader.DiscardBufferedData(); // xóa bỏ dữ liệu trong bộ đệm


                int lineCount = 0;
                // đếm số dòng
                while (reader.ReadLine() != null)
                {
                    lineCount++;

                }
                txt_linecount.Text = lineCount.ToString(); // linecount
                // gán text = richtextbox1
                string text = richTextBox1.Text;
                char[] Chr_phancach = new char[] { ' ', '\r', '\n' }; // một mảng char gồm các từ phân cách words
                int wordCount = text.Split(Chr_phancach, StringSplitOptions.RemoveEmptyEntries).Length; // split các word, loại bỏ các chuỗi rỗng => trả về length
                txt_wordcount.Text = wordCount.ToString();

                txt_fileName.Text = openFileDialog.SafeFileName; // filename
                txt_url.Text = openFileDialog.FileName; // url 
                txt_size.Text = txt_charactercount.Text = fileStream.Length.ToString(); // size của file = char của file
                fileStream.Close();

            }
        }
    }
}
