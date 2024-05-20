namespace HostsFileEdit
{
    partial class HostFileEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostFileEditFrm));
            this.button_save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.定位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在Notepad中打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.环境变量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtHostsContent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox_line = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_save.Location = new System.Drawing.Point(827, 627);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(76, 37);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.定位ToolStripMenuItem,
            this.在Notepad中打开ToolStripMenuItem,
            this.环境变量ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 定位ToolStripMenuItem
            // 
            this.定位ToolStripMenuItem.Name = "定位ToolStripMenuItem";
            this.定位ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.定位ToolStripMenuItem.Text = "定位到文件";
            this.定位ToolStripMenuItem.Click += new System.EventHandler(this.定位ToolStripMenuItem_Click);
            // 
            // 在Notepad中打开ToolStripMenuItem
            // 
            this.在Notepad中打开ToolStripMenuItem.Name = "在Notepad中打开ToolStripMenuItem";
            this.在Notepad中打开ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.在Notepad中打开ToolStripMenuItem.Text = "在Notepad中打开";
            this.在Notepad中打开ToolStripMenuItem.Click += new System.EventHandler(this.在Notepad中打开ToolStripMenuItem_Click);
            // 
            // 环境变量ToolStripMenuItem
            // 
            this.环境变量ToolStripMenuItem.Name = "环境变量ToolStripMenuItem";
            this.环境变量ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.环境变量ToolStripMenuItem.Text = "环境变量";
            this.环境变量ToolStripMenuItem.Click += new System.EventHandler(this.环境变量ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 556);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtHostsContent);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文本编辑";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtHostsContent
            // 
            this.txtHostsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHostsContent.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHostsContent.Location = new System.Drawing.Point(3, 3);
            this.txtHostsContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtHostsContent.Multiline = true;
            this.txtHostsContent.Name = "txtHostsContent";
            this.txtHostsContent.Size = new System.Drawing.Size(893, 516);
            this.txtHostsContent.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox_line);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按条编辑";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox_line
            // 
            this.listBox_line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_line.FormattingEnabled = true;
            this.listBox_line.ItemHeight = 20;
            this.listBox_line.Location = new System.Drawing.Point(3, 3);
            this.listBox_line.Name = "listBox_line";
            this.listBox_line.Size = new System.Drawing.Size(893, 532);
            this.listBox_line.TabIndex = 0;
            this.listBox_line.DoubleClick += new System.EventHandler(this.listBox_line_DoubleClick);
            // 
            // HostFileEditFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(911, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HostFileEditFrm";
            this.Text = "Hosts文件修改工具";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 913, 636);
            this.Load += new System.EventHandler(this.HostFileEditForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 定位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在Notepad中打开ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtHostsContent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem 环境变量ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_line;
    }
}

