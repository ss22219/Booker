using System;
using Booker.Database.Interface;
using iBoxDB.LocalServer;
namespace Booker.Database.iBoxDB
{
    public abstract class BaseDb<T, K> : IBaseDb<T, K> where T : class, new()
    {
        protected AutoBox _db;

        public BaseDb(AutoBox db)
        {
            _db = db;
        }

        public void Delete(K id)
        {
            _db.Delete(TableName.Tables[typeof(T)], id);
        }

        public void Add(params T[] data)
        {
            _db.Insert<T>(TableName.Tables[typeof(T)], data);
        }

        public T Get(K id)
        {
            return _db.SelectKey<T>(TableName.Tables[typeof(T)], id);
        }

        public void Update(T data)
        {
            _db.Update<T>(TableName.Tables[typeof(T)], data);
        }
    }
}
