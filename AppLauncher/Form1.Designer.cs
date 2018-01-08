namespace AppLauncher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.管理应用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiChangeSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.AppIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.AppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppIcon,
            this.AppName,
            this.Setting});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(689, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangeSetting,
            this.toolStripSeparator2,
            this.tsmiOpenFolder,
            this.toolStripSeparator1,
            this.管理应用ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 104);
            // 
            // tsmiOpenFolder
            // 
            this.tsmiOpenFolder.Image = global::AppLauncher.Properties.Resources.go_parent_folder;
            this.tsmiOpenFolder.Name = "tsmiOpenFolder";
            this.tsmiOpenFolder.Size = new System.Drawing.Size(148, 22);
            this.tsmiOpenFolder.Text = "打开所在目录";
            this.tsmiOpenFolder.Click += new System.EventHandler(this.tsmiOpenFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 管理应用ToolStripMenuItem
            // 
            this.管理应用ToolStripMenuItem.Image = global::AppLauncher.Properties.Resources.view_list_text_2;
            this.管理应用ToolStripMenuItem.Name = "管理应用ToolStripMenuItem";
            this.管理应用ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.管理应用ToolStripMenuItem.Text = "管理应用清单";
            this.管理应用ToolStripMenuItem.Click += new System.EventHandler(this.管理应用ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiChangeSetting
            // 
            this.tsmiChangeSetting.Name = "tsmiChangeSetting";
            this.tsmiChangeSetting.Size = new System.Drawing.Size(152, 22);
            this.tsmiChangeSetting.Text = "切换配置";
            this.tsmiChangeSetting.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsmiChangeSetting_DropDownItemClicked);
            // 
            // AppIcon
            // 
            this.AppIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AppIcon.HeaderText = "";
            this.AppIcon.MinimumWidth = 36;
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AppIcon.Width = 36;
            // 
            // AppName
            // 
            this.AppName.DataPropertyName = "应用名称";
            this.AppName.FillWeight = 59.98477F;
            this.AppName.HeaderText = "应用名称";
            this.AppName.MinimumWidth = 300;
            this.AppName.Name = "AppName";
            this.AppName.ReadOnly = true;
            this.AppName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Setting
            // 
            this.Setting.DataPropertyName = "SettingName";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.DefaultCellStyle = dataGridViewCellStyle6;
            this.Setting.FillWeight = 20F;
            this.Setting.HeaderText = "配置";
            this.Setting.MinimumWidth = 40;
            this.Setting.Name = "Setting";
            this.Setting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Setting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 365);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "桌面App启动器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理应用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewImageColumn AppIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setting;
    }
}

