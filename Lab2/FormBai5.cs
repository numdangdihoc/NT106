using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab2.FormBai4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class FormBai5 : Form
    {
        public FormBai5()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "input5.txt";
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = saveFileDialog.FileName;
                txt_url.Text = file_path;
                StreamWriter writer = new StreamWriter(file_path);
                string str = richTextBox1.Text;
                writer.Write(str);
                writer.Close(); // save file hoàn tất vào với tên là input5.txt
                string startPath = @".\input5.txt"; //save ở / bin / debug / net7.0 - windows
                string zipPath = @".\output5.zip"; // tên của file zip

                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
                {
                    archive.CreateEntryFromFile(startPath, Path.GetFileName(startPath));
                }

            }

        }

        private void btn_Decompress_Click(object sender, EventArgs e)
        {
            string zipPath = @".\output5.zip"; // save ở /bin/debug/ net7.0-windows
            string extractPath = @".\output5.txt";

            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                ZipArchiveEntry entry = archive.GetEntry("input5.txt");
                entry.ExtractToFile(extractPath);
            }

        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            string filepath = @".\output5.txt"; // mở file output5.txt vừa giải nén về đọc
            FileStream fileStream = new FileStream(filepath, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            string str = reader.ReadToEnd();
            richTextBox2.Text = str;
            fileStream.Close();
        }
    }
}
