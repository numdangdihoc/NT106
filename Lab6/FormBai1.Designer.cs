namespace Lab6
{
    partial class FormBai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbShift = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbPlaintext = new System.Windows.Forms.RichTextBox();
            this.rtbCipher = new System.Windows.Forms.RichTextBox();
            this.rtbDec = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa Caesar";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(346, 28);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(149, 36);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(521, 28);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(149, 36);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dịch(shift)";
            // 
            // tbShift
            // 
            this.tbShift.Location = new System.Drawing.Point(28, 105);
            this.tbShift.Name = "tbShift";
            this.tbShift.Size = new System.Drawing.Size(164, 22);
            this.tbShift.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dữ liệu (Input)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giải mã";
            // 
            // rtbPlaintext
            // 
            this.rtbPlaintext.Location = new System.Drawing.Point(35, 171);
            this.rtbPlaintext.Name = "rtbPlaintext";
            this.rtbPlaintext.Size = new System.Drawing.Size(636, 128);
            this.rtbPlaintext.TabIndex = 4;
            this.rtbPlaintext.Text = "";
            // 
            // rtbCipher
            // 
            this.rtbCipher.Location = new System.Drawing.Point(35, 349);
            this.rtbCipher.Name = "rtbCipher";
            this.rtbCipher.Size = new System.Drawing.Size(636, 128);
            this.rtbCipher.TabIndex = 4;
            this.rtbCipher.Text = "";
            // 
            // rtbDec
            // 
            this.rtbDec.Location = new System.Drawing.Point(34, 524);
            this.rtbDec.Name = "rtbDec";
            this.rtbDec.Size = new System.Drawing.Size(636, 128);
            this.rtbDec.TabIndex = 4;
            this.rtbDec.Text = "";
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 668);
            this.Controls.Add(this.rtbDec);
            this.Controls.Add(this.rtbCipher);
            this.Controls.Add(this.rtbPlaintext);
            this.Controls.Add(this.tbShift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Name = "FormBai1";
            this.Text = "FormBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbPlaintext;
        private System.Windows.Forms.RichTextBox rtbCipher;
        private System.Windows.Forms.RichTextBox rtbDec;
    }
}