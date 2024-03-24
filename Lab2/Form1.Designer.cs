namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_bai1 = new Button();
            btn_bai2 = new Button();
            btn_bai3 = new Button();
            btn_bai4 = new Button();
            btn_bai5 = new Button();
            btn_bai6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(146, 39);
            label1.Name = "label1";
            label1.Size = new Size(577, 54);
            label1.TabIndex = 0;
            label1.Text = "Lab2: File and I/O Stream";
            // 
            // btn_bai1
            // 
            btn_bai1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_bai1.ForeColor = Color.FromArgb(255, 192, 255);
            btn_bai1.Location = new Point(156, 145);
            btn_bai1.Name = "btn_bai1";
            btn_bai1.Size = new Size(119, 43);
            btn_bai1.TabIndex = 1;
            btn_bai1.Text = "Bài 1";
            btn_bai1.UseVisualStyleBackColor = true;
            btn_bai1.Click += btn_bai1_Click;
            // 
            // btn_bai2
            // 
            btn_bai2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_bai2.ForeColor = Color.FromArgb(255, 192, 255);
            btn_bai2.Location = new Point(327, 145);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(119, 43);
            btn_bai2.TabIndex = 1;
            btn_bai2.Text = "Bài 2";
            btn_bai2.UseVisualStyleBackColor = true;
            btn_bai2.Click += btn_bai2_Click;
            // 
            // btn_bai3
            // 
            btn_bai3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_bai3.ForeColor = Color.FromArgb(255, 192, 255);
            btn_bai3.Location = new Point(526, 145);
            btn_bai3.Name = "btn_bai3";
            btn_bai3.Size = new Size(119, 43);
            btn_bai3.TabIndex = 1;
            btn_bai3.Text = "Bài 3";
            btn_bai3.UseVisualStyleBackColor = true;
            btn_bai3.Click += btn_bai3_Click;
            // 
            // btn_bai4
            // 
            btn_bai4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_bai4.ForeColor = Color.FromArgb(255, 192, 255);
            btn_bai4.Location = new Point(156, 232);
            btn_bai4.Name = "btn_bai4";
            btn_bai4.Size = new Size(119, 43);
            btn_bai4.TabIndex = 1;
            btn_bai4.Text = "Bài 4";
            btn_bai4.UseVisualStyleBackColor = true;
            btn_bai4.Click += btn_bai4_Click;
            // 
            // btn_bai5
            // 
            btn_bai5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_bai5.ForeColor = Color.FromArgb(255, 192, 255);
            btn_bai5.Location = new Point(327, 232);
            btn_bai5.Name = "btn_bai5";
            btn_bai5.Size = new Size(119, 43);
            btn_bai5.TabIndex = 1;
            btn_bai5.Text = "Bài 5";
            btn_bai5.UseVisualStyleBackColor = true;
            btn_bai5.Click += btn_bai5_Click;
            // 
            // btn_bai6
            // 
            btn_bai6.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_bai6.ForeColor = Color.FromArgb(255, 192, 255);
            btn_bai6.Location = new Point(526, 232);
            btn_bai6.Name = "btn_bai6";
            btn_bai6.Size = new Size(119, 43);
            btn_bai6.TabIndex = 1;
            btn_bai6.Text = "Bài 6";
            btn_bai6.UseVisualStyleBackColor = true;
            btn_bai6.Click += btn_bai6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(823, 420);
            Controls.Add(btn_bai6);
            Controls.Add(btn_bai5);
            Controls.Add(btn_bai4);
            Controls.Add(btn_bai3);
            Controls.Add(btn_bai2);
            Controls.Add(btn_bai1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_bai1;
        private Button btn_bai2;
        private Button btn_bai3;
        private Button btn_bai4;
        private Button btn_bai5;
        private Button btn_bai6;
    }
}