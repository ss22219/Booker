using System;
using Microsoft.Owin.Hosting;
namespace Booker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string url = "http://+:80";

			WebApp.Start<Startup> (url);
			Console.WriteLine ("server is start on {0}",url);
			Console.WriteLine ("press enter to exit");
			Console.ReadLine ();
		}
	}
}
