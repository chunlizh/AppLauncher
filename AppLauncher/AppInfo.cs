using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppLauncher
{

    public class AppInfo
    {
        public AppInfo()
        {
            ID = Guid.NewGuid().ToString();
            Settings = new List<AppSetting>();
            AddSetting("默认配置");
        }
        public string ID { get; set; }
        public string 应用名称 { get; set; }
        public string ExeFile { get; set; }

        public string DataPath { get { return System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, ID); } }

        public string ExePath
        {
            get
            {
                if (File.Exists(ExeFile))
                    return System.IO.Path.GetDirectoryName(ExeFile);
                else
                    return string.Empty;
            }
        }
        /// <summary>
        /// 当前使用的配置名称
        /// </summary>
        public string SettingName { get; set; }
        /// <summary>
        /// 当前使用的配置ID
        /// </summary>
        public string SettingID { get; set; }
        /// <summary>
        /// 当前使用的配置
        /// </summary>
        public AppSetting UsedSetting {
            get
            {
                return Settings.FirstOrDefault(s => s.ID == SettingID);
            }
        }
        /// <summary>
        /// 环境配置文件
        /// </summary>
        public List<AppSetting> Settings { get; set; }

        public override string ToString()
        {
            return 应用名称;
        }
        /// <summary>
        /// 切换配置
        /// </summary>
        /// <param name="appSetting"></param>
        public void ChangeTo(AppSetting appSetting)
        {
            this.SettingID = appSetting.ID;
            this.SettingName = appSetting.Name;
            appSetting.CopyToOriginal();
        }

        public void AddSetting(string name)
        {
            Settings.Add(new AppSetting()
            {
                AppId = ID,
                Name = name
            });
        }
        public void DeleteSetting(AppSetting appSetting)
        {
            Settings.Remove(appSetting);
            if (Directory.Exists(appSetting.DataPath))
                Directory.Delete(appSetting.DataPath, true);
        }
    }

    public class AppSetting
    {
        public AppSetting()
        {
            ID = Guid.NewGuid().ToString();
            SettingFiles = new List<SettingFile>();
        }
        public string AppId { get; set; }
        public string ID { get; set; }
        /// <summary>
        /// 配置名称
        /// </summary>
        public string Name { get; set; }
        public List<SettingFile> SettingFiles { get; set; }

        /// <summary>
        /// 配置文件保存位置
        /// </summary>
        public string DataPath
        {
            get { return System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, AppId); }
        }
        public void AddFiles(string[] files)
        {
            System.IO.Directory.CreateDirectory(DataPath);
            //复制原配置文件到本地
            foreach (var f in files)
            {
                SettingFile settingFile = new SettingFile() { OriginalFullName = f };
                SettingFiles.Add(settingFile);
                string localFile = System.IO.Path.Combine(DataPath, settingFile.LocalFileName);
                System.IO.File.Copy(f, localFile, true);
            }
        }
        /// <summary>
        /// 删除本地配置文件
        /// </summary>
        /// <param name="settingFile"></param>
        public void DeleteFile(SettingFile settingFile)
        {
            string df = System.IO.Path.Combine(DataPath, settingFile.LocalFileName);
            if (System.IO.File.Exists(df))
                System.IO.File.Delete(df);
            SettingFiles.Remove(settingFile);
        }
        /// <summary>
        /// 复制配置文件到原位置
        /// </summary>
        public void CopyToOriginal()
        {
            foreach(var sf in SettingFiles)
            {
                string localFile = System.IO.Path.Combine(DataPath, sf.LocalFileName);
                if (File.Exists(localFile))
                    File.Copy(localFile, sf.OriginalFullName, true);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
    /// <summary>
    /// 配置文件信息
    /// </summary>
    public class SettingFile
    {
        public SettingFile()
        {
            ID = Guid.NewGuid().ToString();
        }
        public string ID { get; set; }
        public string LocalFileName
        {
            get
            {
                return ID + "_" + OriginalFileName;
            }
        }
        /// <summary>
        /// 原始文件名，不含路径
        /// </summary>
        public string OriginalFileName
        {
            get
            {
                return System.IO.Path.GetFileName(OriginalFullName);
            }
        }
        /// <summary>
        /// 原始完整文件名，含路径
        /// </summary>
        public string OriginalFullName { get; set; }

        public override string ToString()
        {
            return OriginalFileName;
        }
    }
    /// <summary>
    /// 应用信息管理类
    /// </summary>
    public static class AppInfoMgr
    {
        static List<AppInfo> _AppInfo;

        static string DataFile {
            get {
                return System.IO.Path.ChangeExtension(System.Windows.Forms.Application.ExecutablePath, ".dat");
            }
        }
        public static List<AppInfo> AppInfo
        {
            get
            {
                if (_AppInfo == null)
                    LoadAppInfo();
                return _AppInfo;
            }
        }
        private static void LoadAppInfo()
        {
            try
            {
                string dataText = System.IO.File.ReadAllText(DataFile);
                _AppInfo = fastJSON.JSON.ToObject<List<AppInfo>>(dataText);
            }
            catch { }

            if (_AppInfo == null)
                _AppInfo = new List<AppInfo>();
            foreach (var ai in _AppInfo)
                if (ai.Settings?.Count == 0)
                {
                    ai.AddSetting("默认配置");
                }
        }
        public static void SaveAppInfo()
        {
            string dataText = fastJSON.JSON.ToNiceJSON(_AppInfo);
            System.IO.File.WriteAllText(DataFile, dataText);
        }

        public static AppLauncher.AppInfo Add(string exePath)
        {
            AppLauncher.AppInfo app = new AppLauncher.AppInfo()
            {
                应用名称 = System.IO.Path.GetFileName(exePath),
                ExeFile = exePath,
            };
            _AppInfo.Add(app);
            return app;
        }
        public static void Delete(AppLauncher.AppInfo app)
        {
            _AppInfo.Remove(app);
            SaveAppInfo();
            #region 删除本地配置文件
            if (System.IO.Directory.Exists(app.DataPath))
                System.IO.Directory.Delete(app.DataPath, true);
            #endregion
        }
        public static void StartApp(AppLauncher.AppInfo app)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(app.ExeFile);
            startInfo.WorkingDirectory = app.ExePath;
            System.Diagnostics.Process.Start(startInfo);
        }
    }
}
