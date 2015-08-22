using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booker.Database.Model;
using iBoxDB.LocalServer;
using Booker.Database.Interface;

namespace Booker.Database.iBoxDB
{
	public class BookDb :  BaseDb<Book,string>,IBookDb
    {
        public BookDb(AutoBox db)
            : base(db)
        {

        }
		public List<Book> FindBookByName (string name){
			return _db.Select<Book> ("from " + TableName.Books + " where name=?",name).ToList();
		}
    }
}
