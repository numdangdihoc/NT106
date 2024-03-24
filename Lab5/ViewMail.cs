using MailKit.Net.Smtp;
using Microsoft.Web.WebView2.Core;
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

namespace Lab5
{
    public partial class ViewMail : Form
    {
        private MimeMessage email;
        private SmtpClient client;
        public ViewMail(MimeMessage email, SmtpClient client)
        {
            InitializeComponent();
            this.email = email;
            this.client = client;
            webView21.CoreWebView2InitializationCompleted += WebView21_CoreWebView2InitializationCompleted;
            tbFrom.Text = email.From.ToString();
            tbTo.Text = email.To.ToString();


        }

        private void WebView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                var builder = new BodyBuilder();
                builder.HtmlBody = "<html><body>" + email.HtmlBody + "</body></html>";
                
                // Gán nội dung email vào WebView21
                webView21.CoreWebView2.NavigateToString(builder.HtmlBody);
            }
        }
       

        private async void ViewMail_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            SendMail sendmail = new SendMail(client,this.email,1,"");
            sendmail.Show();
        }
    }
}
