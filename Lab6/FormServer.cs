using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;

namespace Lab6
{
    public partial class FormServer : Form
    {
        private TcpListener tcpListener;
        private List<TcpClient> clients = new List<TcpClient>();
        private Dictionary<TcpClient,string> dict_pk = new Dictionary<TcpClient,string>();
        private Lab6.CryptoRSA my_rsa;
        private Lab6.CryptoAES my_aes;
        string aes_key, aes_iv;
        string myprivatekey;
        string mypublickey;
        //private byte[] Decrypted;
        // private byte[] Encrypted;
        public FormServer()
        {
            InitializeComponent();
            /*my_rsa = new Lab6.CryptoRSA();
            myprivatekey = my_rsa.PrivateKey;
            mypublickey = my_rsa.PublicKey; */
            
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            StartServer();
        }
        private void StartServer()
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
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
            string userName_key = reader.ReadLine(); // Đọc tên người dùng từ client
            string[] reicv = userName_key.Split('-'); 
            string userName = reicv[0];
            string userPK = reicv[1];
            AddClient(tcpClient, userName,userPK); // add client với tên người dùng

            while (tcpClient.Connected) // Kiểm tra trạng thái kết nối
            {
                try
                {
                    string message = reader.ReadLine();
                    if (message == null)
                        break;


                    // Xử lý tin nhắn từ client, broadcast cho toàn bộ client
                    BroadcastMessage(userName + ": -" + message);
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

        private void AddClient(TcpClient tcpClient, string userName, string userPK)
        {
            // Thêm client vào danh sách
            clients.Add(tcpClient);
            dict_pk.Add(tcpClient, userPK);
            // Hiển thị thông tin đăng nhập của client lên giao diện
            AppendLog(userName + " đã kết nối !");
            // Broadcast tin nhắn chào mừng tới tất cả client, trừ client mới kết nối
            BroadcastMessage("CheckInOut"+userName + " đã tham gia cuộc trò chuyện.", tcpClient);
        }

        private void RemoveClient(TcpClient tcpClient, string userName)
        {
            // Xóa client khỏi danh sách
            clients.Remove(tcpClient);
            dict_pk.Remove(tcpClient);
            // Hiển thị thông tin đăng xuất của client lên giao diện
            AppendLog("CheckInOut"+userName + " đã ngắt kết nối!");
            // Broadcast tin nhắn thông báo client đã đăng xuất tới tất cả client, trừ client đã đăng xuất
            BroadcastMessage("CheckInOut"+userName + " đã rời khỏi cuộc trò chuyện.", tcpClient);
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
                else 
                {
                    NetworkStream clientStream = client.GetStream();
                    StreamWriter writer = new StreamWriter(clientStream);
                    string sendkey = "Publickey:" + mypublickey;
                    //send PK_RSA - aes key to client
                    string snd_aes_key = aes_key;
                    string snd_aes_iv = aes_iv;
                    byte[] aes_key_bytes = Encoding.ASCII.GetBytes(snd_aes_key);
                    byte[] enc_key = my_rsa.Encrypt(aes_key_bytes, dict_pk[client]);
                    
                    byte[] aes_iv_bytes = Encoding.ASCII.GetBytes(snd_aes_iv);
                    byte[] enc_iv = my_rsa.Encrypt(aes_iv_bytes, dict_pk[client]);

                    sendkey += "-" + Convert.ToBase64String(enc_key) + "-" + Convert.ToBase64String(enc_iv);
                    writer.WriteLine(sendkey);
                    writer.Flush();
                    


                }
            }
            // Hiển thị tin nhắn lên giao diện
            AppendLog(message);
        }
        private void AppendLog(string message)
        {
            // Hiển thị tin nhắn lên giao diện trong textbox
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.AppendText(message + Environment.NewLine); }));
            }
            else
            {
                richTextBox1.AppendText(message + Environment.NewLine);
            }
        }
        

        private void FormServer_Load(object sender, EventArgs e)
        {
            //init RSA and AES
            
            my_rsa = new Lab6.CryptoRSA();
            myprivatekey = my_rsa.PrivateKey;
            mypublickey = my_rsa.PublicKey;

            my_aes = new Lab6.CryptoAES();
            aes_key = Convert.ToBase64String(my_aes.aesAlg.Key);
            aes_iv = Convert.ToBase64String(my_aes.aesAlg.IV);
        }
    }
}
