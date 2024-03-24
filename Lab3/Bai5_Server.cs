using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai5_Server : Form
    {
        private TcpListener tcpListener;
        private List<TcpClient> clients = new List<TcpClient>();
        public Bai5_Server()
        {
            InitializeComponent();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            StartServer();
        }
        private void StartServer()
        {
            try
            {
                // Khởi tạo và bắt đầu lắng nghe kết nối từ client
                tcpListener = new TcpListener(IPAddress.Any, 8080);
                tcpListener.Start();
                AppendLog("Server đang lắng nghe...");
                Thread listenThread = new Thread(ListenForClients);
                listenThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListenForClients()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    Thread clientThread = new Thread(start: HandleClientComm);
                    clientThread.Start(tcpClient);
                }
                catch (SocketException ex)
                {
                    // Bắt ngoại lệ SocketException khi dừng lắng nghe kết nối từ client
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            StreamReader reader = new StreamReader(clientStream);
            StreamWriter writer = new StreamWriter(clientStream);
            string userName = reader.ReadLine(); // Đọc tên người dùng từ client
            AddClient(tcpClient, userName); // add client với tên người dùng

            while (tcpClient.Connected) // Kiểm tra trạng thái kết nối
            {
                try
                {
                    string message = reader.ReadLine();
                    if (message == null)
                        break;
                    
                    
                    // Xử lý tin nhắn từ client, ví dụ: broadcast cho toàn bộ client
                    BroadcastMessage(userName + ": " + message);
                }
                catch (IOException)
                {
                    // Xóa client khỏi danh sách khi client đóng kết nối
                    RemoveClient(tcpClient, userName);
                    break;
                }
            }

            // Đóng kết nối và xóa client khi client đóng kết nối
            tcpClient.Close();
            RemoveClient(tcpClient, userName);
        }
        private void AddClient(TcpClient tcpClient, string userName)
        {
            // Thêm client vào danh sách
            clients.Add(tcpClient);
            // Hiển thị thông tin đăng nhập của client lên giao diện
            AppendLog(userName + " đã kết nối !");
            // Broadcast tin nhắn chào mừng tới tất cả client, trừ client mới kết nối
            BroadcastMessage(userName + " đã tham gia cuộc trò chuyện.", tcpClient);
        }

        private void RemoveClient(TcpClient tcpClient, string userName)
        {
            // Xóa client khỏi danh sách
            clients.Remove(tcpClient);
            // Hiển thị thông tin đăng xuất của client lên giao diện
            AppendLog(userName + " đã ngắt kết nối!");
            // Broadcast tin nhắn thông báo client đã đăng xuất tới tất cả client, trừ client đã đăng xuất
            BroadcastMessage(userName + " đã rời khỏi cuộc trò chuyện.", tcpClient);
        }

        private void BroadcastMessage(string message, TcpClient excludedClient = null)
        {
            
            // Broadcast tin nhắn tới tất cả client, trừ client trừ ra( nếu có loại trừ)
            foreach (TcpClient client in clients)
            {
                if (client != excludedClient)
                {
                    NetworkStream clientStream = client.GetStream();
                    StreamWriter writer = new StreamWriter(clientStream);
                    writer.WriteLine(message);
                    writer.Flush();
                }
            }
            // Hiển thị tin nhắn lên giao diện
            AppendLog(message);
        }
        private void AppendLog(string message)
        {
            // Hiển thị tin nhắn lên giao diện trong textbox
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new MethodInvoker(delegate { txtLog.AppendText(message + Environment.NewLine); }));
            }
            else
            {
                txtLog.AppendText(message + Environment.NewLine);
            }
        }
       /* private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đóng kết nối và dừng lắng nghe kết nối từ client khi đóng form
            tcpListener.Stop();
        } */
    }
}
