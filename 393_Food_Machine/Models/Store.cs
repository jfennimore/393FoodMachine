using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _393_Food_Machine
{
    public class Store : Editable
    {
        //Pairs ingredients from a given store with the prices of those ingredients at the store
        List<Tuple<Ingredient, double>> ingredientCosts;

        public Store(String name, List<Tuple<Ingredient, double>> ingredientCosts)
        {
            this.name = name;
            this.ingredientCosts = ingredientCosts;
        }

        public Store(String json)
        {
            try
            {
                Store imported = JsonConvert.DeserializeObject<Store>(json);
                this.uri = imported.uri;
                this.name = imported.name;
                this.ingredientCosts = imported.GetIngredientCosts();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("The given JSON could not be parsed into a store.");
                return;
            }
            
        }

        //TODO: Incorporate actual call to API
        public override bool PushNewItem()
        {
            String jsonObj = JsonConvert.SerializeObject(this);
            Console.Write(jsonObj);
            return true;
        }

        public override bool PushExistingItem()
        {
            String jsonObj = JsonConvert.SerializeObject(this);
            Console.Write(jsonObj);
            return true;
        }
        public override bool DeleteItem()
        {
            String jsonObj = JsonConvert.SerializeObject(this);
            Console.Write(jsonObj);
            return true;
        }

        public List<Tuple<Ingredient, double>> GetIngredientCosts()
        {
            return ingredientCosts;
        }

        public void SetIngredientCosts(List<Tuple<Ingredient, double>> ingredientCosts)
        {
            this.ingredientCosts = ingredientCosts;
        }
    }
}
