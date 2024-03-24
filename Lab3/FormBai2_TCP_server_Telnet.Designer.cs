namespace Lab3
{
    partial class FormBai2_TCP_server_Telnet
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
            btn_listen = new Button();
            txt_port = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(519, 41);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(164, 39);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += button1_Click;
            // 
            // txt_port
            // 
            txt_port.Location = new Point(105, 53);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(187, 27);
            txt_port.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(105, 114);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(578, 259);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // FormBai2_TCP_server_Telnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(txt_port);
            Controls.Add(btn_listen);
            Name = "FormBai2_TCP_server_Telnet";
            Text = "FormBai2_TCP_server_Telnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox txt_port;
        private RichTextBox richTextBox1;
    }
}