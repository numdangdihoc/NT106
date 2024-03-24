using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab5
{
    public partial class SendMail : Form
    {
        private MimeMessage email;
        private MailKit.Net.Smtp.SmtpClient client;
        private int isRely;
        private string UserMail;
        public SendMail(MailKit.Net.Smtp.SmtpClient client, MimeMessage email, int isRely, string UserMail)
        {
            InitializeComponent();
            this.email = email;
            this.client = client;
            this.isRely = isRely;
            this.UserMail = UserMail;
        }

        private void SendMail_Load(object sender, EventArgs e)
        {
            if (isRely == 1)
            {
                tbFrom.Text = email.To.Mailboxes.FirstOrDefault()?.Address;
                tbTo.Text = email.From.Mailboxes.FirstOrDefault()?.Address;
                tbSub.Text = "Re: " + email.Subject.ToString();
                rtbBody.Text = "\r\n\n\n\n\n\n\n\n\n"+"---------------------------\r\n"+email.HtmlBody;
            }
            else
            {
                tbFrom.Text = UserMail;
            }


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text));
                message.To.Add(new MailboxAddress("", tbTo.Text));
                message.Subject = tbSub.Text;

                var multipart = new Multipart("mixed");

                string mode = (chbHtml.Checked) ? "html" : "plain";

                var textPart = new TextPart(mode)
                {
                    Text = rtbBody.Text
                };
                multipart.Add(textPart);
                if (tbAttachment.Text != "")
                {
                    var attachment = new MimePart()
                    {
                        Content = new MimeContent(File.OpenRead(tbAttachment.Text)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = System.IO.Path.GetFileName(tbAttachment.Text)
                    };
                    // Thêm đính kèm vào email

                    multipart.Add(attachment);
                    message.Body = multipart;
                }

                client.Send(message);
                MessageBox.Show("Gửi mail thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                tbAttachment.Text = filePath;
            }
        }
    }
}
