using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Sunny.UI;
using HostsEdit.Model;

namespace HostsFileEdit
{
    public partial class HostFileEditFrm : UIForm
    {
        private const string HostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";

        public HostFileEditFrm()
        {
            InitializeComponent();
        }

        private void HostFileEditForm_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                MsgBoxUtil.Warn("请以管理员身份运行该程序以编辑 Hosts 文件。");
                return;
            }

            LoadHostsFile();

            LoadHostFileLines();

            txtHostsContent.ScrollBars = ScrollBars.Both; // 显示水平和垂直滚动条

            txtHostsContent.TabStop = false;
        }


        private void LoadHostFileLines()
        {
            try
            {
                string hostsContent = File.ReadAllText(HostsFilePath, Encoding.GetEncoding("GBK"));
                string[] lines = hostsContent.Split("\n");
                string[] filters = lines.Where(s => !string.IsNullOrWhiteSpace(s) && !s.StartsWith("#")).ToArray();
                listBox_line.Items.AddRange(filters);

            }
            catch (UnauthorizedAccessException)
            {
                MsgBoxUtil.Error("没有访问 Hosts 文件的权限。");
            }
            catch (Exception ex)
            {
                MsgBoxUtil.Error("发生错误：" + ex.Message);
            }
        }


        private void LoadHostsFile()
        {
            try
            {
                string hostsContent = File.ReadAllText(HostsFilePath, Encoding.GetEncoding("GBK"));
                txtHostsContent.Text = hostsContent;
            }
            catch (UnauthorizedAccessException)
            {
                MsgBoxUtil.Error("没有访问 Hosts 文件的权限。");
            }
            catch (Exception ex)
            {
                MsgBoxUtil.Error("发生错误：" + ex.Message);
            }
        }

        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void SetWriteable()
        {
            // 检查文件是否存在
            if (!File.Exists(HostsFilePath))
            {
                MsgBoxUtil.Error("hosts 文件不存在！");
                return;
            }

            try
            {
                // 移除只读属性
                File.SetAttributes(HostsFilePath, File.GetAttributes(HostsFilePath) & ~FileAttributes.ReadOnly);

                //MessageBox.Show("hosts 文件属性已更改为可写！");
            }
            catch (Exception ex)
            {
                MsgBoxUtil.Error("发生错误：" + ex.Message);
            }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                SetWriteable();

                File.WriteAllText(HostsFilePath, txtHostsContent.Text, Encoding.GetEncoding("GBK"));

                MsgBoxUtil.Info("Hosts 文件已保存。");
            }
            catch (UnauthorizedAccessException)
            {
                MsgBoxUtil.Error("没有权限保存 Hosts 文件。");
            }
            catch (Exception ex)
            {
                MsgBoxUtil.Error("发生错误：" + ex.Message);
            }
        }

        private void 定位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 打开资源管理器并选中指定的文件
                Process.Start("explorer.exe", $"/select, \"{HostsFilePath}\"");
            }
            catch (Exception ex)
            {
                MsgBoxUtil.Error("发生错误：" + ex.Message);
            }
        }

        private void 在Notepad中打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 启动记事本并打开 hosts 文件
                Process.Start("notepad.exe", HostsFilePath);
            }
            catch (Exception ex)
            {
                MsgBoxUtil.Error("发生错误：" + ex.Message);
            }

        }

        private void 环境变量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("rundll32.exe", "sysdm.cpl,EditEnvironmentVariables");
        }

        private void listBox_line_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_line.SelectedIndex < 0)
            {
                return;
            }

            string val = (string)listBox_line.Items[listBox_line.SelectedIndex];
            string[] lines= val.Split(" ");
            if (lines.Length != 2)
            {
                MsgBoxUtil.Error("分割错误");
                return;
            }

            EditFormVo editFormVo = new EditFormVo()
            {
                key = lines[0],
                value = lines[1]
            };

            EditForm editForm = new EditForm(editFormVo);
            editForm.ShowDialog();
        }
    }
}
