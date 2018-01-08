namespace AppLauncher
{
    partial class FrmAppInfoMgr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppInfoMgr));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAppIcon = new System.Windows.Forms.ToolStripButton();
            this.tscmbAppInfo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.新建NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.删除OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAppExeFile = new System.Windows.Forms.TextBox();
            this.tbAppName = new System.Windows.Forms.TextBox();
            this.contextMenuFileMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiEditFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsiDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbSettingName = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAddSetting = new System.Windows.Forms.ToolStripButton();
            this.tsbDelSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuFileMgr.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAppIcon,
            this.tscmbAppInfo,
            this.toolStripSeparator1,
            this.新建NToolStripButton,
            this.tsbSaveInfo,
            this.toolStripSeparator2,
            this.删除OToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 6);
            this.toolStrip1.Size = new System.Drawing.Size(882, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAppIcon
            // 
            this.tsbAppIcon.AutoToolTip = false;
            this.tsbAppIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("tsbAppIcon.Image")));
            this.tsbAppIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAppIcon.Name = "tsbAppIcon";
            this.tsbAppIcon.Size = new System.Drawing.Size(23, 22);
            // 
            // tscmbAppInfo
            // 
            this.tscmbAppInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbAppInfo.Name = "tscmbAppInfo";
            this.tscmbAppInfo.Size = new System.Drawing.Size(260, 25);
            this.tscmbAppInfo.SelectedIndexChanged += new System.EventHandler(this.tscmbAppInfo_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 新建NToolStripButton
            // 
            this.新建NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripButton.Image")));
            this.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripButton.Name = "新建NToolStripButton";
            this.新建NToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.新建NToolStripButton.Text = "新建(&N)";
            this.新建NToolStripButton.Click += new System.EventHandler(this.新建NToolStripButton_Click);
            // 
            // tsbSaveInfo
            // 
            this.tsbSaveInfo.Image = global::AppLauncher.Properties.Resources.document_save_5;
            this.tsbSaveInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveInfo.Name = "tsbSaveInfo";
            this.tsbSaveInfo.Size = new System.Drawing.Size(67, 22);
            this.tsbSaveInfo.Text = "保存(&S)";
            this.tsbSaveInfo.Click += new System.EventHandler(this.tsbSaveInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 删除OToolStripButton
            // 
            this.删除OToolStripButton.Image = global::AppLauncher.Properties.Resources.edit_delete_6;
            this.删除OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.删除OToolStripButton.Name = "删除OToolStripButton";
            this.删除OToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.删除OToolStripButton.Text = "删除(&D)";
            this.删除OToolStripButton.Click += new System.EventHandler(this.删除OToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAppExeFile);
            this.groupBox1.Controls.Add(this.tbAppName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "应用信息";
            // 
            // tbAppExeFile
            // 
            this.tbAppExeFile.Location = new System.Drawing.Point(6, 44);
            this.tbAppExeFile.Name = "tbAppExeFile";
            this.tbAppExeFile.ReadOnly = true;
            this.tbAppExeFile.Size = new System.Drawing.Size(870, 21);
            this.tbAppExeFile.TabIndex = 1;
            // 
            // tbAppName
            // 
            this.tbAppName.Location = new System.Drawing.Point(6, 20);
            this.tbAppName.Name = "tbAppName";
            this.tbAppName.Size = new System.Drawing.Size(287, 21);
            this.tbAppName.TabIndex = 0;
            this.tbAppName.TextChanged += new System.EventHandler(this.tbAppName_TextChanged);
            // 
            // contextMenuFileMgr
            // 
            this.contextMenuFileMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiAddFile,
            this.cmsiEditFile,
            this.toolStripMenuItem1,
            this.cmsiDelFile});
            this.contextMenuFileMgr.Name = "contextMenuFileMgr";
            this.contextMenuFileMgr.Size = new System.Drawing.Size(125, 76);
            // 
            // cmsiAddFile
            // 
            this.cmsiAddFile.Image = global::AppLauncher.Properties.Resources.list_add_4;
            this.cmsiAddFile.Name = "cmsiAddFile";
            this.cmsiAddFile.Size = new System.Drawing.Size(124, 22);
            this.cmsiAddFile.Text = "增加文件";
            this.cmsiAddFile.Click += new System.EventHandler(this.cmsiAddFile_Click);
            // 
            // cmsiEditFile
            // 
            this.cmsiEditFile.Image = global::AppLauncher.Properties.Resources.document_edit;
            this.cmsiEditFile.Name = "cmsiEditFile";
            this.cmsiEditFile.Size = new System.Drawing.Size(124, 22);
            this.cmsiEditFile.Text = "编辑内容";
            this.cmsiEditFile.Click += new System.EventHandler(this.cmsiEditFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // cmsiDelFile
            // 
            this.cmsiDelFile.Image = global::AppLauncher.Properties.Resources.edit_delete_6;
            this.cmsiDelFile.Name = "cmsiDelFile";
            this.cmsiDelFile.Size = new System.Drawing.Size(124, 22);
            this.cmsiDelFile.Text = "删除文件";
            this.cmsiDelFile.Click += new System.EventHandler(this.cmsiDelFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "可执行文件(*.exe)|*.exe|所有文件|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 18);
            this.tabControl1.Location = new System.Drawing.Point(3, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 314);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1 tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(874, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbSettingName
            // 
            this.tbSettingName.Location = new System.Drawing.Point(273, 103);
            this.tbSettingName.Name = "tbSettingName";
            this.tbSettingName.Size = new System.Drawing.Size(100, 21);
            this.tbSettingName.TabIndex = 3;
            this.tbSettingName.Leave += new System.EventHandler(this.tbSettingName_Leave);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddSetting,
            this.tsbDelSetting});
            this.toolStrip2.Location = new System.Drawing.Point(832, 99);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(49, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAddSetting
            // 
            this.tsbAddSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddSetting.Image = global::AppLauncher.Properties.Resources.list_add_4;
            this.tsbAddSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddSetting.Name = "tsbAddSetting";
            this.tsbAddSetting.Size = new System.Drawing.Size(23, 22);
            this.tsbAddSetting.Text = "增加配置";
            this.tsbAddSetting.Click += new System.EventHandler(this.tsbAddSetting_Click);
            // 
            // tsbDelSetting
            // 
            this.tsbDelSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelSetting.Image = global::AppLauncher.Properties.Resources.edit_delete_6;
            this.tsbDelSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelSetting.Name = "tsbDelSetting";
            this.tsbDelSetting.Size = new System.Drawing.Size(23, 22);
            this.tsbDelSetting.Text = "删除配置";
            this.tsbDelSetting.Click += new System.EventHandler(this.tsbDelSetting_Click);
            // 
            // FrmAppInfoMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 420);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tbSettingName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAppInfoMgr";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "应用程序信息配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAppInfoMgr_FormClosing);
            this.Load += new System.EventHandler(this.FrmAppInfoMgr_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuFileMgr.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscmbAppInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 新建NToolStripButton;
        private System.Windows.Forms.ToolStripButton 删除OToolStripButton;
        private System.Windows.Forms.ToolStripButton tsbAppIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAppName;
        private System.Windows.Forms.TextBox tbAppExeFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuFileMgr;
        private System.Windows.Forms.ToolStripMenuItem cmsiAddFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsiDelFile;
        private System.Windows.Forms.ToolStripMenuItem cmsiEditFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton tsbSaveInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbSettingName;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAddSetting;
        private System.Windows.Forms.ToolStripButton tsbDelSetting;
    }
}