using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Formbai6 : Form
    {
        public Formbai6()
        {
            InitializeComponent();
            treeViewFiles.NodeMouseDoubleClick += treeViewFiles_NodeMouseDoubleClick;

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Khi (event) form được load, hiển thị các ổ đĩa làm các nút gốc của TreeView
            LoadDrives();
        }
        private void LoadDrives() //load các ổ đĩa
        {
            try
            {
                // Xóa các nút gốc cũ
                treeViewFiles.Nodes.Clear();

                // Lấy danh sách các ổ đĩa trên máy tính
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    // Tạo một nút con mới cho mỗi ổ đĩa
                    TreeNode driveNode = new TreeNode(drive.Name);
                    driveNode.Tag = drive.RootDirectory.FullName;
                    treeViewFiles.Nodes.Add(driveNode);
                    // Thêm một nút giả để đợi khi người dùng mở nút con
                    TreeNode fakeNode = new TreeNode("...");
                    driveNode.Nodes.Add(fakeNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        private void treeViewFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Xử lý sự kiện trước khi nút con của TreeView được mở ra
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "...")
            {
                // Nếu nút con chưa được tải, thì tải danh sách thư mục và file vào nút con
                e.Node.Nodes.Clear();

                string path = e.Node.Tag.ToString();
                LoadDirectoryContents(path, e.Node);
            }
        }
        private void LoadDirectoryContents(string path, TreeNode parentNode)
        {
            try
            {
                // Đọc danh sách thư mục
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(directory);
                    TreeNode directoryNode = new TreeNode(dirInfo.Name);
                    directoryNode.Tag = dirInfo.FullName;
                    parentNode.Nodes.Add(directoryNode);

                    // Thêm một nút giả để đợi khi người dùng mở nút con
                    TreeNode fakeNode = new TreeNode("...");
                    directoryNode.Nodes.Add(fakeNode);
                }

                // Đọc danh sách file
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    TreeNode fileNode = new TreeNode(fileInfo.Name);
                    fileNode.Tag = fileInfo.FullName;
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeViewFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            //sự kiện khi double click vào thư mục or file

            string path = e.Node.Tag.ToString();
            FileAttributes attributes = File.GetAttributes(path);
            if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                // Nếu là thư mục, thì mở thư mục tiếp theo. khong làm gì
            }
            else
            {
                // Nếu là file
                string fileExtension = Path.GetExtension(path).ToLower(); // lấy phần extension của file
                if (fileExtension == ".txt")
                {
                    richTextBox1.Visible = true; // trường hợp đọc ảnh trước thì textbox bị đè => true để xem
                    // Nếu là file .txt, thì đọc nội dung file và hiển thị trong RichTextBox
                    string fileContent = File.ReadAllText(path);
                    pictureBox1.Visible = false; // lúc này set picutrebox false để xem được textbox 
                    richTextBox1.Text = fileContent;
                }
                else if (fileExtension == ".jpg"|| fileExtension == ".jpeg"|| fileExtension == ".png")
                {
                    // Nếu là file .jpg, thì hiển thị hình ảnh trong PictureBox
                    pictureBox1.Visible= true; //đè lên textbox
                    richTextBox1.Visible = false; // ẩn textbox đi để xem ảnh
                    pictureBox1.Image = Image.FromFile(path);

                }
                else
                {
                    // Nếu là file có định dạng khác, hiển thị thông báo lỗi
                    MessageBox.Show("Định dạng file không được hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

