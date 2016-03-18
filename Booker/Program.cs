using System;
using Microsoft.Owin.Hosting;
namespace Booker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LoadAssemblys();

            string url = "http://+:80";
            WebApp.Start<Startup>(url);
            Console.WriteLine("server is start on {0}", url);
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        /// <summary>
        /// RazorEngine,Booker.Module
        /// </summary>
        public static void LoadAssemblys()
        {
            if (System.IO.Directory.Exists("bin"))
            {
                var files = System.IO.Directory.GetFiles((System.IO.Path.GetFullPath("bin")));
                foreach (var file in files)
                {
                    try
                    {
                        if (System.IO.Path.GetExtension(file).ToLower() == ".dll")
                            System.Reflection.Assembly.LoadFile(file);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
