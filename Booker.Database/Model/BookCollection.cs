using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Database.Model
{
    public enum CollectionType
    {
        Read,
        Collection
    }

    public class BookCollection : ModelBase
    {
        public string bookid { get; set; }
        
        public string username { get; set; }
        
        public CollectionType type { get; set; }
        
        public string source { get; set; }

        public string readchapter { get; set; }
        
        public string readchapterid { get; set; }
    }
}
