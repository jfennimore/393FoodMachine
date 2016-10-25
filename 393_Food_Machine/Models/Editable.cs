using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _393_Food_Machine
{
    public abstract class Editable
    {
        public int id { get; set; }
        public String name { get; set; }
        //Push the item to the API as a JSON object and then validate that the object was received.
        public abstract bool PushItem();
    }
}
