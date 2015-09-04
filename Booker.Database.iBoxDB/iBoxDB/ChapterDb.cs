using Booker.Database.Interface;
using Booker.Database.Model;
using iBoxDB.LocalServer;
using System.Collections.Generic;
using System.Linq;

namespace Booker.Database.iBoxDB
{
    public class ChapterDb : BaseDb<Chapter, string>, IChapterDb
    {
        public ChapterDb(AutoBox db)
            : base(db)
        {

        }
        public List<Chapter> GetChaptersByBookId(string bookid)
        {
            return _db.Select<Chapter>("from " + TableName.Chapters + " where bookid=?", bookid).ToList();
        }
    }
}
