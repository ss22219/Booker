using Owin;
using Nancy;


namespace Booker
{
	public class Startup
	{
		public void Configuration (IAppBuilder appBuilder)
		{
			appBuilder.Use<ExceptionMiddleware>().UseNancy (new Nancy.Owin.NancyOptions(){
				Bootstrapper = new Bootstraper()
			});
		}
	}
}

