namespace Lab3
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
            btn_bai1 = new Button();
            btn_bai2 = new Button();
            btn_Bai3 = new Button();
            btn_Bai4 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_bai1
            // 
            btn_bai1.Location = new Point(73, 109);
            btn_bai1.Name = "btn_bai1";
            btn_bai1.Size = new Size(161, 64);
            btn_bai1.TabIndex = 0;
            btn_bai1.Text = "Bài 1";
            btn_bai1.UseVisualStyleBackColor = true;
            btn_bai1.Click += btn_bai1_Click;
            // 
            // btn_bai2
            // 
            btn_bai2.Location = new Point(273, 110);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(158, 63);
            btn_bai2.TabIndex = 1;
            btn_bai2.Text = "Bài 2";
            btn_bai2.UseVisualStyleBackColor = true;
            btn_bai2.Click += btn_bai2_Click;
            // 
            // btn_Bai3
            // 
            btn_Bai3.Location = new Point(506, 109);
            btn_Bai3.Name = "btn_Bai3";
            btn_Bai3.Size = new Size(158, 63);
            btn_Bai3.TabIndex = 1;
            btn_Bai3.Text = "Bài 3";
            btn_Bai3.UseVisualStyleBackColor = true;
            btn_Bai3.Click += btn_Bai3_Click;
            // 
            // btn_Bai4
            // 
            btn_Bai4.Location = new Point(76, 224);
            btn_Bai4.Name = "btn_Bai4";
            btn_Bai4.Size = new Size(158, 63);
            btn_Bai4.TabIndex = 1;
            btn_Bai4.Text = "Bài 4";
            btn_Bai4.UseVisualStyleBackColor = true;
            btn_Bai4.Click += btn_Bai4_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(273, 224);
            button1.Name = "button1";
            button1.Size = new Size(158, 63);
            button1.TabIndex = 1;
            button1.Text = "Bài 5";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Bai5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_Bai4);
            Controls.Add(btn_Bai3);
            Controls.Add(btn_bai2);
            Controls.Add(btn_bai1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_bai1;
        private Button btn_bai2;
        private Button btn_Bai3;
        private Button btn_Bai4;
        private Button button1;
    }
}