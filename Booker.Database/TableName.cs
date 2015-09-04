using System;
using System.Collections.Generic;
using Booker.Database.Model;

namespace Booker.Database
{
    public class TableName
    {
        public const string Books = "books";
        public const string Chapters = "chapters";

        public static readonly Dictionary<Type, string> Tables = new Dictionary<Type, string>() 
        { 
           { typeof(Book), Books},
           { typeof(Chapter), Chapters},
        };
    }
}
