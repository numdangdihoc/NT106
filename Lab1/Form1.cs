namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form bai1 = new FormSum2num();
            bai1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form bai2 = new FormMaxMin();
            bai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form bai3 = new FormReadNum();
            bai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form bai4 = new FormPetro();
            bai4.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form bai5 = new FormCalc2int();
            bai5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form bai6 = new FormCalcIP();
            bai6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form bai7 = new FormInfoSV();
            bai7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form bai8 = new FormReadNumAdvance();
            bai8.ShowDialog();
        }
    }
}