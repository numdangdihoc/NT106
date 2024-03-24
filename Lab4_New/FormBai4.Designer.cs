namespace Lab4_New
{
    partial class FormBai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnImgDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(17, 27);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(944, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // btnViewSource
            // 
            this.btnViewSource.Location = new System.Drawing.Point(967, 19);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(102, 30);
            this.btnViewSource.TabIndex = 1;
            this.btnViewSource.Text = "View Source";
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(1075, 19);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(111, 30);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(17, 83);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1162, 539);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // btnImgDownload
            // 
            this.btnImgDownload.Location = new System.Drawing.Point(979, 55);
            this.btnImgDownload.Name = "btnImgDownload";
            this.btnImgDownload.Size = new System.Drawing.Size(200, 21);
            this.btnImgDownload.TabIndex = 3;
            this.btnImgDownload.Text = "Download img";
            this.btnImgDownload.UseVisualStyleBackColor = true;
            this.btnImgDownload.Click += new System.EventHandler(this.btnImgDownload_Click);
            // 
            // FormBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 625);
            this.Controls.Add(this.btnImgDownload);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.txtUrl);
            this.Name = "FormBai4";
            this.Text = "FormBai4";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.Button btn_Download;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnImgDownload;
    }
}