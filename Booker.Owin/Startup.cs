using Owin;
using Nancy;


namespace Booker
{
	public class Startup
	{
		public void Configuration (IAppBuilder appBuilder)
		{
			appBuilder.UseNancy (new Nancy.Owin.NancyOptions(){
				Bootstrapper = new Bootstraper()
			});
		}
	}
}

