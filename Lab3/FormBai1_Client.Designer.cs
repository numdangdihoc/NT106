namespace Lab3
{
    partial class FormBai1_Client
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
            txt_IP = new TextBox();
            txt_Port = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_IP
            // 
            txt_IP.Location = new Point(103, 82);
            txt_IP.Name = "txt_IP";
            txt_IP.Size = new Size(269, 27);
            txt_IP.TabIndex = 0;
            // 
            // txt_Port
            // 
            txt_Port.Location = new Point(471, 82);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(198, 27);
            txt_Port.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 89);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Địa chỉ IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 85);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 152);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(638, 131);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(30, 312);
            button1.Name = "button1";
            button1.Size = new Size(125, 62);
            button1.TabIndex = 5;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormBai1_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Port);
            Controls.Add(txt_IP);
            Name = "FormBai1_Client";
            Text = "FormBai1_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_IP;
        private TextBox txt_Port;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}