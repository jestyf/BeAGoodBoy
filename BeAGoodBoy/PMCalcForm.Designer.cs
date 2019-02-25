namespace BeAGoodBoy
{
    partial class PMCalcForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.D10 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.ItemNums = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.ComboBox();
            this.DigitsBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ProgressBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.05315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.94684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.Location = new System.Drawing.Point(27, 214);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(27, 4, 27, 21);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(500, 16);
            this.ProgressBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.D10);
            this.panel1.Controls.Add(this.A10);
            this.panel1.Controls.Add(this.ItemNums);
            this.panel1.Controls.Add(this.GenerateBtn);
            this.panel1.Controls.Add(this.NumberBox);
            this.panel1.Controls.Add(this.DigitsBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 206);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(53, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "数字数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "难度";
            // 
            // D10
            // 
            this.D10.Location = new System.Drawing.Point(280, 158);
            this.D10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D10.Name = "D10";
            this.D10.Size = new System.Drawing.Size(57, 23);
            this.D10.TabIndex = 5;
            this.D10.Text = "-10";
            this.D10.UseVisualStyleBackColor = true;
            this.D10.Click += new System.EventHandler(this.D10_Click);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(280, 130);
            this.A10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(57, 23);
            this.A10.TabIndex = 4;
            this.A10.Text = "+10";
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.A10_Click);
            // 
            // ItemNums
            // 
            this.ItemNums.Font = new System.Drawing.Font("宋体", 12F);
            this.ItemNums.Location = new System.Drawing.Point(169, 137);
            this.ItemNums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemNums.Name = "ItemNums";
            this.ItemNums.Size = new System.Drawing.Size(104, 30);
            this.ItemNums.TabIndex = 3;
            this.ItemNums.TextChanged += new System.EventHandler(this.ItemNums_TextChanged);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenerateBtn.Location = new System.Drawing.Point(384, 27);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(110, 71);
            this.GenerateBtn.TabIndex = 2;
            this.GenerateBtn.Text = "生成";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("宋体", 12F);
            this.NumberBox.FormattingEnabled = true;
            this.NumberBox.Location = new System.Drawing.Point(169, 87);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(145, 28);
            this.NumberBox.TabIndex = 1;
            this.NumberBox.SelectedIndexChanged += new System.EventHandler(this.NumberBox_SelectedIndexChanged);
            // 
            // DigitsBox
            // 
            this.DigitsBox.Font = new System.Drawing.Font("宋体", 12F);
            this.DigitsBox.FormattingEnabled = true;
            this.DigitsBox.Location = new System.Drawing.Point(169, 37);
            this.DigitsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DigitsBox.Name = "DigitsBox";
            this.DigitsBox.Size = new System.Drawing.Size(145, 28);
            this.DigitsBox.TabIndex = 0;
            this.DigitsBox.SelectedIndexChanged += new System.EventHandler(this.DigitsBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 75);
            this.label4.TabIndex = 9;
            this.label4.Text = "点击后会在当前文件夹\r\n下生成答案和题目文件\r\n\r\n注意：若当前文件夹有上次\r\n生成的文件，则会覆盖掉";
            // 
            // PMCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PMCalcForm";
            this.Text = "简单加减运算";
            this.Load += new System.EventHandler(this.PMCalcForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button D10;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.TextBox ItemNums;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.ComboBox NumberBox;
        private System.Windows.Forms.ComboBox DigitsBox;
        private System.Windows.Forms.Label label4;
    }
}