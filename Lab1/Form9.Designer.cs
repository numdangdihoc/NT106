namespace Lab1
{
    partial class FormReadNumAdvance
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
            txt_input = new TextBox();
            label2 = new Label();
            btn_read = new Button();
            btn_Del = new Button();
            btn_Exit = new Button();
            txt_result = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 85);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên:";
            // 
            // txt_input
            // 
            txt_input.Location = new Point(244, 82);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(265, 27);
            txt_input.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 121);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 0;
            label2.Text = "(Số nguyên từ 0 đến 99,999)";
            // 
            // btn_read
            // 
            btn_read.Location = new Point(119, 158);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(92, 57);
            btn_read.TabIndex = 2;
            btn_read.Text = "Đọc";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(265, 158);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(92, 57);
            btn_Del.TabIndex = 2;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(417, 158);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(92, 57);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // txt_result
            // 
            txt_result.Location = new Point(244, 241);
            txt_result.Name = "txt_result";
            txt_result.ReadOnly = true;
            txt_result.Size = new Size(410, 27);
            txt_result.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 248);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Kết quả:";
            // 
            // FormReadNumAdvance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_result);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(btn_read);
            Controls.Add(txt_input);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormReadNumAdvance";
            Text = "Đọc số nguyên (Advance)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_input;
        private Label label2;
        private Button btn_read;
        private Button btn_Del;
        private Button btn_Exit;
        private TextBox txt_result;
        private Label label3;
    }
}