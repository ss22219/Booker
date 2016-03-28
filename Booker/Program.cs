using System;
using Microsoft.Owin.Hosting;
using Fos;
namespace Booker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LoadAssemblys();
            if (args != null && args.Length > 0 && args[0].ToLower().IndexOf("fastcgi") != -1)
            {
                int port = 0;
                if (args.Length <= 1 || !int.TryParse(args[1], out port))
                    port = 9000;
                FastCgi(port);
            }
            else
                SelfHost();
        }

        public static void FastCgi(int port)
        {
            var startup = new Startup();
            using (var fosServer = new FosSelfHost(startup.Configuration))
            {
                fosServer.Bind(System.Net.IPAddress.Loopback, port);
                fosServer.Start(false);
            }
        }

        public static void SelfHost()
        {
            string url = "http://+:8080";
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
