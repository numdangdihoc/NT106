namespace Lab1
{
    partial class FormCalcIP
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
            txt_SubnetMask = new TextBox();
            label1 = new Label();
            txt_NetworkAdd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_NumSubnets = new TextBox();
            btn_Calc = new Button();
            dgvResults = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btn_Del = new Button();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // txt_SubnetMask
            // 
            txt_SubnetMask.Location = new Point(398, 85);
            txt_SubnetMask.Name = "txt_SubnetMask";
            txt_SubnetMask.Size = new Size(58, 27);
            txt_SubnetMask.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 92);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Địa chỉ mạng:";
            // 
            // txt_NetworkAdd
            // 
            txt_NetworkAdd.Location = new Point(146, 85);
            txt_NetworkAdd.Name = "txt_NetworkAdd";
            txt_NetworkAdd.Size = new Size(225, 27);
            txt_NetworkAdd.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 88);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 1;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 92);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 2;
            label3.Text = "Số mạng con cần chia:";
            // 
            // txt_NumSubnets
            // 
            txt_NumSubnets.Location = new Point(643, 89);
            txt_NumSubnets.Name = "txt_NumSubnets";
            txt_NumSubnets.Size = new Size(84, 27);
            txt_NumSubnets.TabIndex = 3;
            // 
            // btn_Calc
            // 
            btn_Calc.Location = new Point(45, 134);
            btn_Calc.Name = "btn_Calc";
            btn_Calc.Size = new Size(118, 45);
            btn_Calc.TabIndex = 4;
            btn_Calc.Text = "Tính";
            btn_Calc.UseVisualStyleBackColor = true;
            btn_Calc.Click += btn_Calc_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvResults.Location = new Point(45, 195);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.RowTemplate.Height = 29;
            dgvResults.Size = new Size(680, 243);
            dgvResults.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Địa chỉ mạng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Địa chỉ đầu";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Địa chỉ cuối";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Địa chỉ broadcast";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(320, 139);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(120, 40);
            btn_Del.TabIndex = 6;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(605, 139);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(120, 40);
            btn_Exit.TabIndex = 6;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // FormCalcIP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Del);
            Controls.Add(dgvResults);
            Controls.Add(btn_Calc);
            Controls.Add(txt_NumSubnets);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_NetworkAdd);
            Controls.Add(txt_SubnetMask);
            Name = "FormCalcIP";
            Text = "Tính toán địa chỉ IP";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_SubnetMask;
        private Label label1;
        private TextBox txt_NetworkAdd;
        private Label label2;
        private Label label3;
        private TextBox txt_NumSubnets;
        private Button btn_Calc;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btn_Del;
        private Button btn_Exit;
    }
}