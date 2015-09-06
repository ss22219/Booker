using System;

namespace Booker.Database.Model
{
    public class Book : ModelBase
    {
        public string name { get; set; }

        public string author { get; set; }

        public string lastchapter { get; set; }

        public string lastchapterid { get; set; }
    }
}
