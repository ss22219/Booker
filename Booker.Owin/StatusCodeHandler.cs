using System;
using Nancy.ErrorHandling;
using Nancy;
using Nancy.ViewEngines;


namespace Booker
{
	public class StatusCodeHandler : IStatusCodeHandler
	{
		IViewRenderer viewRender;

		public StatusCodeHandler(IViewRenderer viewRender){
			this.viewRender = viewRender;
		}

		/// <summary>
		/// 当前状态是否需要自己处理
		/// </summary>
		/// <param name="viewRendererstatusCode"></param>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool HandlesStatusCode(HttpStatusCode statusCode, NancyContext context)
		{
			//return false;
			return (statusCode == HttpStatusCode.NotFound
				//|| statusCode == HttpStatusCode.ServiceUnavailable
				//|| statusCode == HttpStatusCode.InternalServerError
			);
		}

		/// <summary>
		/// 具体
		/// </summary>
		/// <param name="statusCode"></param>
		/// <param name="context"></param>
		public void Handle(HttpStatusCode statusCode, NancyContext context)
		{
            Console.WriteLine(context.Trace.TraceLog.ToString());
			var response = viewRender.RenderView(context, "status/404");
			response.StatusCode = statusCode == HttpStatusCode.NotFound ? HttpStatusCode.OK : statusCode;
			context.Response = response;
		}

	}
}

