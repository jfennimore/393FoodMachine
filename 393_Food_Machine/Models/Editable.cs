using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _393_Food_Machine
{
    public abstract class Editable
    {
        public String uri { get; set; }
        public String name { get; set; }
        //Push the item to the API as a JSON object and then validate that the object was received.
        public abstract bool PushNewItem();

        public abstract bool PushExistingItem();

        public abstract bool DeleteItem();

        //The string representation of an Editable object should be the JSON representation of it.
        public override string ToString()
        {
            Editable product = (Editable)this.MemberwiseClone();
            String jsonObj = JsonConvert.SerializeObject(product);
            return jsonObj;
        }
    }
}
