namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Form bai1 = new FormBai1();
            bai1.ShowDialog();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Form bai2 = new FormBai2();
            bai2.ShowDialog();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Form bai3 = new FormBai3();
            bai3.ShowDialog();

        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Form bai4 = new FormBai4();
            bai4.ShowDialog();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Form bai5 = new FormBai5();
            bai5.ShowDialog();
        }

        private void btn_bai6_Click(object sender, EventArgs e)
        {
            Form bai6 = new Formbai6();
            bai6.ShowDialog();
        }
    }
}