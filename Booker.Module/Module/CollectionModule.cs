using Booker.Database.Interface;
using Booker.Database.Model;
using Nancy.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Module
{
    public class CollectionModule : BaseLoginModule
    {
        IBookCollectionDb _bookCollectionDb;
        IBookDb _bookDb;

        public CollectionModule(IBookCollectionDb bookCollectionDb, IBookDb bookDb)
        {
            _bookCollectionDb = bookCollectionDb;
            _bookDb = bookDb;

            Get["/collection"] = _ => BookCollection();

            Get["/collection/del/{id}"] = param => DeleteCollection(param.id);

            Get["/collection/add/{bookid}"] = param => AddCollection(param.bookid);
        }

        private dynamic DeleteCollection(string id)
        {
            _bookCollectionDb.Delete(id);
            if (Request.Query.returnurl != null)
                return new RedirectResponse(Request.Query.returnurl);
            return "ok";
        }

        private dynamic AddCollection(string bookid)
        {
            var book = _bookDb.Get(bookid);
            if (book == null)
                return Back("错误", "没有找到相关的书籍！");
            var collection = _bookCollectionDb.Where("bookid", bookid).FirstOrDefault();
            if (collection == null)
            {
                _bookCollectionDb.Add(new BookCollection()
                {
                    bookid = bookid,
                    username = User.username,
                    type = CollectionType.Collection
                });
            }
            else if (collection.type != CollectionType.Collection)
            {
                collection.type = CollectionType.Collection;
                _bookCollectionDb.Update(collection);
            }
            if (Request.Query.returnurl != null)
                return new RedirectResponse(Request.Query.returnurl);
            return "ok";
        }

        private dynamic BookCollection()
        {
            return View["/collection/index", _bookCollectionDb.GetUserBookCollection(User.username)];
        }
    }
}
