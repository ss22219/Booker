using Booker.Database.Interface;
using Booker.Database.Model;
using iBoxDB.LocalServer;
using System.Collections.Generic;

namespace Booker.Database.iBoxDB
{
    public class BookCollectionDb : BaseDb<BookCollection, string>, IBookCollectionDb
    {
        public BookCollectionDb(AutoBox db)
            : base(db)
        {

        }
        public Dictionary<BookCollection, Book> GetUserBookCollection(string username)
        {
            var books = new Dictionary<BookCollection, Book>();
            var collections = _db.Select<BookCollection>("from " + TableName.BookCollections + " where username=?", username);
            foreach (var item in collections)
            {
                var book = _db.SelectKey<Book>(TableName.Books, item.bookid);
                if (book != null)
                    books[item] = book;
            }
            return books;
        }
    }
}
