using System;
using System.Collections.Generic;
using Booker.Database.Model;

namespace Booker.Database.Interface
{
    public interface IBookDb : IBaseDb<Book, string>
    {
		List<Book> FindBookByName (string name);
    }
}
