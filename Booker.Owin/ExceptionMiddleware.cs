using System;
using Microsoft.Owin;
using System.IO;
using System.Threading.Tasks;
namespace Booker
{
	class ExceptionMiddleware : OwinMiddleware
	{
		public ExceptionMiddleware(OwinMiddleware next)
			: base(next)
		{
		}

		public override async Task Invoke(IOwinContext context)
		{
			try
			{
				await Next.Invoke(context);
			}
			catch (IOException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

