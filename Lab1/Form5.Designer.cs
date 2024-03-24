namespace Lab1
{
    partial class FormPetro
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
            label4 = new Label();
            tx_Km_Go = new TextBox();
            tx_Money = new TextBox();
            cmb_loaixe = new ComboBox();
            cmb_loaixang = new ComboBox();
            button1 = new Button();
            btn_DEL = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn Loại Xe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 44);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 0;
            label2.Text = "Chọn loại xăng cần đổ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 178);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 1;
            label3.Text = "Số Km đi được:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 276);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 1;
            label4.Text = "Số tiền cần trả:";
            // 
            // tx_Km_Go
            // 
            tx_Km_Go.Location = new Point(168, 178);
            tx_Km_Go.Name = "tx_Km_Go";
            tx_Km_Go.ReadOnly = true;
            tx_Km_Go.Size = new Size(248, 27);
            tx_Km_Go.TabIndex = 2;
            // 
            // tx_Money
            // 
            tx_Money.Location = new Point(168, 276);
            tx_Money.Name = "tx_Money";
            tx_Money.ReadOnly = true;
            tx_Money.Size = new Size(248, 27);
            tx_Money.TabIndex = 2;
            // 
            // cmb_loaixe
            // 
            cmb_loaixe.FormattingEnabled = true;
            cmb_loaixe.Location = new Point(150, 41);
            cmb_loaixe.Name = "cmb_loaixe";
            cmb_loaixe.Size = new Size(212, 28);
            cmb_loaixe.TabIndex = 3;
            // 
            // cmb_loaixang
            // 
            cmb_loaixang.FormattingEnabled = true;
            cmb_loaixang.Location = new Point(531, 41);
            cmb_loaixang.Name = "cmb_loaixang";
            cmb_loaixang.Size = new Size(212, 28);
            cmb_loaixang.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(555, 158);
            button1.Name = "button1";
            button1.Size = new Size(104, 61);
            button1.TabIndex = 4;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_DEL
            // 
            btn_DEL.Location = new Point(555, 259);
            btn_DEL.Name = "btn_DEL";
            btn_DEL.Size = new Size(104, 61);
            btn_DEL.TabIndex = 5;
            btn_DEL.Text = "Xóa";
            btn_DEL.UseVisualStyleBackColor = true;
            btn_DEL.Click += btn_DEL_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 183);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 6;
            label5.Text = "Km";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(427, 283);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 6;
            label6.Text = "VND";
            // 
            // FormPetro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_DEL);
            Controls.Add(button1);
            Controls.Add(cmb_loaixang);
            Controls.Add(cmb_loaixe);
            Controls.Add(tx_Money);
            Controls.Add(tx_Km_Go);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPetro";
            Text = "Tính toán Xăng dầu";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tx_Km_Go;
        private TextBox tx_Money;
        private ComboBox cmb_loaixe;
        private ComboBox cmb_loaixang;
        private Button button1;
        private Button btn_DEL;
        private Label label5;
        private Label label6;
    }
}