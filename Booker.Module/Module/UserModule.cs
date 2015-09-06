using Booker.Database.Interface;
using Booker.Database.Model;
using Nancy.Responses;

namespace Booker.Module
{
    public class UserModule : BaseForeModule
    {
        IUserDb _userDb;

        public UserModule(IUserDb userDb)
        {
            _userDb = userDb;

            Get["/login"] = _ => View["user/login"];

            Post["/login"] = _ => DoLogin();

            Get["/logout"] = _ => LoginOut();

            Get["/regist"] = _ => View["user/regist"];

            Post["/regist"] = _ => DoRegist();
        }

        private dynamic DoRegist()
        {
           
            bool success = false;
            if (string.IsNullOrWhiteSpace(Request.Form.username) || string.IsNullOrWhiteSpace(Request.Form.password))
            {
                ViewBag.Error = "用户名或密码不能为空！";
            }
            else
            {
                var user = _userDb.Get(Request.Form.username as string);
                if (user == null)
                {
                    _userDb.Add(new User()
                    {
                        username = Request.Form.username,
                        password = Request.Form.password,
                        email = Request.Form.email,
                        nicename = Request.Form.nicename
                    });
                    success = true;
                }
                else
                {
                    ViewBag.Error = "改用户名已经存在！";
                }
            }

            if (success)
            {

                return new RedirectResponse("/login");
            }
            else
            {
                return View["user/regist"];
            }
        }


        private dynamic LoginOut()
        {
            User = null;
            return new RedirectResponse("/");
        }

        private dynamic DoLogin()
        {
            var user = _userDb.Login(Request.Form.username, Request.Form.password);
            if (user == null)
            {
                ViewBag.Error = "用户名或密码错误！";
                return View["user/login"];
            }
            else
            {
                User = user;
                return new RedirectResponse(Request.Form.returnurl == null ? "/user" : Request.Form.returnurl);
            }
        }
    }
}
