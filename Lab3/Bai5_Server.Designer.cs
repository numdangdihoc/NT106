namespace Lab3
{
    partial class Bai5_Server
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
            btn_listen = new Button();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(605, 53);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(132, 36);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(51, 122);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(696, 281);
            txtLog.TabIndex = 1;
            // 
            // Bai4_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLog);
            Controls.Add(btn_listen);
            Name = "Bai4_Server";
            Text = "Bai4_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox txtLog;
    }
}