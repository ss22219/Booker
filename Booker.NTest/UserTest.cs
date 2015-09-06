using Booker.Database;
using Booker.Database.iBoxDB;
using Booker.Database.Interface;
using Booker.Database.Model;
using iBoxDB.LocalServer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.NTest
{
    [TestFixture()]
    public class UserTest
    {
        [Test]
        public void UserTestGetData()
        {
            var path = "ibox";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (var server = new DB(path))
            {
                var config = server.GetConfig();
                config.EnsureTable<User>(TableName.Users, "username");
                var db = server.Open();
                Booker.Database.Interface.IUserDb userDb = new UserDb(db) as IUserDb;
                var user = userDb.Get("gool");

            }
        }

    }
}
