namespace Lab2
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
            richTextBox1 = new RichTextBox();
            btn_write = new Button();
            btn_read = new Button();
            btn_add = new Button();
            btn_back = new Button();
            btn_next = new Button();
            label_num = new Label();
            txt_nameW = new TextBox();
            txt_idW = new TextBox();
            txt_PhoneW = new TextBox();
            txt_C1W = new TextBox();
            txt_C2W = new TextBox();
            txt_C3W = new TextBox();
            txt_AveW = new TextBox();
            txt_NameR = new TextBox();
            txt_idR = new TextBox();
            txt_PhoneR = new TextBox();
            txt_C1R = new TextBox();
            txt_C2R = new TextBox();
            txt_C3R = new TextBox();
            txt_AveR = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 192, 255);
            richTextBox1.ForeColor = SystemColors.InactiveCaptionText;
            richTextBox1.Location = new Point(322, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(326, 495);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btn_write
            // 
            btn_write.Location = new Point(12, 12);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(279, 49);
            btn_write.TabIndex = 1;
            btn_write.Text = "Write to a file";
            btn_write.UseVisualStyleBackColor = true;
            btn_write.Click += btn_write_Click;
            // 
            // btn_read
            // 
            btn_read.Location = new Point(674, 12);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(279, 49);
            btn_read.TabIndex = 1;
            btn_read.Text = "Button to read a file";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(51, 464);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(141, 35);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(674, 472);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(106, 35);
            btn_back.TabIndex = 1;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(847, 472);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(106, 35);
            btn_next.TabIndex = 1;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // label_num
            // 
            label_num.AutoSize = true;
            label_num.Location = new Point(807, 479);
            label_num.Name = "label_num";
            label_num.Size = new Size(17, 20);
            label_num.TabIndex = 2;
            label_num.Text = "1";
            // 
            // txt_nameW
            // 
            txt_nameW.Location = new Point(17, 65);
            txt_nameW.Name = "txt_nameW";
            txt_nameW.Size = new Size(193, 27);
            txt_nameW.TabIndex = 3;
            // 
            // txt_idW
            // 
            txt_idW.Location = new Point(17, 123);
            txt_idW.Name = "txt_idW";
            txt_idW.Size = new Size(193, 27);
            txt_idW.TabIndex = 3;
            // 
            // txt_PhoneW
            // 
            txt_PhoneW.Location = new Point(17, 182);
            txt_PhoneW.Name = "txt_PhoneW";
            txt_PhoneW.Size = new Size(193, 27);
            txt_PhoneW.TabIndex = 3;
            // 
            // txt_C1W
            // 
            txt_C1W.Location = new Point(17, 242);
            txt_C1W.Name = "txt_C1W";
            txt_C1W.Size = new Size(193, 27);
            txt_C1W.TabIndex = 3;
            // 
            // txt_C2W
            // 
            txt_C2W.Location = new Point(17, 304);
            txt_C2W.Name = "txt_C2W";
            txt_C2W.Size = new Size(193, 27);
            txt_C2W.TabIndex = 3;
            // 
            // txt_C3W
            // 
            txt_C3W.Location = new Point(17, 365);
            txt_C3W.Name = "txt_C3W";
            txt_C3W.Size = new Size(193, 27);
            txt_C3W.TabIndex = 3;
            // 
            // txt_AveW
            // 
            txt_AveW.Location = new Point(17, 420);
            txt_AveW.Name = "txt_AveW";
            txt_AveW.ReadOnly = true;
            txt_AveW.Size = new Size(193, 27);
            txt_AveW.TabIndex = 3;
            // 
            // txt_NameR
            // 
            txt_NameR.Location = new Point(674, 65);
            txt_NameR.Name = "txt_NameR";
            txt_NameR.ReadOnly = true;
            txt_NameR.Size = new Size(193, 27);
            txt_NameR.TabIndex = 3;
            // 
            // txt_idR
            // 
            txt_idR.Location = new Point(674, 123);
            txt_idR.Name = "txt_idR";
            txt_idR.ReadOnly = true;
            txt_idR.Size = new Size(193, 27);
            txt_idR.TabIndex = 3;
            // 
            // txt_PhoneR
            // 
            txt_PhoneR.Location = new Point(674, 182);
            txt_PhoneR.Name = "txt_PhoneR";
            txt_PhoneR.ReadOnly = true;
            txt_PhoneR.Size = new Size(193, 27);
            txt_PhoneR.TabIndex = 3;
            // 
            // txt_C1R
            // 
            txt_C1R.Location = new Point(674, 242);
            txt_C1R.Name = "txt_C1R";
            txt_C1R.ReadOnly = true;
            txt_C1R.Size = new Size(193, 27);
            txt_C1R.TabIndex = 3;
            // 
            // txt_C2R
            // 
            txt_C2R.Location = new Point(674, 304);
            txt_C2R.Name = "txt_C2R";
            txt_C2R.ReadOnly = true;
            txt_C2R.Size = new Size(193, 27);
            txt_C2R.TabIndex = 3;
            // 
            // txt_C3R
            // 
            txt_C3R.Location = new Point(674, 365);
            txt_C3R.Name = "txt_C3R";
            txt_C3R.ReadOnly = true;
            txt_C3R.Size = new Size(193, 27);
            txt_C3R.TabIndex = 3;
            // 
            // txt_AveR
            // 
            txt_AveR.Location = new Point(674, 420);
            txt_AveR.Name = "txt_AveR";
            txt_AveR.ReadOnly = true;
            txt_AveR.Size = new Size(193, 27);
            txt_AveR.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 72);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 130);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 189);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 249);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 2;
            label5.Text = "Course 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 311);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 2;
            label6.Text = "Course 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 372);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 2;
            label7.Text = "Course 3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(902, 72);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 2;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(927, 130);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 2;
            label9.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(901, 189);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 2;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(888, 249);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 2;
            label11.Text = "Course 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(887, 311);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 2;
            label12.Text = "Course 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(887, 372);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 2;
            label13.Text = "Course 3";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(215, 427);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 2;
            label14.Text = "Average";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(890, 427);
            label15.Name = "label15";
            label15.Size = new Size(64, 20);
            label15.TabIndex = 2;
            label15.Text = "Average";
            // 
            // FormBai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 540);
            Controls.Add(txt_AveR);
            Controls.Add(txt_C3R);
            Controls.Add(txt_AveW);
            Controls.Add(txt_C2R);
            Controls.Add(txt_C3W);
            Controls.Add(txt_C1R);
            Controls.Add(txt_C2W);
            Controls.Add(txt_PhoneR);
            Controls.Add(txt_C1W);
            Controls.Add(txt_idR);
            Controls.Add(txt_PhoneW);
            Controls.Add(txt_NameR);
            Controls.Add(txt_idW);
            Controls.Add(txt_nameW);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_num);
            Controls.Add(btn_read);
            Controls.Add(btn_next);
            Controls.Add(btn_back);
            Controls.Add(btn_add);
            Controls.Add(btn_write);
            Controls.Add(richTextBox1);
            Name = "FormBai4";
            Text = "FormBai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_write;
        private Button btn_read;
        private Button btn_add;
        private Button btn_back;
        private Button btn_next;
        private Label label_num;
        private TextBox txt_nameW;
        private TextBox txt_idW;
        private TextBox txt_PhoneW;
        private TextBox txt_C1W;
        private TextBox txt_C2W;
        private TextBox txt_C3W;
        private TextBox txt_AveW;
        private TextBox txt_NameR;
        private TextBox txt_idR;
        private TextBox txt_PhoneR;
        private TextBox txt_C1R;
        private TextBox txt_C2R;
        private TextBox txt_C3R;
        private TextBox txt_AveR;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}