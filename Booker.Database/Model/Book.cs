using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Database.Model
{
    public class Book
    {
        public Book()
        {
            id = ObjectId.NewObjectId();
        }
        public string name { get; set; }
        public string id { get; set; }
    }
}
