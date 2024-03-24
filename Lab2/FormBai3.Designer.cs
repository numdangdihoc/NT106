namespace Lab2
{
    partial class FormBai3
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
            btn_inputFile = new Button();
            btn_savefile = new Button();
            richTextBox1 = new RichTextBox();
            btn_Calc = new Button();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            btn_Del = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_inputFile
            // 
            btn_inputFile.Location = new Point(38, 312);
            btn_inputFile.Name = "btn_inputFile";
            btn_inputFile.Size = new Size(167, 35);
            btn_inputFile.TabIndex = 0;
            btn_inputFile.Text = "Input FIle";
            btn_inputFile.UseVisualStyleBackColor = true;
            btn_inputFile.Click += btn_inputFile_Click;
            // 
            // btn_savefile
            // 
            btn_savefile.Location = new Point(388, 312);
            btn_savefile.Name = "btn_savefile";
            btn_savefile.Size = new Size(113, 35);
            btn_savefile.TabIndex = 0;
            btn_savefile.Text = "Save File";
            btn_savefile.UseVisualStyleBackColor = true;
            btn_savefile.Click += btn_savefile_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 255, 255);
            richTextBox1.Location = new Point(38, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(333, 179);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btn_Calc
            // 
            btn_Calc.Location = new Point(211, 312);
            btn_Calc.Name = "btn_Calc";
            btn_Calc.Size = new Size(160, 35);
            btn_Calc.TabIndex = 0;
            btn_Calc.Text = "Calc";
            btn_Calc.UseVisualStyleBackColor = true;
            btn_Calc.Click += btn_Calc_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(192, 255, 255);
            richTextBox2.Location = new Point(388, 127);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(367, 179);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 118);
            label1.Name = "label1";
            label1.Size = new Size(202, 27);
            label1.TabIndex = 2;
            label1.Text = "Text's input file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(388, 118);
            label2.Name = "label2";
            label2.Size = new Size(98, 27);
            label2.TabIndex = 2;
            label2.Text = "Results";
            // 
            // button1
            // 
            button1.Location = new Point(634, 312);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 3;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(507, 312);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(121, 35);
            btn_Del.TabIndex = 3;
            btn_Del.Text = "Delete";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Handwriting", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(61, 49);
            label3.Name = "label3";
            label3.Size = new Size(694, 40);
            label3.TabIndex = 2;
            label3.Text = "---Read and Write File (Advanced)---";
            // 
            // FormBai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Del);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(btn_savefile);
            Controls.Add(btn_Calc);
            Controls.Add(btn_inputFile);
            Name = "FormBai3";
            Text = "FormBai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_inputFile;
        private Button btn_savefile;
        private RichTextBox richTextBox1;
        private Button btn_Calc;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button btn_Del;
        private Label label3;
    }
}