﻿using System;
using Nancy;
using System.IO;

namespace Booker
{

    /// <summary>
    /// 提供网站物理路径的类
    /// </summary>
    public class SiteRootPath : IRootPathProvider
    {
        /// <summary>
        /// 网站根文件夹物理路径(for tinyfox)
        /// </summary>
        static string _rootPath;

        static SiteRootPath()
        {
            var pcDebugPath = @"C:\Users\ss222\Documents\Booker\Booker";
            var appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "views");
            var evnPath = Path.Combine(Environment.CurrentDirectory, "views");
            if (Directory.Exists(pcDebugPath))
                _rootPath = pcDebugPath;
            else if (Directory.Exists(appPath))
                _rootPath = appPath;
            else if (Directory.Exists(evnPath))
                _rootPath = appPath;
            else
                File.WriteAllText("path.log", string.Format("appPath:{0}\r\nevnPath:{1}", appPath, evnPath));
        }

        /// <summary>
        /// 获取网站或WEB应用的根文件夹的物理路径
        /// </summary>
        /// <returns></returns>
        public string GetRootPath()
        {
            return _rootPath;
        }

    }
}
