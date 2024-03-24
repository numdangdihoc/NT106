namespace Lab4_New
{
    partial class FormBai5
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
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.labelUserPerPage = new System.Windows.Forms.Label();
            this.labelTottalPage = new System.Windows.Forms.Label();
            this.labelTotalUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(24, 93);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(141, 34);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(226, 89);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(101, 38);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(470, 89);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 38);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(18, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 521);
            this.panel1.TabIndex = 4;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(32, 16);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(52, 16);
            this.labelPage.TabIndex = 5;
            this.labelPage.Text = "Page x:";
            // 
            // labelUserPerPage
            // 
            this.labelUserPerPage.AutoSize = true;
            this.labelUserPerPage.Location = new System.Drawing.Point(32, 55);
            this.labelUserPerPage.Name = "labelUserPerPage";
            this.labelUserPerPage.Size = new System.Drawing.Size(91, 16);
            this.labelUserPerPage.TabIndex = 5;
            this.labelUserPerPage.Text = "Users/page: x";
            // 
            // labelTottalPage
            // 
            this.labelTottalPage.AutoSize = true;
            this.labelTottalPage.Location = new System.Drawing.Point(160, 16);
            this.labelTottalPage.Name = "labelTottalPage";
            this.labelTottalPage.Size = new System.Drawing.Size(85, 16);
            this.labelTottalPage.TabIndex = 6;
            this.labelTottalPage.Text = "Total page: x";
            // 
            // labelTotalUser
            // 
            this.labelTotalUser.AutoSize = true;
            this.labelTotalUser.Location = new System.Drawing.Point(160, 55);
            this.labelTotalUser.Name = "labelTotalUser";
            this.labelTotalUser.Size = new System.Drawing.Size(86, 16);
            this.labelTotalUser.TabIndex = 6;
            this.labelTotalUser.Text = "Total users: x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Users List";
            // 
            // FormBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 670);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotalUser);
            this.Controls.Add(this.labelTottalPage);
            this.Controls.Add(this.labelUserPerPage);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnGet);
            this.Name = "FormBai5";
            this.Text = "FormBai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label labelUserPerPage;
        private System.Windows.Forms.Label labelTottalPage;
        private System.Windows.Forms.Label labelTotalUser;
        private System.Windows.Forms.Label label3;
    }
}