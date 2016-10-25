using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _393_Food_Machine
{
    [JsonObject(MemberSerialization.OptOut)]
    public class Ingredient : Editable
    {
        //All of the categories of Ingredients for Food Machine
        public enum IngredientCategory
        {
            Meat,
            Dairy,
            Produce,
            Baking_Spices,
            Grains_Pasta,
            Canned_Goods
        }

        //These are the most common units for almost all recipes
        public enum measurementUnits
        {
            tsp,
            tbsp,
            cups,
            lbs,
            quarts,
            gallons,
            oz
        }

        public int calories { get; set; }
        //public double amount; //I don't think we ACTUALLY need this!
        public measurementUnits unit { get; set; }
        public IngredientCategory category { get; set; }

        [JsonConstructor]
        public Ingredient(String name, int calories, measurementUnits unit, IngredientCategory category)
        {
            this.id = 0;
            this.name = name;
            this.calories = calories;
            this.unit = unit;
            this.category = category;
        }

        public Ingredient(String json)
        {
            Ingredient imported = JsonConvert.DeserializeObject<Ingredient>(json);
            this.id = imported.id;
            this.name = imported.name;
            this.calories = imported.calories;
            this.unit = imported.unit;
            this.category = imported.category;
        } 

        public override bool PushItem()
        {
            String jsonObj = JsonConvert.SerializeObject(this);
            Console.Out.WriteLine(jsonObj);
            return true;
        }

    }
}
