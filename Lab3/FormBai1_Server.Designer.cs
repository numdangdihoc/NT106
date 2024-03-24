namespace Lab3
{
    partial class FormBai1_Server
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
            txt_port = new TextBox();
            btn_listen = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // txt_port
            // 
            txt_port.Location = new Point(94, 43);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(177, 27);
            txt_port.TabIndex = 0;
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(531, 37);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(144, 33);
            btn_listen.TabIndex = 1;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(44, 109);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(625, 282);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // FormBai1_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btn_listen);
            Controls.Add(txt_port);
            Name = "FormBai1_Server";
            Text = "FormBai1_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_port;
        private Button btn_listen;
        private RichTextBox richTextBox1;
    }
}