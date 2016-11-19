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

        public bool PushExistingItem() {
            try
            {
                String result = Models.APICalls.putCall(this);
                Console.Out.WriteLine(result);
                return true;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(String.Format("There was a problem updating {0}", this.name));
                return false;
            }
            
        }

        public bool DeleteItem()
        {
            try
            {
                String result = Models.APICalls.deleteCall(this);
                Console.Out.WriteLine(result);
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(String.Format("There was a problem deleting {0}", this.name));
                return false;
            }
        }

        //The string representation of an Editable object should be the JSON representation of it.
        public override string ToString()
        {
            Editable product = (Editable)this.MemberwiseClone();
            String jsonObj = JsonConvert.SerializeObject(product);
            return jsonObj;
        }
    }
}
