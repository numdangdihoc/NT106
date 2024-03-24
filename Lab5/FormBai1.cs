using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace Lab5
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
            tbSub.Text = "Subject";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // using mailkit
            var smtpClient = new MailKit.Net.Smtp.SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, SecureSocketOptions.Auto);
            
            try
            {
                smtpClient.Authenticate(tbFrom.Text, tbPass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test", tbFrom.Text));
            message.To.Add(new MailboxAddress("", tbTo.Text));
            message.Subject = tbSub.Text;
            message.Body = new TextPart("plain")
            {
                Text = rtbBody.Text
            };
            // send mail
            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Đã gửi mail thành công !");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
            /*using (System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("127.0.0.1"))
            {
                string mailfrom = tbFrom.Text.ToString().Trim();
                string mailto = tbTo.Text.ToString().Trim();
                string password = tbPass.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = tbSub.Text.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = rtbBody.Text.ToString();
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }*/
        } 

        
    }
}
