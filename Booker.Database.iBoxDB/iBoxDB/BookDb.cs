using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booker.Database.Model;
using iBoxDB.LocalServer;

namespace Booker.Database.iBoxDB
{
    public class BookDb : BaseDb<Book, string>
    {
        public BookDb(AutoBox db)
            : base(db)
        {

        }
    }
}
