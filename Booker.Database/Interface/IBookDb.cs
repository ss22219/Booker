using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booker.Database.Model;

namespace Booker.Database.Interface
{
    public interface IBookDb : IBaseDb<Book, string>
    {
		List<Book> FindBookByName (string name);
    }
}
