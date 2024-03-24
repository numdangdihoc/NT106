namespace Lab1
{
    partial class FormInfoSV
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
            txt_input = new TextBox();
            btn_Output = new Button();
            txt_HoTen = new TextBox();
            label1 = new Label();
            txt_Mark = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_max = new TextBox();
            txt_min = new TextBox();
            label5 = new Label();
            txt_DTB = new TextBox();
            label6 = new Label();
            txt_SoMonDau = new TextBox();
            txt_SoMonKhongDau = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txt_XL = new TextBox();
            label9 = new Label();
            btn_Del = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // txt_input
            // 
            txt_input.Location = new Point(61, 61);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(456, 27);
            txt_input.TabIndex = 0;
            // 
            // btn_Output
            // 
            btn_Output.Location = new Point(61, 94);
            btn_Output.Name = "btn_Output";
            btn_Output.Size = new Size(100, 65);
            btn_Output.TabIndex = 1;
            btn_Output.Text = "Xuất thông tin";
            btn_Output.UseVisualStyleBackColor = true;
            btn_Output.Click += button1_Click;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(148, 164);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.ReadOnly = true;
            txt_HoTen.Size = new Size(198, 27);
            txt_HoTen.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 167);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Họ và Tên";
            // 
            // txt_Mark
            // 
            txt_Mark.Location = new Point(149, 207);
            txt_Mark.Name = "txt_Mark";
            txt_Mark.ReadOnly = true;
            txt_Mark.Size = new Size(598, 27);
            txt_Mark.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 210);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "Điểm thành phần";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 263);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 3;
            label3.Text = "Điểm lớn nhất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 263);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Điểm nhỏ nhất";
            // 
            // txt_max
            // 
            txt_max.Location = new Point(149, 256);
            txt_max.Name = "txt_max";
            txt_max.ReadOnly = true;
            txt_max.Size = new Size(119, 27);
            txt_max.TabIndex = 5;
            // 
            // txt_min
            // 
            txt_min.Location = new Point(398, 256);
            txt_min.Name = "txt_min";
            txt_min.ReadOnly = true;
            txt_min.Size = new Size(119, 27);
            txt_min.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 263);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 3;
            label5.Text = "Đểm trung bình";
            // 
            // txt_DTB
            // 
            txt_DTB.Location = new Point(642, 260);
            txt_DTB.Name = "txt_DTB";
            txt_DTB.ReadOnly = true;
            txt_DTB.Size = new Size(105, 27);
            txt_DTB.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 310);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 3;
            label6.Text = "Số môn đậu";
            // 
            // txt_SoMonDau
            // 
            txt_SoMonDau.Location = new Point(149, 303);
            txt_SoMonDau.Name = "txt_SoMonDau";
            txt_SoMonDau.ReadOnly = true;
            txt_SoMonDau.Size = new Size(67, 27);
            txt_SoMonDau.TabIndex = 5;
            // 
            // txt_SoMonKhongDau
            // 
            txt_SoMonKhongDau.Location = new Point(362, 303);
            txt_SoMonKhongDau.Name = "txt_SoMonKhongDau";
            txt_SoMonKhongDau.ReadOnly = true;
            txt_SoMonKhongDau.Size = new Size(67, 27);
            txt_SoMonKhongDau.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 310);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 3;
            label7.Text = "Số môn không đậu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 310);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 3;
            label8.Text = "Xếp loại";
            // 
            // txt_XL
            // 
            txt_XL.Location = new Point(514, 307);
            txt_XL.Name = "txt_XL";
            txt_XL.ReadOnly = true;
            txt_XL.Size = new Size(122, 27);
            txt_XL.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(213, 9);
            label9.Name = "label9";
            label9.Size = new Size(364, 31);
            label9.TabIndex = 6;
            label9.Text = "Nhập thông tin sinh viên , điểm số";
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(246, 94);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(100, 65);
            btn_Del.TabIndex = 7;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(417, 94);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(100, 65);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // FormInfoSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(label9);
            Controls.Add(txt_DTB);
            Controls.Add(txt_min);
            Controls.Add(txt_XL);
            Controls.Add(txt_SoMonKhongDau);
            Controls.Add(txt_SoMonDau);
            Controls.Add(txt_max);
            Controls.Add(txt_Mark);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_HoTen);
            Controls.Add(btn_Output);
            Controls.Add(txt_input);
            Name = "FormInfoSV";
            Text = "InforSV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_input;
        private Button btn_Output;
        private TextBox txt_HoTen;
        private Label label1;
        private TextBox txt_Mark;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_max;
        private TextBox txt_min;
        private Label label5;
        private TextBox txt_DTB;
        private Label label6;
        private TextBox txt_SoMonDau;
        private TextBox txt_SoMonKhongDau;
        private Label label7;
        private Label label8;
        private TextBox txt_XL;
        private Label label9;
        private Button btn_Del;
        private Button btn_Exit;
    }
}