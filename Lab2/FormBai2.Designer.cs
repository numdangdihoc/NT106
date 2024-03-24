namespace Lab2
{
    partial class FormBai2
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
            btn_readfile = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_fileName = new TextBox();
            txt_size = new TextBox();
            txt_url = new TextBox();
            txt_linecount = new TextBox();
            txt_wordcount = new TextBox();
            txt_charactercount = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btn_readfile
            // 
            btn_readfile.BackColor = SystemColors.ActiveCaptionText;
            btn_readfile.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_readfile.ForeColor = Color.FromArgb(255, 128, 255);
            btn_readfile.Location = new Point(30, 26);
            btn_readfile.Name = "btn_readfile";
            btn_readfile.Size = new Size(388, 40);
            btn_readfile.TabIndex = 0;
            btn_readfile.Text = "Read from file";
            btn_readfile.UseVisualStyleBackColor = false;
            btn_readfile.Click += btn_readfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 88);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 142);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 199);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 1;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 264);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 1;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 331);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 1;
            label5.Text = "Word count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 399);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 1;
            label6.Text = "Character count";
            // 
            // txt_fileName
            // 
            txt_fileName.BackColor = Color.FromArgb(192, 255, 255);
            txt_fileName.Location = new Point(160, 85);
            txt_fileName.Name = "txt_fileName";
            txt_fileName.ReadOnly = true;
            txt_fileName.Size = new Size(258, 27);
            txt_fileName.TabIndex = 2;
            // 
            // txt_size
            // 
            txt_size.BackColor = Color.FromArgb(192, 255, 255);
            txt_size.Location = new Point(160, 135);
            txt_size.Name = "txt_size";
            txt_size.ReadOnly = true;
            txt_size.Size = new Size(258, 27);
            txt_size.TabIndex = 2;
            // 
            // txt_url
            // 
            txt_url.BackColor = Color.FromArgb(192, 255, 255);
            txt_url.Location = new Point(160, 192);
            txt_url.Name = "txt_url";
            txt_url.ReadOnly = true;
            txt_url.Size = new Size(258, 27);
            txt_url.TabIndex = 2;
            // 
            // txt_linecount
            // 
            txt_linecount.BackColor = Color.FromArgb(192, 255, 255);
            txt_linecount.Location = new Point(160, 257);
            txt_linecount.Name = "txt_linecount";
            txt_linecount.ReadOnly = true;
            txt_linecount.Size = new Size(258, 27);
            txt_linecount.TabIndex = 2;
            // 
            // txt_wordcount
            // 
            txt_wordcount.BackColor = Color.FromArgb(192, 255, 255);
            txt_wordcount.Location = new Point(160, 324);
            txt_wordcount.Name = "txt_wordcount";
            txt_wordcount.ReadOnly = true;
            txt_wordcount.Size = new Size(258, 27);
            txt_wordcount.TabIndex = 2;
            // 
            // txt_charactercount
            // 
            txt_charactercount.BackColor = Color.FromArgb(192, 255, 255);
            txt_charactercount.Location = new Point(160, 392);
            txt_charactercount.Name = "txt_charactercount";
            txt_charactercount.ReadOnly = true;
            txt_charactercount.Size = new Size(258, 27);
            txt_charactercount.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 255, 255);
            richTextBox1.Location = new Point(432, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(356, 392);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // FormBai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(txt_charactercount);
            Controls.Add(txt_wordcount);
            Controls.Add(txt_linecount);
            Controls.Add(txt_url);
            Controls.Add(txt_size);
            Controls.Add(txt_fileName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_readfile);
            Name = "FormBai2";
            Text = "FormBai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_readfile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_fileName;
        private TextBox txt_size;
        private TextBox txt_url;
        private TextBox txt_linecount;
        private TextBox txt_wordcount;
        private TextBox txt_charactercount;
        private RichTextBox richTextBox1;
    }
}