namespace Lab1
{
    partial class FormSum2num
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txt_result = new TextBox();
            txt_so2 = new TextBox();
            txt_so1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(637, 81);
            label1.TabIndex = 0;
            label1.Text = "Tính Tổng 2 số nguyên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 126);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập số thứ 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 192);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 1;
            label3.Text = "Nhập số thứ 2";
            // 
            // button1
            // 
            button1.Location = new Point(173, 295);
            button1.Name = "button1";
            button1.Size = new Size(107, 56);
            button1.TabIndex = 3;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_result
            // 
            txt_result.Location = new Point(296, 235);
            txt_result.Name = "txt_result";
            txt_result.ReadOnly = true;
            txt_result.Size = new Size(145, 27);
            txt_result.TabIndex = 4;
            txt_result.TextChanged += textBox3_TextChanged;
            // 
            // txt_so2
            // 
            txt_so2.Location = new Point(173, 187);
            txt_so2.Name = "txt_so2";
            txt_so2.Size = new Size(268, 27);
            txt_so2.TabIndex = 5;
            // 
            // txt_so1
            // 
            txt_so1.Location = new Point(173, 119);
            txt_so1.Name = "txt_so1";
            txt_so1.Size = new Size(268, 27);
            txt_so1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 242);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 1;
            label4.Text = "Kết quả:";
            // 
            // FormSum2num
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_so1);
            Controls.Add(txt_so2);
            Controls.Add(txt_result);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSum2num";
            Text = "Tính tổng 2 số nguyên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txt_result;
        private TextBox txt_so2;
        private TextBox txt_so1;
        private Label label4;
    }
}