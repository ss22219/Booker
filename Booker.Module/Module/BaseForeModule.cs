namespace Booker
{
    /// <summary>
    /// 前台父模块
    /// </summary>
    public class BaseForeModule : BaseModule
    {
        public dynamic Back(string title, string msg)
        {
            ViewBag.Title = title;
            ViewBag.Message = msg;
            return View["status/back"];
        }
    }
}
