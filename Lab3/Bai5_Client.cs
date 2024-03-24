using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai5_Client : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread receiveThread;
        private string username; // Biến để lưu username của người dùng

        public Bai5_Client()
        {
            InitializeComponent();
        }
        private void Bai4_Client_Load(object sender, EventArgs e)
        {
            buttonDisconnect.Enabled = false;
            buttonSend.Enabled = false;
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = true;
            buttonSend.Enabled = true;
            ConnectToServer();
        }
        private void ConnectToServer()
        {
            // Khởi tạo kết nối đến server
            client = new TcpClient();
            client.Connect("192.168.238.175", 8080); // Kết nối đến địa chỉ IP và cổng của server

            // Khởi tạo StreamReader và StreamWriter để đọc/ghi dữ liệu với server
            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            // Nhập username từ người dùng
            username = textBoxUserName.Text;

            if (string.IsNullOrEmpty(username)) // Kiểm tra nếu không nhập username
            {
                MessageBox.Show("Bạn cần nhập username để Chat!");
                this.Close();
            }

            // Gửi username lên server để đăng ký
            writer.WriteLine(username);
            writer.Flush();

            // Khởi tạo thread để lắng nghe dữ liệu từ server
            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.Start();
        }
        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    // Đọc tin nhắn từ server
                    string message = reader.ReadLine();

                    // Hiển thị tin nhắn lên client
                    AddLog(message);
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username)) // Kiểm tra nếu chưa nhập username
            {
                MessageBox.Show("Vui lòng nhập username trước khi gửi tin nhắn.");
                return;
            }

            // Gửi tin nhắn lên server kèm theo username
            writer.WriteLine(textBoxMessage.Text);
            writer.Flush();
            textBoxMessage.Clear();
        }
        private void AddLog(string log)
        {
            if (textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke(new Action<string>(AddLog), log);
            }
            else
            {
                textBoxLog.AppendText(log + Environment.NewLine);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            // Ngắt kết nối với server
           
            client.Close();

            // Kiểm tra trạng thái kết nối
            if (!client.Connected)
            {
                // Đóng các tài nguyên khác liên quan đến kết nối
                reader.Close();
                writer.Close();
                if (receiveThread != null && receiveThread.IsAlive)
                {
                    receiveThread.Abort();
                    receiveThread = null;
                }

                // Cập nhật giao diện người dùng
                buttonConnect.Enabled = true;
                buttonSend.Enabled = false;
                buttonDisconnect.Enabled = false;
            }
        }
    }
}
