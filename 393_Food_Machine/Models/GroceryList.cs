using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _393_Food_Machine
{
    public class GroceryList : Editable
    {
        //Triple mapping- Ingredients with the amount of servings that need to be purchased, and then whether or not that item has been purchased
        List<Tuple<Ingredient, double, bool>> groceries;

        public GroceryList(String name, List<Tuple<Ingredient, double, bool>> groceries)
        {
            this.name = name;
            this.groceries = groceries;
        }

        public GroceryList(String json)
        {
            try
            {
                GroceryList imported = JsonConvert.DeserializeObject<GroceryList>(json);
                this.id = imported.id;
                this.name = imported.name;
                this.groceries = imported.GetGroceries();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("The given JSON could not be parsed into a grocery list");
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

        public List<Tuple<Ingredient, double, bool>> GetGroceries()
        {
            return groceries;
        }

        public void SetGroceries(List<Tuple<Ingredient, double, bool>> groceries)
        {
            this.groceries = groceries;
        }
    }
}
