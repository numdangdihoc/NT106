namespace Lab3
{
    partial class FormBai3TCP_Client
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
            btn_Con = new Button();
            btn_send = new Button();
            btn_discon = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Con
            // 
            btn_Con.Location = new Point(558, 134);
            btn_Con.Name = "btn_Con";
            btn_Con.Size = new Size(163, 50);
            btn_Con.TabIndex = 0;
            btn_Con.Text = "Connect";
            btn_Con.UseVisualStyleBackColor = true;
            btn_Con.Click += btn_Con_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(558, 190);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(163, 50);
            btn_send.TabIndex = 0;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_discon
            // 
            btn_discon.Location = new Point(558, 246);
            btn_discon.Name = "btn_discon";
            btn_discon.Size = new Size(163, 50);
            btn_discon.TabIndex = 0;
            btn_discon.Text = "Disconnect";
            btn_discon.UseVisualStyleBackColor = true;
            btn_discon.Click += btn_discon_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(50, 134);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(488, 163);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // FormBai3TCP_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btn_discon);
            Controls.Add(btn_send);
            Controls.Add(btn_Con);
            Name = "FormBai3TCP_Client";
            Text = "FormBai3TCP_Client";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Con;
        private Button btn_send;
        private Button btn_discon;
        private RichTextBox richTextBox1;
    }
}