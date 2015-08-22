using System;
using iBoxDB;
using iBoxDB.LocalServer;
using System.IO;
using Booker.Database.Model;
using Booker.Database;
using NUnit.Framework;


namespace Booker.Test
{
	[TestFixture ()]
    public class iBoxTest
    {

        [Test]
        public void CreateDbTest()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
			using (var server = new DB(path)){
				var db = server.Open ();
				Assert.IsTrue (db != null);
			}
        }

        [Test]
        public void CreateTable()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<Book>(TableName.Books, "id");
				var db = server.Open();
				Assert.IsTrue (db != null);
            }
        }


        [Test]
        public void InsertData()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<Book>(TableName.Books, "id");
                var db = server.Open();

                db.Insert<Book>(TableName.Books, new Book()
                {
                    id = "1",
                    name = "book1"
                });
            }

        }

        [Test]
        public void FindData()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<Book>(TableName.Books, "id");
                var db = server.Open();

				var book = db.SelectKey<Book>(TableName.Books, "1");
				if (book == null) {
					db.Insert<Book> (TableName.Books, new Book () {
						id = "1",
						name = "book1"
					});
				}
                book = db.SelectKey<Book>(TableName.Books, "1");
                Assert.AreNotEqual(book, null);
            }
        }

        [Test]
        public void UpdateData()
        {
            var path = "ibox";
            var updateName = "book_updated";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<Book>(TableName.Books, "id");
                var db = server.Open();
				var book = db.SelectKey<Book>(TableName.Books, "1");
				if (book == null) {
					db.Insert<Book> (TableName.Books, new Book () {
						id = "1",
						name = "book1"
					});
				}
                db.Update<Book>(TableName.Books, "1", new Book() { 
                    id = "1",
                    name = updateName
                });


                book = db.SelectKey<Book>(TableName.Books, "1");
                Assert.AreEqual(book.name, updateName);
            }
        }

        [Test]
        public void RemoveData()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<Book>(TableName.Books, "id");
                var db = server.Open();

                db.Delete(TableName.Books, "1");

                var book = db.SelectKey<Book>(TableName.Books, "1");
                Assert.AreEqual(book, null);
            }

        }
    }
}
