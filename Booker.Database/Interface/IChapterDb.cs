using Booker.Database.Model;
using System.Collections.Generic;
namespace Booker.Database.Interface
{
    public interface IChapterDb : IBaseDb<Chapter, string>
    {
        List<Chapter> GetChaptersByBookId(string bookid);
    }
}
