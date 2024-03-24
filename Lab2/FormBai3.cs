using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Lab2
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
            btn_savefile.Enabled = false;
            btn_Calc.Enabled = false;
        }


        private void btn_inputFile_Click(object sender, EventArgs e)
        {
            // đoạn code chỉ để đọc file 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != null)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);
                richTextBox1.Text = "\r\n";
                richTextBox1.Text += reader.ReadToEnd();
                fileStream.Close();
            }
            btn_inputFile.Enabled = false; // ẩn btn input đi
            btn_Calc.Enabled = true; // bật btn Calc lên để tính toán

        }
        private void btn_Calc_Click(object sender, EventArgs e)
        {
            // trên các dòng lấy  string biểu thức tính toán
            string[] lines = richTextBox1.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            // tạo mảng string results để save "biểu thức" "=" "đáp án tính được"
            string[] results = new string[lines.Length];
            richTextBox2.Text += "\r\n";

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                double result = EvaluateExpression(line); // gán kết quả 
                results[i] = $"{line} = {result}"; // mảng string results[i] gồm biểu thức toán học = kết quả
                richTextBox2.Text += results[i].ToString() + "\r\n";

            }
            btn_Calc.Enabled = false; // khi tính toán xong thì Calc bị ẩn đi
            btn_savefile.Enabled = true; // nút save file được bật lên để lưu nội dung đó vào 1 file 

        }
        private void btn_savefile_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(filePath); // dùng streamwriter vì binarywritwer nó thêm kí tự khác vào đầu file output => xấu :(((

                if (richTextBox2.Lines.Length > 0)
                {
                    richTextBox2.Lines = richTextBox2.Lines.Skip(1).ToArray(); // Xóa dòng đầu tiên(lúc trước thêm \n cho đẹp) của richtextbox2
                }

                string str = richTextBox2.Text;
                writer.Write(str);
                writer.Close();
                btn_savefile.Enabled = false;

            }
        }
        private double EvaluateExpression(string expression)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();  // kiểu dl có thể đánh giá biểu thức
                table.Columns.Add("expression", typeof(string), expression); // add 1 cột tên là expresssion và gtri là expression
                System.Data.DataRow row = table.NewRow(); // tạo 1 row
                table.Rows.Add(row);
                double result = double.Parse((string)row["expression"]); //Parse kết quả chuỗi biểu thức
                string format_result = result.ToString("F2");
                return double.Parse(format_result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình tính toán: {ex.Message}");
                return 0;
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox2.Text = string.Empty;
            btn_inputFile.Enabled = true;
            btn_savefile.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

