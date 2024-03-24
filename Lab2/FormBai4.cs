using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Lab2
{
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
            btn_back.Enabled = false;
            btn_next.Enabled = false;
        }

        [Serializable]
        public class Student
        {
            public string name { get; set; }
            public string id { get; set; }
            public string phone { get; set; }
            public float course1 { get; set; }
            public float course2 { get; set; }
            public float course3 { get; set; }
            public float average { get; set; }

        }
        // tạo kiểu List students(để save list student và serialize) và des_students để save sau khi deserialize
        public List<Student> students = new List<Student>();
        public List<Student> Des_students = new List<Student>();

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Check()) // kiểm tra điều kiện
            {
                // add từng thông tin student vào list students mỗi khi click btn_add
                students.Add(new Student()
                {
                    name = txt_nameW.Text,
                    id = txt_idW.Text,
                    phone = txt_PhoneW.Text,
                    course1 = float.Parse(txt_C1W.Text, CultureInfo.InvariantCulture),
                    course2 = float.Parse(txt_C2W.Text, CultureInfo.InvariantCulture),
                    course3 = float.Parse(txt_C3W.Text, CultureInfo.InvariantCulture)
                });
                MessageBox.Show("Add thành công !");
                UpdateRichTextBox(); // cập nhật richtextbox 
                Del_TextBoxAfterAdd(); // xóa các textbox thông tin đã add, để nhập thông tin mới
            }

        }

        private void UpdateRichTextBox() // cập nhạt textbox để xem những gì mình đã nhập
        {
            richTextBox1.Text += txt_nameW.Text + "\r\n" + txt_idW.Text + "\r\n" + txt_PhoneW.Text + "\r\n" + txt_C1W.Text + "\r\n"
                        + txt_C2W.Text + "\r\n" + txt_C3W.Text + "\r\n\n";
        }
        private void Del_TextBoxAfterAdd() // xóa các nội dung sau khi bấm Add
        {

            txt_nameW.Text = txt_idW.Text = txt_PhoneW.Text = txt_C1W.Text = txt_C2W.Text = txt_C3W.Text = string.Empty;
        }

        private object GetStudents()
        {
            return students;
        }



        private void btn_write_Click(object sender, EventArgs e)
        {
            // sau khi nhập nhiều student và muốn save:
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "input4.txt";
            saveFileDialog.Filter = "Text File|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                // dùng binary formatter 
                BinaryFormatter formatter = new BinaryFormatter();
                //serialize list students
                formatter.Serialize(fileStream, students);
                fileStream.Close();
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = File.OpenRead(filePath);
                // deserialize file đó và đưa vào list des_students
                Des_students = binaryFormatter.Deserialize(fileStream) as List<Student>;
                fileStream.Close();
                MessageBox.Show("Đọc file BinaryFormatter thành công !");

                foreach (var student in Des_students)
                {

                    student.average = (student.course1 + student.course2 + student.course3) / 3; // tính điểm trung bình từng student
                }
                // default show: sau khi đọc file thành công thì xuất ra các textbox thông tin tương ứng (mặc định stt: 1)
                label_num.Text = "1";
                Update_TextBox_Result(0);
                btn_next.Enabled = true;
                btn_back.Enabled = true;

                // ghi vào file output
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "output4.txt";
                saveFileDialog.Filter = "Text File|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file_path = saveFileDialog.FileName;
                    StreamWriter writer = new StreamWriter(file_path);
                    string str = Convert_List_To_String();
                    writer.Write(str);
                    writer.Close();

                }


            }

        }

        void Update_TextBox_Result(int index)
        {
            // gán text các textbox để xem thông tin
            txt_NameR.Text = Des_students[index].name;
            txt_idR.Text = Des_students[index].id;
            txt_PhoneR.Text = Des_students[index].phone;
            txt_C1R.Text = Des_students[index].course1.ToString();
            txt_C2R.Text = Des_students[index].course2.ToString();
            txt_C3R.Text = Des_students[index].course3.ToString();
            txt_AveR.Text = Des_students[index].average.ToString("F2");
        }
        string Convert_List_To_String()
        {
            //hàm này để chuyển list sang string cho đẹp để save vào file .txt
            string str = "";
            foreach (var student in Des_students)
            {
                str += student.name + "\n" + student.id + "\n" + student.phone + "\n" + student.course1.ToString() + "\n"
                        + student.course2.ToString() + "\n" + student.course3.ToString() + "\n" + student.average.ToString("F2") + "\n";

            }
            return str;
        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            // sự kiện click nút next
            int index = int.Parse(label_num.Text); // lấy index hiện tại
            int num_of_student = Des_students.Count; // lấy tổng số student đã đọc trong list des_students
            // nếu mà index < tổng số thì ta cộng index lên 1
            if (index < num_of_student)
            {
                index++;
                label_num.Text = index.ToString();
                Update_TextBox_Result(index - 1); // cập nhật textbox theo stt

            }
            else 
            {
                index = 1; // nếu không thì index nó trở về 1
                label_num.Text = index.ToString();
                Update_TextBox_Result(index - 1);

            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int index = int.Parse(label_num.Text);
            int nums_of_student = Des_students.Count; // lấy giá trị số lượng list 
            if (index > 1)
            {
                index--; // trường hợp này giảm lable xuống
                label_num.Text = index.ToString();
                Update_TextBox_Result(index - 1); // cập nhật các textbox theo stt

            }
            else
            {
                index = nums_of_student;
                label_num.Text = index.ToString();
                Update_TextBox_Result(index - 1);

            }
        }
        bool Check()
        {
            if (txt_nameW.Text == "" || txt_idW.Text == "" || txt_PhoneW.Text == "" || txt_C1W.Text == "" || txt_C2W.Text == "" || txt_C3W.Text == "")
            {
                MessageBox.Show("Một trong các dữ liệu bạn nhập còn thiếu, vui lòng nhập đầy đủ !"); // test đầy đủ

                return false;
            }
            if (!float.TryParse(txt_C1W.Text, out float test1))
            {
                MessageBox.Show("Course 1 không đúng định dạng !");
                return false;
            }
            if (!float.TryParse(txt_C2W.Text, out float test2))
            {
                MessageBox.Show("Course 2 không đúng định dạng !");
                return false;
            }
            if (!float.TryParse(txt_C3W.Text, out float test3))
            {
                MessageBox.Show("Course 3 không đúng định dạng !");
                return false;
            }
            float course1 = float.Parse(txt_C1W.Text, CultureInfo.InvariantCulture);
            float course2 = float.Parse(txt_C2W.Text, CultureInfo.InvariantCulture);
            float course3 = float.Parse(txt_C3W.Text, CultureInfo.InvariantCulture);
            if (!(course1 >= 0 && course1 <= 10 && course2 >= 0 && course2 <= 10 && course3 >= 0 && course3 <= 10))
            {
                MessageBox.Show("Trong số các course nhập điểm quá giới hạn điểm !");
                return false;
            }

            if (txt_PhoneW.Text.Length != 10 || txt_PhoneW.Text[0] != (char)48)
            {
                MessageBox.Show("Số điện thoại nhập sai định dạng, phải có 10 số và bắt đầu bằng số 0");
                return false;
            }
            if (txt_PhoneW.Text.Length == 10 && txt_PhoneW.Text[0] == (char)48)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!char.IsDigit(txt_PhoneW.Text[i]))
                    {
                        MessageBox.Show("Số điện thoại phải chưa toàn bộ là chữ số từ 0 - 9 !");
                        return false;
                    }
                }
            }

            if (txt_idW.Text.Length != 8)
            {
                MessageBox.Show("MSSV phải có 8 chữ số");
                return false;
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    if (!char.IsDigit(txt_idW.Text[i]))
                    {
                        MessageBox.Show("MSSV phải là số");
                        return false;
                    }
                }

            }
            return true;


        }
    }
}
