namespace Lab2
{
    partial class FormBai5
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
            btn_save = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            btn_Decompress = new Button();
            btn_OpenFile = new Button();
            txt_url = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.Location = new Point(117, 359);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(204, 44);
            btn_save.TabIndex = 0;
            btn_save.Text = "Save File and Compress";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(49, 122);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(346, 218);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(414, 122);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(346, 218);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // btn_Decompress
            // 
            btn_Decompress.Location = new Point(414, 359);
            btn_Decompress.Name = "btn_Decompress";
            btn_Decompress.Size = new Size(158, 44);
            btn_Decompress.TabIndex = 0;
            btn_Decompress.Text = "Decompress";
            btn_Decompress.UseVisualStyleBackColor = true;
            btn_Decompress.Click += btn_Decompress_Click;
            // 
            // btn_OpenFile
            // 
            btn_OpenFile.Location = new Point(602, 359);
            btn_OpenFile.Name = "btn_OpenFile";
            btn_OpenFile.Size = new Size(158, 44);
            btn_OpenFile.TabIndex = 0;
            btn_OpenFile.Text = "ReadFile";
            btn_OpenFile.UseVisualStyleBackColor = true;
            btn_OpenFile.Click += btn_OpenFile_Click;
            // 
            // txt_url
            // 
            txt_url.Location = new Point(73, 68);
            txt_url.Name = "txt_url";
            txt_url.ReadOnly = true;
            txt_url.Size = new Size(322, 27);
            txt_url.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 71);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 98);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhập nội dung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 98);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 3;
            label3.Text = "Nội dung file output5.txt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 255);
            label4.Location = new Point(315, 22);
            label4.Name = "label4";
            label4.Size = new Size(145, 43);
            label4.TabIndex = 3;
            label4.Text = "ZipFile";
            // 
            // FormBai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_url);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(btn_Decompress);
            Controls.Add(btn_OpenFile);
            Controls.Add(btn_save);
            Name = "FormBai5";
            Text = "FormBai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button btn_Decompress;
        private Button btn_OpenFile;
        private TextBox txt_url;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}