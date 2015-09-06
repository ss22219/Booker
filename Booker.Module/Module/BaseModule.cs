using Booker.Database.Model;
using Nancy;

namespace Booker
{
    /// <summary>
    /// 总父模块
    /// </summary>
    public class BaseModule : NancyModule
    {
        public BaseModule() {
            After += ctx =>
            {
                if (ctx.Response.ContentType == "text/html")
                    ctx.Response.ContentType = "text/html; charset=utf-8";
            };
        }
        public User User
        {
            get
            {
                return Session["user"] as User;
            }
            set
            {
                Session["user"] = value;
            }
        }
    }
}
