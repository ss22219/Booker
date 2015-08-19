using System;
using Nancy;
namespace Booker
{
	public class IndexModule : NancyModule
	{
		public IndexModule ()
		{
			Get["/"] = _ => View["index"];
		}
	}
}