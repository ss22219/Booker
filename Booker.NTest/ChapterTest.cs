using Booker.Database;
using Booker.Database.iBoxDB;
using Booker.Database.Model;
using iBoxDB.LocalServer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.NTest
{
    [TestFixture()]
    public class ChapterTest
    {

        [Test]
        public void ChapterTestInsertData()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<Chapter>(TableName.Chapters, "id");
                var db = server.Open();
                var chapterDb = new ChapterDb(db);
                chapterDb.Add(new Chapter()
                {
                    id = "1",
                    name = "chapter1",
                    bookid = "1"
                });
                chapterDb.Delete("1");
            }

        }


        [Test]
        public void ChapterTestFindData()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<Chapter>(TableName.Chapters, "id");
                var db = server.Open();
                var chapterDb = new ChapterDb(db);
                
                chapterDb.Add(new Chapter()
                {
                    id = "1",
                    name = "chapter1",
                    bookid = "1"
                });
                var list = chapterDb.GetChaptersByBookId("1");
                chapterDb.Delete("1");
                Assert.True(list.Count > 0);
            }

        }

    }
}
