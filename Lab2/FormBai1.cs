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
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        private void btn_readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";
            openFileDialog.ShowDialog();
            //đọc file
            if (openFileDialog.FileName != null)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);
                richTextBox1.Text = reader.ReadToEnd(); // ghi vào richtextbox1
               fileStream.Close();
            }



        }

        private void btn_writefile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output2.txt";
            saveFileDialog.Filter = "Text File|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate); // ghi file tạo mới hoặc đè lên file cũ
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                string str = richTextBox1.Text; 
                str = str.ToUpper(); // viết in hoa các từ
                binaryWriter.Write(str);
                binaryWriter.Close();
                fileStream.Close();
            }
        }
    }
}
