using System;

namespace Booker.Database.Model
{
    public class Book
    {
        public Book()
        {
            id = ObjectId.NewObjectId();
        }
        public string name { get; set; }

        public string author { get; set; }

        public string id { get; set; }
    }
}
