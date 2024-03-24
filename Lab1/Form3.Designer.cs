namespace Lab1
{
    partial class FormMaxMin
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
            tx_so1 = new TextBox();
            tx_so2 = new TextBox();
            tx_so3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tx_res_max = new TextBox();
            tx_res_min = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 38);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 38);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Số thứ 3";
            // 
            // tx_so1
            // 
            tx_so1.Location = new Point(120, 36);
            tx_so1.Name = "tx_so1";
            tx_so1.Size = new Size(125, 27);
            tx_so1.TabIndex = 1;
            // 
            // tx_so2
            // 
            tx_so2.Location = new Point(372, 38);
            tx_so2.Name = "tx_so2";
            tx_so2.Size = new Size(125, 27);
            tx_so2.TabIndex = 1;
            // 
            // tx_so3
            // 
            tx_so3.Location = new Point(612, 36);
            tx_so3.Name = "tx_so3";
            tx_so3.Size = new Size(125, 27);
            tx_so3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(102, 142);
            button1.Name = "button1";
            button1.Size = new Size(129, 69);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(323, 142);
            button2.Name = "button2";
            button2.Size = new Size(129, 69);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(558, 142);
            button3.Name = "button3";
            button3.Size = new Size(129, 69);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tx_res_max
            // 
            tx_res_max.Location = new Point(135, 328);
            tx_res_max.Name = "tx_res_max";
            tx_res_max.ReadOnly = true;
            tx_res_max.Size = new Size(136, 27);
            tx_res_max.TabIndex = 3;
            // 
            // tx_res_min
            // 
            tx_res_min.Location = new Point(499, 328);
            tx_res_min.Name = "tx_res_min";
            tx_res_min.ReadOnly = true;
            tx_res_min.Size = new Size(136, 27);
            tx_res_min.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 331);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 331);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Số bé nhất";
            // 
            // FormMaxMin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tx_res_min);
            Controls.Add(tx_res_max);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tx_so3);
            Controls.Add(tx_so2);
            Controls.Add(tx_so1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMaxMin";
            Text = "SoLonNhat_BeNhat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tx_so1;
        private TextBox tx_so2;
        private TextBox tx_so3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox tx_res_max;
        private TextBox tx_res_min;
        private Label label4;
        private Label label5;
    }
}