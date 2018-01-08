using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLauncher
{
    public partial class FrmAppInfoMgr : Form
    {
        /// <summary>
        /// 当前选中的
        /// </summary>
        AppInfo curApp;
        Dictionary<string,ListBox> settingFilesListBox=new Dictionary<string, ListBox>();
        public FrmAppInfoMgr()
        {
            InitializeComponent();
            tbSettingName.Hide();
            this.Icon = Icon.FromHandle( AppLauncher.Properties.Resources.view_list_text_2.GetHicon());
            删除OToolStripButton.Enabled = false;
            toolStrip2.Enabled = false;
            Clear();
        }

        private void FrmAppInfoMgr_Load(object sender, EventArgs e)
        {
            tscmbAppInfo.Items.AddRange(AppInfoMgr.AppInfo.ToArray());
            if (tscmbAppInfo.Items.Count > 0)
                tscmbAppInfo.SelectedIndex = 0;
        }

        private void FrmAppInfoMgr_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (curApp != null)
                curApp.应用名称 = tbAppName.Text;
            AppInfoMgr.SaveAppInfo();
        }

        private void 新建NToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "可执行文件(*.exe)|*.exe|所有文件|*.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                Clear();
                AppInfo app = AppInfoMgr.Add(openFileDialog1.FileName);
                tscmbAppInfo.Items.Add(app);
                tscmbAppInfo.SelectedIndex = tscmbAppInfo.Items.Count - 1;
                DisplayAppInfo();
            }
        }
        private void tsbSaveInfo_Click(object sender, EventArgs e)
        {
            if (curApp != null)
                curApp.应用名称 = tbAppName.Text;
            AppInfoMgr.SaveAppInfo();
        }

        private void 删除OToolStripButton_Click(object sender, EventArgs e)
        {
            if (curApp != null && MessageBox.Show("确定要删除当前应用信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AppInfoMgr.Delete(curApp);
                tscmbAppInfo.Items.Remove(curApp);
            }
        }

        private void tscmbAppInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            curApp = tscmbAppInfo.SelectedItem as AppInfo;
            if (curApp != null)
                tsbAppIcon.Image = Icon.ExtractAssociatedIcon(curApp.ExeFile).ToBitmap();
            else
                tsbAppIcon.Image = null;
            删除OToolStripButton.Enabled = curApp != null;
            toolStrip2.Enabled = curApp != null;
            DisplayAppInfo();
        }

        private void DisplayAppInfo()
        {
            tabControl1.SuspendLayout();

            Clear();
            if (curApp == null) return;
            tbAppName.Text = curApp.应用名称;
            tbAppExeFile.Text = curApp.ExeFile;
            foreach (var sf in curApp.Settings)
            {
                TabPage tabPage = new TabPage(sf.Name);
                tabPage.Tag = sf.ID;
                tabControl1.TabPages.Add(tabPage);
                ListBox listBox = new ListBox() { Dock = DockStyle.Fill, ContextMenuStrip= contextMenuFileMgr, ItemHeight=26, SelectionMode= SelectionMode.One };
                tabPage.Controls.Add(listBox);
                settingFilesListBox.Add(sf.ID, listBox);
                listBox.Items.AddRange(sf.SettingFiles.ToArray());
            }

            tabControl1.ResumeLayout();
        }
        bool isClearing = false;
        private void Clear()
        {
            isClearing = true;
            tbAppName.Text = "";
            tbAppExeFile.Text = "";
            tabControl1.TabPages.Clear();
            settingFilesListBox.Clear();
            isClearing = false;
        }
        private void tbAppName_TextChanged(object sender, EventArgs e)
        {
            if (!isClearing && curApp != null)
                curApp.应用名称 = tbAppName.Text;
        }
        #region 文件配置
        private void cmsiEditFile_Click(object sender, EventArgs e)
        {
            string settingId = tabControl1.SelectedTab.Tag.ToString();
            SettingFile settingFile = settingFilesListBox[settingId].SelectedItem as SettingFile;
            AppSetting appSetting = curApp.Settings.FirstOrDefault(s => s.ID == settingId);
            if (settingFile != null && appSetting != null)
            {
                //使用 NotePad++ 进行编辑
                string notePad = System.IO.Path.Combine(Application.StartupPath, "notepad++\\notepad++.exe");
                string localFile = System.IO.Path.Combine(appSetting.DataPath, settingFile.LocalFileName);
                if (!System.IO.File.Exists(notePad))
                {
                    notePad = "NotePad.exe";
                }
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(notePad);
                startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(notePad);
                startInfo.Arguments = localFile;
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void cmsiDelFile_Click(object sender, EventArgs e)
        {
            string settingId = tabControl1.SelectedTab.Tag.ToString();
            SettingFile settingFile = settingFilesListBox[settingId].SelectedItem as SettingFile;
            AppSetting appSetting = curApp.Settings.FirstOrDefault(s => s.ID == settingId);
            if (settingFile != null && appSetting != null)
            {
                appSetting.DeleteFile(settingFile);
                settingFilesListBox[settingId].Items.Remove(settingFile);
            }
        }

        private void cmsiAddFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = curApp.ExePath;
            openFileDialog1.Filter = "所有文件|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string settingId = tabControl1.SelectedTab.Tag.ToString();
                AppSetting appSetting = curApp.Settings.FirstOrDefault(s => s.ID == settingId);
                if (appSetting != null)
                {
                    appSetting.AddFiles(openFileDialog1.FileNames);
                    settingFilesListBox[settingId].Items.Clear();
                    settingFilesListBox[settingId].Items.AddRange(appSetting.SettingFiles.ToArray());
                }
            }
        }
        #endregion

        private void tbSettingName_Leave(object sender, EventArgs e)
        {
            tbSettingName.Hide();
            curApp.Settings[tabControl1.SelectedIndex].Name = tbSettingName.Text;
            tabControl1.SelectedTab.Text = tbSettingName.Text;
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            var tabRect = tabControl1.GetTabRect(tabControl1.SelectedIndex);
            Point p = tabRect.Location;
            p.Y += tabControl1.Location.Y;
            p.X += tabControl1.Location.X;
            tbSettingName.Location = p;
            tbSettingName.Width = tabRect.Width;
            tbSettingName.Height = tabRect.Height;
            tbSettingName.Text = tabControl1.SelectedTab.Text;
            tbSettingName.Show();
            tbSettingName.BringToFront();
            tbSettingName.Focus();
        }

        private void tsbAddSetting_Click(object sender, EventArgs e)
        {
            curApp.AddSetting("新配置");
            DisplayAppInfo();
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
        }

        private void tsbDelSetting_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要删除 "+tabControl1.SelectedTab.Text+" ？","提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                curApp.Settings.RemoveAt(tabControl1.SelectedIndex);
                DisplayAppInfo();
            }
        }

    }
}
