using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_New
{
    public partial class FormBai5 : Form
    {
        private int currentPage = 1;
        private int totalPages = 1;
        private UserPagination userData;

        public FormBai5()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szUrl);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("email")]
            public string Email { get; set; }
            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }
            [JsonPropertyName("last_name")]
            public string LastName { get; set; }
            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }

        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }
            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }
            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }

        private void LoadPage(int page) // truyền vào tham số page để biết load page nào 1 or 2
        {
            try
            {
                var response = getHTML($"https://reqres.in/api/users?page={page}");
                var data = JsonSerializer.Deserialize<UserPagination>(response);

                userData = data;
                currentPage = data.Page;
                totalPages = data.TotalPages;
                // set các giá trị
                labelPage.Text = "Page: " + currentPage.ToString();
                labelTottalPage.Text = "Total page: " + totalPages.ToString();
                labelUserPerPage.Text = "Users/page: "+data.PerPage.ToString();
                labelTotalUser.Text = "Total users: "+data.Total.ToString();
                panel1.Controls.Clear();

                foreach (var item in data.Data)
                {
                    // khởi tạo 2 label name và email
                    Label lbName = new Label();
                    lbName.Text = item.FirstName + " " + item.LastName;
                    lbName.AutoSize = true;
                    Label lbEmail = new Label();
                    lbEmail.AutoSize = true;
                    lbEmail.Text = item.Email; 

                    // khởi tạo picturebox
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.ImageLocation = item.Avatar;
                    if (page == 1)
                    {
                        // định vị trí cho các item
                        lbName.Location = new Point(0, item.Id * 150);
                        lbEmail.Location = new Point(0, ((item.Id*150)+25));
                        pictureBox.Location = new Point(500, item.Id * 150);


                    }
                    else // page = 2
                    {
                        // định vị trí cho các item, do page 2 nên vị trí set lại = id -6
                        int locate = item.Id - 6;
                        lbName.Location = new Point(0, locate * 150);
                        lbEmail.Location = new Point(0, ((locate*150)+25));
                        pictureBox.Location = new Point(500, locate * 150);
                        

                    }
                    panel1.Controls.Add(pictureBox);
                    
                    panel1.Controls.Add(lbName);
                    panel1.Controls.Add(lbEmail);
                }

                UpdateNavigationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNavigationButtons() // enable các button Prev Next
        {
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // sự kiện khi bấm Get button // page = 1
            LoadPage(currentPage);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage(currentPage);
            }
        }
    }
}
