using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread receiveThread;
        private string username; // Biến để lưu username của người dùng
        private string serverPublicKey;
        private Lab6.CryptoRSA my_rsa;
        string my_pulickey;
        string my_privatekey;
        string aes_key, aes_iv;
        private void btnCon_Click(object sender, EventArgs e)
        {
            btnCon.Enabled = false;
            btnDiscon.Enabled = true;
            btnSend.Enabled = true;
            ConnectToServer();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            btnDiscon.Enabled = false;
            btnSend.Enabled = false;
            my_rsa = new Lab6.CryptoRSA();
            my_pulickey = my_rsa.PublicKey;
            my_privatekey = my_rsa.PrivateKey;
        }
        private void ConnectToServer()
        {
            try
            {
                // Khởi tạo kết nối đến server
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080); // Kết nối đến địa chỉ IP và cổng của server

                // Khởi tạo StreamReader và StreamWriter để đọc/ghi dữ liệu với server
                NetworkStream stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);

                // Nhập username từ người dùng
                username = txtUsername.Text;

                if (string.IsNullOrEmpty(username)) // Kiểm tra nếu không nhập username
                {
                    MessageBox.Show("Bạn cần nhập username để Chat!");
                    this.Close();
                }

                // Gửi username lên server để đăng ký
                writer.WriteLine(username+"-"+my_pulickey);
                writer.Flush();

                // Khởi tạo thread để lắng nghe dữ liệu từ server
                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                //
            }
        }


        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {

                    // Đọc tin nhắn từ server
                    string message = reader.ReadLine();
                    try
                    {
                        if (message.StartsWith("Publickey:"))
                        {
                            AddLog("Server chào Client " + username + "\r\n");
                            string prefix = "Publickey:";
                            string serverPublicKey_message = message.Substring(prefix.Length);
                            string[] getkey = serverPublicKey_message.Split('-');
                            serverPublicKey = getkey[0];
                            Decrypt_AESKEY_FROM_SERVER(getkey[1], getkey[2]);
                            //richTextBox1.Text += serverPublicKey+ "\r\n"+aes_key+ "\r\n"+aes_iv;

                        }
                        else if(message.StartsWith("CheckInOut"))
                        {
                            string prefix = "CheckInOut";
                            string mess = message.Substring(prefix.Length);
                            AddLog(mess);
                        }
                        else
                        {
                            // Hiển thị tin nhắn lên client
                            //userName + ": -"
                            string[] get_message = message.Split('-');
                            string user_name = get_message[0];
                            string ciphertext = get_message[1];
                            byte[] key = Convert.FromBase64String(aes_key);
                            byte[] iv = Convert.FromBase64String(aes_iv);
                            Lab6.CryptoAES aes_obj = new Lab6.CryptoAES(key,iv);
                            string plaintext = aes_obj.Decrypt(ciphertext);
                            AddLog(user_name+plaintext);
                        }
                    }
                    catch 
                    {
                        //somthing went wrong :>        
                    }
               
                    
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLog(string log)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AddLog), log);
            }
            else
            {
                richTextBox1.AppendText(log + Environment.NewLine);
            }
        }

        private void btnDiscon_Click(object sender, EventArgs e)
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
                btnCon.Enabled = true;
                btnSend.Enabled = false;
                btnDiscon.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username)) // Kiểm tra nếu chưa nhập username
            {
                MessageBox.Show("Vui lòng nhập username trước khi gửi tin nhắn.");
                return;
            }

            // Gửi tin nhắn lên server 
            byte[] key = Convert.FromBase64String(aes_key);
            byte[] iv = Convert.FromBase64String(aes_iv);
            Lab6.CryptoAES aes_obj = new Lab6.CryptoAES(key,iv);
            string text = txtInput.Text;
            string ciphertext = aes_obj.Encrypt(text);
            //string enc_text =  
            writer.WriteLine(ciphertext);
            writer.Flush();
            txtInput.Clear();
        }
        private void Decrypt_AESKEY_FROM_SERVER(string enc_key, string enc_iv)
        {
            byte[] key = Convert.FromBase64String(enc_key);
            byte[] iv = Convert.FromBase64String(enc_iv);

            byte[] decrypt = my_rsa.Decrypt(key, my_privatekey);
            string decKey = Encoding.ASCII.GetString(decrypt);

            decrypt = my_rsa.Decrypt(iv, my_privatekey);
            string decIV = Encoding.ASCII.GetString(decrypt);
            aes_key = decKey;
            aes_iv = decIV;

        }
    }
}
