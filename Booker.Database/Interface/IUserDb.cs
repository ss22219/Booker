using Booker.Database.Model;

namespace Booker.Database.Interface
{
    public interface IUserDb : IBaseDb<User, string>
    {
         User Login(string username, string password);
    }
}
