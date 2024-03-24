namespace Lab1
{
    partial class FormCalc2int
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
            tx_B = new TextBox();
            tx_A = new TextBox();
            btn_Tinh = new Button();
            btn_Del = new Button();
            btn_Exit = new Button();
            tx_res = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 81);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhập B:";
            // 
            // tx_B
            // 
            tx_B.Location = new Point(480, 77);
            tx_B.Name = "tx_B";
            tx_B.Size = new Size(270, 27);
            tx_B.TabIndex = 1;
            // 
            // tx_A
            // 
            tx_A.Location = new Point(101, 77);
            tx_A.Name = "tx_A";
            tx_A.Size = new Size(270, 27);
            tx_A.TabIndex = 1;
            // 
            // btn_Tinh
            // 
            btn_Tinh.Location = new Point(27, 146);
            btn_Tinh.Name = "btn_Tinh";
            btn_Tinh.Size = new Size(349, 38);
            btn_Tinh.TabIndex = 2;
            btn_Tinh.Text = "Tính các giá trị";
            btn_Tinh.UseVisualStyleBackColor = true;
            btn_Tinh.Click += btn_Tinh_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(408, 146);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(123, 38);
            btn_Del.TabIndex = 2;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(577, 146);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(123, 38);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // tx_res
            // 
            tx_res.Location = new Point(27, 205);
            tx_res.Multiline = true;
            tx_res.Name = "tx_res";
            tx_res.ReadOnly = true;
            tx_res.Size = new Size(723, 215);
            tx_res.TabIndex = 3;
            // 
            // FormCalc2int
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tx_res);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(btn_Tinh);
            Controls.Add(tx_A);
            Controls.Add(tx_B);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCalc2int";
            Text = "Tính toán A và B";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tx_B;
        private TextBox tx_A;
        private Button btn_Tinh;
        private Button btn_Del;
        private Button btn_Exit;
        private TextBox tx_res;
    }
}