using MailKit.Net.Imap;
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
using System.Threading;
using System.Diagnostics;
using MimeKit;
using Org.BouncyCastle.Asn1.Smime;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Net.Mail;
using Org.BouncyCastle.Pqc.Crypto.NtruPrime;

namespace Lab5
{
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
            
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            btnSend.Visible = false;
            btnRefresh.Visible = false;
            listView1.FullRowSelect = true;
            colFrom.Width = 250;
            colSub.Width = 200;
            colDate.Width = 100;
           // tbUserName.Text = "";
            //tbPass.Text = "";

        }
        
        ImapClient client_imap;
        MailKit.Net.Smtp.SmtpClient client_smtp;
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (btnLogin.Text == "Đăng nhập")
            {
                client_imap = new ImapClient();
                client_imap.Connect(tbIMAP.Text,int.Parse(comboBox1.Text), MailKit.Security.SecureSocketOptions.Auto); 
                client_imap.Authenticate(tbUserName.Text, tbPass.Text); // gmail accout, app password.
                // tạo 1 smtpClient
                client_smtp = new MailKit.Net.Smtp.SmtpClient();
                client_smtp.Connect(tbSMTP.Text,int.Parse(comboBox2.Text),MailKit.Security.SecureSocketOptions.Auto);
                

                Get_Mail(client_imap);
                btnLogin.Text = "Đăng xuất";
                btnSend.Visible = true;
                btnRefresh.Visible = true;
            }
            else
            {

                client_imap.Disconnect(true);
                client_smtp.Disconnect(true);
                listView1.Items.Clear ();
                btnLogin.Text = "Đăng nhập";
                btnSend.Visible = false;
                btnRefresh.Visible = false;
            }

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Get_Mail(this.client_imap);
        }

        private void Get_Mail(ImapClient client)
        {
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            listView1.Items.Clear();
            int index = 0;
            for (int i = inbox.Count - 1; i >= inbox.Count - 1 - 20; i--)
            {
                var message = inbox.GetMessage(i);
                
                
                ListViewItem item = new ListViewItem();
                item.Text = index.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Subject.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.ToString() });
                listView1.Items.Add(item);
                index++;

            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy chỉ số của email được chọn
                int index = int.Parse(listView1.SelectedItems[0].Text);
                string str = listView1.SelectedItems[0].Text;
                var inbox = client_imap.Inbox;
                int count = inbox.Count;
                inbox.Open(FolderAccess.ReadOnly);
                var email = inbox.GetMessage(count-(index+1));

                ViewMail mailview = new ViewMail(email, client_smtp);

                mailview.Show();
            }
        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMail sendmail = new SendMail(client_smtp,new MimeMessage(),0,tbUserName.Text);
            sendmail.Show();
        }
    }
}
