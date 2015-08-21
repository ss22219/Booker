using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iBoxDB;
using iBoxDB.LocalServer;
using System.IO;
using Booker.Database.Model;
using Booker.Database;
namespace Booker.Test
{
    [TestClass]
    public class iBoxTest
    {

        [TestMethod]
        public void CreateDbTest()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var server = new DB(path);

        }

        [TestMethod]
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
            }
        }


        [TestMethod]
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

        [TestMethod]
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
                Assert.AreNotEqual(book, null);
            }
        }

        [TestMethod]
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

                db.Update<Book>(TableName.Books, "1", new Book() { 
                    id = "1",
                    name = updateName
                });


                var book = db.SelectKey<Book>(TableName.Books, "1");
                Assert.AreEqual(book.name, updateName);
            }
        }

        [TestMethod]
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
