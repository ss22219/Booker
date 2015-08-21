using System;
namespace Booker
{
    public class IndexModule : BaseForeModule
	{
		public IndexModule ()
		{
			Get["/"] = _ => View["index"];
		}
	}
}