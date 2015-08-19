using Owin;
namespace Booker
{
	public class Startup
	{
		public void Configuration (IAppBuilder appBuilder)
		{
			appBuilder.UseNancy ();
		}
	}
}

