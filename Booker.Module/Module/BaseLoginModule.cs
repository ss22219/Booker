using Nancy.Helpers;
using Nancy.Responses;

namespace Booker.Module
{
    public class BaseLoginModule : BaseForeModule
    {
        public BaseLoginModule()
        {
            Before += ctx =>
                User == null
                ? new RedirectResponse("/login?returnurl=" + HttpUtility.UrlEncode(Request.Url))
                : null;
        }
    }
}
