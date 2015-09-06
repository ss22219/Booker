using Booker.Database.Interface;
using Booker.Database.Model;
using iBoxDB.LocalServer;

namespace Booker.Database.iBoxDB
{
    public class UserDb : BaseDb<User, string>, IUserDb
    {
        public UserDb(AutoBox db)
            : base(db)
        {

        }
        public User Login(string username, string password)
        {
            var user = Get(username);
            if (user != null && user.password != password)
                return null;
            return user;
        }
    }
}
