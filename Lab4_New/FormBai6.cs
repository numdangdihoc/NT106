using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Lab4_New
{
    public partial class FormBai6 : Form
    {
        HtmlWeb htmlWeb = new HtmlWeb();
        public FormBai6()
        {
            InitializeComponent();
            txtURL.Text = "https://vnexpress.net/the-gioi/tu-lieu";
            txtURL.Enabled = false;

        }
        // tạo class Article
        class Article
        {
            public string Title { get; set; }
            public string Url { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }

            public Article(string title, string url, string description, string imageUrl)
            {
                Title = title;
                Url = url;
                Description = description;
                ImageUrl = imageUrl;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string url = "https://vnexpress.net/the-gioi/tu-lieu";
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDoc = htmlWeb.Load(url);
            var articles = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");

            if (articles != null)
            {
                List<Article> articleList = new List<Article>();

                foreach (var articleNode in articles)
                {
                    //lấy thẻ h2
                    HtmlNode titleNode = articleNode.SelectSingleNode(".//h2");
                    string title = titleNode != null ? titleNode.InnerText.Trim() : string.Empty;
                   // h2/a
                    HtmlNode urlNode = articleNode.SelectSingleNode(".//h2/a");
                    string Article_url = urlNode != null ? urlNode.GetAttributeValue("href", ""): "";
                    //thẻ p chứa descripton
                    HtmlNode descriptonNode = articleNode.SelectSingleNode(".//p");
                    string description = descriptonNode != null ? descriptonNode.InnerText.Trim() : string.Empty;
                   // thẻ img có chứa hình ảnh
                    HtmlNode imgNode = articleNode.SelectSingleNode(".//img");
                    string imageUrl = string.Empty;

                    if (imgNode != null) 
                    {
                        if (imgNode.Attributes["data-src"] == null) 
                            // tại vì trang web này vài chỗ src ảnh nó tào lao nên e làm zậy đó thầy
                        {
                            imageUrl = imgNode.GetAttributeValue("src", ""); 
                        }
                        else
                        {
                            imageUrl = imgNode.GetAttributeValue("data-src", "");
                        }
                    }

                    Article article = new Article(title,Article_url, description, imageUrl);
                    articleList.Add(article);
                }
                int count = 0; // đếm biến count để set vị trí
                panel1.Controls.Clear();
                foreach (var article in articleList)
                {
                    if (article.Title != "") // nếu article tittle lấy về lỗi/rỗng thì không show
                    {
                        // thêm lable
                        Label lbTittle = new Label();
                        lbTittle.Text = article.Title;
                        lbTittle.AutoSize = true;
                        lbTittle.Font = new Font("Arial", 14, FontStyle.Bold);
                        //set giá trị tag của label đó là string url
                        lbTittle.Tag = article.Url;
                        //thêm sự kiện khi click vào label tittle bài báo thì sẽ hiển thị trang bài báo đó
                        lbTittle.Click += lbTittle_Click;

                        Label lbDescription = new Label();
                        lbDescription.AutoSize = true;
                        lbDescription.MaximumSize = new Size(400, 0); 
                        lbDescription.Text = article.Description;

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 200;
                        pictureBox.Height = 100;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.ImageLocation = article.ImageUrl ;

                        lbTittle.Location = new Point(0, count * 150);
                        lbDescription.Location = new Point(0+10, ((count*150)+25));
                        pictureBox.Location = new Point(700, count * 150);
                        //tăng biến count
                        count++;
                        //add panel
                        panel1.Controls.Add(lbTittle);
                        panel1.Controls.Add(lbDescription);
                        panel1.Controls.Add(pictureBox);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No found articles");
            }

            
        }
        void lbTittle_Click(object sender, EventArgs e)
        {
            // Truy cập thuộc tính Tag và chuyển đổi sang kiểu chuỗi
            string url = (sender as Label)?.Tag as string;
            // Hiển thị form mới
            FormBai4 frmBai4 = new FormBai4(url);
            frmBai4.Show();
        }
    }

}
    

