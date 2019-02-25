namespace BeAGoodBoy
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PMBtn = new System.Windows.Forms.Button();
            this.MDBtn = new System.Windows.Forms.Button();
            this.MixBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutBtn
            // 
            this.AboutBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AboutBtn.Font = new System.Drawing.Font("宋体", 11F);
            this.AboutBtn.Location = new System.Drawing.Point(310, 20);
            this.AboutBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(74, 127);
            this.AboutBtn.TabIndex = 0;
            this.AboutBtn.Text = "关于本工具";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PMBtn);
            this.flowLayoutPanel1.Controls.Add(this.MDBtn);
            this.flowLayoutPanel1.Controls.Add(this.MixBtn);
            this.flowLayoutPanel1.Controls.Add(this.AboutBtn);
            this.flowLayoutPanel1.Controls.Add(this.ExitBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 15, 15, 50);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(532, 174);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // PMBtn
            // 
            this.PMBtn.Font = new System.Drawing.Font("宋体", 11F);
            this.PMBtn.Location = new System.Drawing.Point(55, 20);
            this.PMBtn.Margin = new System.Windows.Forms.Padding(5);
            this.PMBtn.Name = "PMBtn";
            this.PMBtn.Size = new System.Drawing.Size(75, 127);
            this.PMBtn.TabIndex = 1;
            this.PMBtn.Text = "简单加减计算";
            this.PMBtn.UseVisualStyleBackColor = true;
            this.PMBtn.Click += new System.EventHandler(this.PMBtn_Click);
            // 
            // MDBtn
            // 
            this.MDBtn.Font = new System.Drawing.Font("宋体", 11F);
            this.MDBtn.Location = new System.Drawing.Point(140, 20);
            this.MDBtn.Margin = new System.Windows.Forms.Padding(5);
            this.MDBtn.Name = "MDBtn";
            this.MDBtn.Size = new System.Drawing.Size(75, 127);
            this.MDBtn.TabIndex = 2;
            this.MDBtn.Text = "简单乘除计算";
            this.MDBtn.UseVisualStyleBackColor = true;
            this.MDBtn.Click += new System.EventHandler(this.MDBtn_Click);
            // 
            // MixBtn
            // 
            this.MixBtn.Font = new System.Drawing.Font("宋体", 11F);
            this.MixBtn.Location = new System.Drawing.Point(225, 20);
            this.MixBtn.Margin = new System.Windows.Forms.Padding(5);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(75, 127);
            this.MixBtn.TabIndex = 3;
            this.MixBtn.Text = "加减乘除混合计算";
            this.MixBtn.UseVisualStyleBackColor = true;
            this.MixBtn.Click += new System.EventHandler(this.MixBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("宋体", 11F);
            this.ExitBtn.Location = new System.Drawing.Point(394, 20);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 127);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "退出";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(532, 174);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "小朋友要乖哦——小学计算题出题工具";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button PMBtn;
        private System.Windows.Forms.Button MDBtn;
        private System.Windows.Forms.Button MixBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

