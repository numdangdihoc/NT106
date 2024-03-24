namespace Lab3
{
    partial class FormBai1
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
            btn_Client = new Button();
            UDP_Server = new Button();
            SuspendLayout();
            // 
            // btn_Client
            // 
            btn_Client.Location = new Point(163, 181);
            btn_Client.Name = "btn_Client";
            btn_Client.Size = new Size(162, 52);
            btn_Client.TabIndex = 0;
            btn_Client.Text = "UDP Client";
            btn_Client.UseVisualStyleBackColor = true;
            btn_Client.Click += btn_Client_Click;
            // 
            // UDP_Server
            // 
            UDP_Server.Location = new Point(426, 181);
            UDP_Server.Name = "UDP_Server";
            UDP_Server.Size = new Size(162, 52);
            UDP_Server.TabIndex = 0;
            UDP_Server.Text = "UDP Server";
            UDP_Server.UseVisualStyleBackColor = true;
            UDP_Server.Click += UDP_Server_Click;
            // 
            // FormBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UDP_Server);
            Controls.Add(btn_Client);
            Name = "FormBai1";
            Text = "FormBai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Client;
        private Button UDP_Server;
    }
}