using System;
using Booker.Database.Interface;
using Booker.Database.Model;


namespace Booker
{
    public class IndexModule : BaseForeModule
	{
		IBookDb bookDb;

		public IndexModule (IBookDb bookDB)
		{

			this.bookDb = bookDB;

			Get["/"] = _ =>{ 
				var bookName = "book1";
				var books = bookDb.FindBookByName (bookName);

				if (books.Count == 0) {
					bookDb.Add (new Book () { 
						name = bookName
					});
					books = bookDb.FindBookByName (bookName);
				};
				return View["index",books];
			};
		}
	}
}