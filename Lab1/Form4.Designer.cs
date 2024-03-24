namespace Lab1
{
    partial class FormReadNum
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
            label1 = new Label();
            textBox1 = new TextBox();
            tx_kq = new TextBox();
            label2 = new Label();
            btn_read = new Button();
            btn_Del = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 1;
            // 
            // tx_kq
            // 
            tx_kq.Location = new Point(35, 171);
            tx_kq.Name = "tx_kq";
            tx_kq.ReadOnly = true;
            tx_kq.Size = new Size(166, 27);
            tx_kq.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 142);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Kết quả:";
            // 
            // btn_read
            // 
            btn_read.Location = new Point(568, 35);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(117, 83);
            btn_read.TabIndex = 3;
            btn_read.Text = "Đọc";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(568, 143);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(117, 83);
            btn_Del.TabIndex = 3;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(568, 250);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(117, 83);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // FormReadNum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(btn_read);
            Controls.Add(label2);
            Controls.Add(tx_kq);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormReadNum";
            Text = "Đọc số nguyên (Basic)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox tx_kq;
        private Label label2;
        private Button btn_read;
        private Button btn_Del;
        private Button btn_Exit;
    }
}