using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace Lab1
{
    public partial class FormCalcIP : Form
    {
        public FormCalcIP()
        {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                IPAddress NetworkAddress = IPAddress.Parse(txt_NetworkAdd.Text); // Parse IP address
                uint i_subnet = 0xFFFFFFFF;
                i_subnet = i_subnet >> (32 - int.Parse(txt_SubnetMask.Text)); // tạo giá trị subnet mask
                IPAddress SubnetMask = new IPAddress(i_subnet); // subnet mask
                int inums_of_subnets = int.Parse(txt_NumSubnets.Text); // parse số mạng con cần chia

                byte[] bytes_NetworkIP = NetworkAddress.GetAddressBytes(); // chuyển địa chỉ networkIP đã nhập vào mảng byte
                Array.Reverse(bytes_NetworkIP); // đảo giá trị các byte trong mảng 
                uint networkAddressInt = BitConverter.ToUInt32(bytes_NetworkIP, 0); //chuyển giá trị đã reverse thành giá trị unit

                uint subnetMaskInt = BitConverter.ToUInt32(SubnetMask.GetAddressBytes(), 0);
                int hostBits = (int)32 - int.Parse(txt_SubnetMask.Text); // số bit còn lại để làm host
                int subnetBits = (int)Math.Log(inums_of_subnets, 2); // số bit mượn để làm mạng con
                uint subnetSize = (uint)(1 << hostBits - subnetBits); // size mỗi subnet con 2^(hostbits-subnetBits)

                dgvResults.Rows.Clear(); //xóa -> nhập vào table
                for (int i = 0; i < inums_of_subnets; i++)
                {

                    uint subnetAddressInt = (uint)(networkAddressInt + i * subnetSize); // 3 dòng tính địa chỉ mạng  
                    byte[] newbytes_SubAddIP = BitConverter.GetBytes(subnetAddressInt);
                    Array.Reverse(newbytes_SubAddIP);

                    uint firstAddressInt = subnetAddressInt + 1; // 3 dòng tính địa chỉ đầu
                    byte[] newbytes_FirstAddIP = BitConverter.GetBytes(firstAddressInt);
                    Array.Reverse(newbytes_FirstAddIP);

                    uint lastAddressInt = subnetAddressInt + subnetSize - 2; // 3 dòng tính địa chỉ cuối
                    byte[] newbytes_LastAddIP = BitConverter.GetBytes(lastAddressInt);
                    Array.Reverse(newbytes_LastAddIP);

                    uint broadcastAddressInt = subnetAddressInt + subnetSize - 1; // 3 dòng tính địa chỉ broadcast
                    byte[] newbytes_BroadcastIP = BitConverter.GetBytes(broadcastAddressInt);
                    Array.Reverse(newbytes_BroadcastIP);

                    dgvResults.Rows.Add(
                        i + 1,
                        new IPAddress(newbytes_SubAddIP).ToString(), // thêm các row
                        new IPAddress(newbytes_FirstAddIP).ToString(),
                        new IPAddress(newbytes_LastAddIP).ToString(),
                        new IPAddress(newbytes_BroadcastIP).ToString()
                    );
                }

            }
        }

        private bool Check()
        {
            IPAddress ip;
            if (txt_NetworkAdd.Text == "" || txt_NumSubnets.Text == "" || txt_SubnetMask.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
                return false;
            }

            if (!IPAddress.TryParse(txt_NetworkAdd.Text, out ip))
            {
                MessageBox.Show("Lỗi nhập địa chỉ mạng!!");
                return false;
            }
            else if (!int.TryParse(txt_SubnetMask.Text, out int s))
            {
                MessageBox.Show("Lỗi nhập Subnet Mask!");
                return false;
            }

            int sub = int.Parse(txt_SubnetMask.Text);
            int byte1IP = (int)ip.GetAddressBytes()[3];
            switch (sub)
            {


                case 8:
                    {

                        if ((byte1IP >= 0 && byte1IP <= 127))
                        {
                            MessageBox.Show("Subnet Mask này không đúng với lớp A.");
                            return false;
                        }
                        break;
                    }
                case 16:
                    {

                        if ((byte1IP >= 128 && byte1IP <= 191))
                        {
                            MessageBox.Show("Subnet Mask này không đúng với lớp B.");
                            return false;
                        }
                        break;
                    }
                case 24:
                    {

                        if ((byte1IP >= 192 && byte1IP <= 223))
                        {
                            MessageBox.Show("Subnet Mask này không đúng với lớp C.");
                            return false;
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Subnet Mask không đúng!");
                        return false;
                    }

            }


            return true;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            txt_NetworkAdd.Text = txt_NumSubnets.Text = txt_SubnetMask.Text = string.Empty;
            dgvResults.Rows.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
