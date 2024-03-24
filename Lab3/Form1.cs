namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            FormBai1 bai1 = new FormBai1();
            bai1.ShowDialog();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Form bai2 = new FormBai2_TCP_server_Telnet();
            bai2.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            Form bai3 = new FormMain_Bai3();
            bai3.ShowDialog();
        }

        private void btn_Bai4_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Bai5_Click(object sender, EventArgs e)
        {
            Form bai5 = new Bai5FormMain();
            bai5.ShowDialog();
        }

        
    }
}