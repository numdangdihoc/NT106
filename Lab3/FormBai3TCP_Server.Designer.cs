namespace Lab3
{
    partial class FormBai3TCP_Server
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
            richTextBox1 = new RichTextBox();
            btn_Listen = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(50, 135);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(686, 238);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(603, 62);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(131, 39);
            btn_Listen.TabIndex = 1;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // FormBai3TCP_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Listen);
            Controls.Add(richTextBox1);
            Name = "FormBai3TCP_Server";
            Text = "FormBai3TCP_Server";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btn_Listen;
    }
}