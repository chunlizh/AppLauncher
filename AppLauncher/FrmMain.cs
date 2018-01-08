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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                AppInfo app = dataGridView1.Rows[e.RowIndex].DataBoundItem as AppInfo;
                if (app != null)
                {
                    Icon icon = Icon.ExtractAssociatedIcon(app.ExeFile);
                    e.Value = icon;

                }
            }
        }

        private void 管理应用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmAppInfoMgr appinfoMgr = new FrmAppInfoMgr())
            {
                dataGridView1.DataSource = null;
                appinfoMgr.ShowInTaskbar = false;
                appinfoMgr.ShowDialog();
                appinfoMgr.Close();
                dataGridView1.DataSource = AppInfoMgr.AppInfo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = AppInfoMgr.AppInfo;
        }

        private void tsmiOpenFolder_Click(object sender, EventArgs e)
        {
            AppInfo app = dataGridView1.CurrentRow.DataBoundItem as AppInfo;
            if (app != null && !string.IsNullOrEmpty(app.ExePath))
            {
                System.Diagnostics.Process.Start("explorer.exe", app.ExePath);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AppInfo app = dataGridView1.CurrentRow.DataBoundItem as AppInfo;
            if (app != null && !string.IsNullOrEmpty(app.ExeFile) && e.ColumnIndex == 1)
            {
                this.WindowState = FormWindowState.Minimized;
                AppInfoMgr.StartApp(app);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (e.Clicks == 1 && e.Button == MouseButtons.Right)
            {
                if (currentMouseOverRow >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[currentMouseOverRow].Selected = true;

                    tsmiChangeSetting.DropDownItems.Clear();
                    AppInfo appInfo = dataGridView1.CurrentRow?.DataBoundItem as AppInfo;
                    if (appInfo != null)
                    {
                        tsmiChangeSetting.Enabled = true;
                        tsmiOpenFolder.Enabled = true;
                        foreach (var s in appInfo.Settings)
                            tsmiChangeSetting.DropDownItems.Add(s.Name).Tag = s;
                    }
                }
                else
                {
                    tsmiChangeSetting.Enabled = false;
                    tsmiOpenFolder.Enabled = false;
                }

                contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void TsmiChangeSetting_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AppSetting appSetting = e.ClickedItem.Tag as AppSetting;
            AppInfo app = dataGridView1.CurrentRow.DataBoundItem as AppInfo;
            if (app != null && appSetting != null)
            {
                app.ChangeTo(appSetting);
                AppInfoMgr.SaveAppInfo();
            }
            dataGridView1.Refresh();
        }
    }
}
