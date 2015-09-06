using System;
using System.Collections.Generic;

namespace Booker.Database.Interface
{
    public interface IBaseDb<T,K> where T : class, new()
    {
        void Delete(K id);

        void Add(params T[] data);

        void Update(T data);
        
        T Get(K id);

        List<T> Where(string field, string value);
    }
}
