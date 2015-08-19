using System;
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
        static readonly string _RootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../");


        /// <summary>
        /// 获取网站或WEB应用的根文件夹的物理路径
        /// </summary>
        /// <returns></returns>
        public string GetRootPath()
        {
            return _RootPath;

        }

    }
}
