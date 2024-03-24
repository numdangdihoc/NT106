namespace Lab3
{
    partial class Bai5_Client
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
            textBoxLog = new TextBox();
            textBoxMessage = new TextBox();
            textBoxUserName = new TextBox();
            buttonSend = new Button();
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            SuspendLayout();
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(31, 54);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(728, 239);
            textBoxLog.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(31, 372);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(610, 37);
            textBoxMessage.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(31, 324);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(192, 27);
            textBoxUserName.TabIndex = 2;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(664, 372);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(76, 37);
            buttonSend.TabIndex = 3;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(242, 323);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(109, 28);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new Point(370, 323);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(128, 28);
            buttonDisconnect.TabIndex = 5;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // Bai4_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonConnect);
            Controls.Add(buttonSend);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxMessage);
            Controls.Add(textBoxLog);
            Name = "Bai4_Client";
            Text = "Bai4_Client";
            Load += Bai4_Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLog;
        private TextBox textBoxMessage;
        private TextBox textBoxUserName;
        private Button buttonSend;
        private Button buttonConnect;
        private Button buttonDisconnect;
    }
}