using Booker.Database.Model;
using System.Collections.Generic;

namespace Booker.Database.Interface
{
    public interface IBookCollectionDb : IBaseDb<BookCollection, string>
    {
        Dictionary<BookCollection, Book> GetUserBookCollection(string username);
    }
}
