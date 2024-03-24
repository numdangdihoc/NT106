namespace Lab2
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
            btn_readfile = new Button();
            btn_writefile = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btn_readfile
            // 
            btn_readfile.Location = new Point(20, 12);
            btn_readfile.Name = "btn_readfile";
            btn_readfile.Size = new Size(120, 57);
            btn_readfile.TabIndex = 1;
            btn_readfile.Text = "Đọc file";
            btn_readfile.UseVisualStyleBackColor = true;
            btn_readfile.Click += btn_readfile_Click;
            // 
            // btn_writefile
            // 
            btn_writefile.Location = new Point(20, 118);
            btn_writefile.Name = "btn_writefile";
            btn_writefile.Size = new Size(120, 57);
            btn_writefile.TabIndex = 1;
            btn_writefile.Text = "Ghi file";
            btn_writefile.UseVisualStyleBackColor = true;
            btn_writefile.Click += btn_writefile_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 255, 255);
            richTextBox1.Location = new Point(236, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(552, 410);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // FormBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_writefile);
            Controls.Add(btn_readfile);
            Controls.Add(richTextBox1);
            Name = "FormBai1";
            Text = "FormBai1";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_readfile;
        private Button btn_writefile;
        private RichTextBox richTextBox1;
    }
}