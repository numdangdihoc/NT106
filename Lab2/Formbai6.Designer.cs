namespace Lab2
{
    partial class Formbai6
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
            treeViewFiles = new TreeView();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // treeViewFiles
            // 
            treeViewFiles.Location = new Point(13, 17);
            treeViewFiles.Name = "treeViewFiles";
            treeViewFiles.Size = new Size(259, 533);
            treeViewFiles.TabIndex = 0;
            treeViewFiles.BeforeExpand += treeViewFiles_BeforeExpand;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 255, 255);
            richTextBox1.Location = new Point(278, 17);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 533);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox1.Location = new Point(278, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 533);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Formbai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 570);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(treeViewFiles);
            Name = "Formbai6";
            Text = "Formbai6";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewFiles;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}