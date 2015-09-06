using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Database.Model
{
    public class ModelBase
    {
        public ModelBase()
        {
            id = ObjectId.NewObjectId();
        }
        public string id { get; set; }
    }
}
