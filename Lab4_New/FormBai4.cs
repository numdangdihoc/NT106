using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_New
{
    public partial class FormBai4 : Form
    {
        public FormBai4(string url)
        {
            InitializeComponent();
            txtUrl.Text = url;
            webView21.Source = new Uri(txtUrl.Text);

        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                webView21.Source = new Uri(txtUrl.Text);

            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            FormBai4_ViewSource view = new FormBai4_ViewSource(txtUrl.Text);
            view.Show();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            Stream respone = myClient.OpenRead(txtUrl.Text);
            StreamReader sr = new StreamReader(respone);
            string responeFromServer = sr.ReadToEnd();

            

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.html";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    myClient.DownloadFile(txtUrl.Text, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void DownloadImagesFromUrl(string url)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDocument = htmlWeb.Load(url);

            // Lấy tất cả các thẻ <img>
            HtmlNodeCollection imageNodes = htmlDocument.DocumentNode.SelectNodes("//img");

            if (imageNodes != null)
            {
                foreach (HtmlNode imageNode in imageNodes)
                {
                    string imageUrl = imageNode.GetAttributeValue("src", "");

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        // Tiếp tục tải xuống hình ảnh
                        string downloadPath = "C:\\Users\\DELL\\Downloads\\IMG"; // Đường dẫn thư mục để lưu trữ hình ảnh

                        // Tạo thư mục đích nếu nó chưa tồn tại
                        Directory.CreateDirectory(downloadPath);
                        //định dạng tên là image+ngaythangnam+extension(.png .hjpg...)
                        string fileName = "image" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(imageUrl);
                        string filePath = Path.Combine(downloadPath, fileName);

                        // Tải xuống hình ảnh
                        
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.DownloadFile(imageUrl, filePath);
                            }
                       
                    }


                }
            }
        }

        private void btnImgDownload_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text; 
            DownloadImagesFromUrl(url);
        }
    }
}
