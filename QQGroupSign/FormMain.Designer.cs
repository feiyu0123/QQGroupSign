namespace QQGroupSign
{
    partial class FormMain
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
            this.wb = new System.Windows.Forms.WebBrowser();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.chkCustomLocation = new System.Windows.Forms.CheckBox();
            this.groupList = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(0, 0);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(516, 335);
            this.wb.TabIndex = 0;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.groupList);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(516, 335);
            this.panelMain.TabIndex = 1;
            this.panelMain.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(142, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 256);
            this.panel1.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(374, 256);
            this.txtResult.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSign);
            this.panel2.Controls.Add(this.txtLocation);
            this.panel2.Controls.Add(this.chkCustomLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(142, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 41);
            this.panel2.TabIndex = 8;
            // 
            // btnSign
            // 
            this.btnSign.Enabled = false;
            this.btnSign.Location = new System.Drawing.Point(287, 9);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "签到";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(61, 11);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(216, 21);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.Text = "山的那边海的那边";
            // 
            // chkCustomLocation
            // 
            this.chkCustomLocation.AutoSize = true;
            this.chkCustomLocation.Checked = true;
            this.chkCustomLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCustomLocation.Location = new System.Drawing.Point(6, 13);
            this.chkCustomLocation.Name = "chkCustomLocation";
            this.chkCustomLocation.Size = new System.Drawing.Size(60, 16);
            this.chkCustomLocation.TabIndex = 3;
            this.chkCustomLocation.Text = "位置：";
            this.chkCustomLocation.UseVisualStyleBackColor = true;
            this.chkCustomLocation.CheckedChanged += new System.EventHandler(this.chkCustomLocation_CheckedChanged);
            // 
            // groupList
            // 
            this.groupList.CheckOnClick = true;
            this.groupList.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupList.FormattingEnabled = true;
            this.groupList.Location = new System.Drawing.Point(0, 0);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(142, 297);
            this.groupList.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 38);
            this.panel3.TabIndex = 9;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(12, 10);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(48, 16);
            this.chkAll.TabIndex = 0;
            this.chkAll.Text = "全选";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 335);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.wb);
            this.Name = "FormMain";
            this.Text = "QQ批量签到工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckedListBox groupList;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkCustomLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkAll;
    }
}

