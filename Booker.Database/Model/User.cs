using System;
namespace Booker.Database.Model
{
    [Serializable]
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string nicename { get; set; }
        public string email { get; set; }
    }
}
