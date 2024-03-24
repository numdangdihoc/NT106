namespace Lab6
{
    partial class FormBai2
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
            this.rtbDec = new System.Windows.Forms.RichTextBox();
            this.rtbCipher = new System.Windows.Forms.RichTextBox();
            this.rtbPlaintext = new System.Windows.Forms.RichTextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbDec
            // 
            this.rtbDec.Location = new System.Drawing.Point(85, 533);
            this.rtbDec.Name = "rtbDec";
            this.rtbDec.Size = new System.Drawing.Size(636, 128);
            this.rtbDec.TabIndex = 13;
            this.rtbDec.Text = "";
            // 
            // rtbCipher
            // 
            this.rtbCipher.Location = new System.Drawing.Point(86, 358);
            this.rtbCipher.Name = "rtbCipher";
            this.rtbCipher.Size = new System.Drawing.Size(636, 128);
            this.rtbCipher.TabIndex = 14;
            this.rtbCipher.Text = "";
            // 
            // rtbPlaintext
            // 
            this.rtbPlaintext.Location = new System.Drawing.Point(86, 180);
            this.rtbPlaintext.Name = "rtbPlaintext";
            this.rtbPlaintext.Size = new System.Drawing.Size(636, 128);
            this.rtbPlaintext.TabIndex = 15;
            this.rtbPlaintext.Text = "";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(79, 114);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(164, 22);
            this.tbKey.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giải mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dữ liệu (Input)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Key:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(572, 37);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(149, 36);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(397, 37);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(149, 36);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã hóa Vigenère";
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 698);
            this.Controls.Add(this.rtbDec);
            this.Controls.Add(this.rtbCipher);
            this.Controls.Add(this.rtbPlaintext);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Name = "FormBai2";
            this.Text = "FormBai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDec;
        private System.Windows.Forms.RichTextBox rtbCipher;
        private System.Windows.Forms.RichTextBox rtbPlaintext;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label1;
    }
}