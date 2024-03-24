using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace Lab5
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
            //listView1.View = View.Details;
           // tbEmail.Text = "";
            //tbPass.Text = "";
            
            colEmail.Width = 250;
            colFrom.Width = 200;
            colTime.Width = 100;
            listView1.FullRowSelect = true;
            comboBox1.Items.Add("IMAP");
            comboBox1.Items.Add("POP");
            comboBox1.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Imap_GetMail();
            }
            else
            {
                Pop_GetMail();
            }
            
        }
        private void Imap_GetMail()
        {
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);  // imap host, port, use ssl.
            client.Authenticate(tbEmail.Text, tbPass.Text); // gmail accout, app password.

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            listView1.Items.Clear();
            for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 10; i--)
            {
                var message = inbox.GetMessage(i);
                
                ListViewItem item = new ListViewItem();
                item.Text = message.Subject;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.ToString() });
                listView1.Items.Add(item);

            }
            
        }
        private void Pop_GetMail()
        {
            var client = new Pop3Client();
            client.Connect("pop.gmail.com", 995, true);
            try
            {
                client.Authenticate(tbEmail.Text, tbPass.Text);
                MessageBox.Show("Đăng nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            int count = client.GetMessageCount();
            listView1.Items.Clear();
            for (int i = count -1 ; i > count -10 -1; i--)
            {
                var message = client.GetMessage(i);
                
                ListViewItem item = new ListViewItem();
                item.Text = message.Subject;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.ToString() });
                listView1.Items.Add(item);

            }

        }
    }
}
