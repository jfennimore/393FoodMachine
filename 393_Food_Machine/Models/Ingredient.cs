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
            //This is a bit of a fudge- putting measurements of weight with volume.
            //But, for the sake of avoiding excessive complexity, we'll allow people
            //to list ingredients in whatever form they choose, and do our best to 
            //approximate the equivalent conversion
            quarts,
            gallons,
            oz,
            na
        }

        public int calories { get; set; }
        //public double amount; //I don't think we ACTUALLY need this!
        public measurementUnits unit { get; set; }
        public IngredientCategory category { get; set; }

        [JsonConstructor]
        public Ingredient(String name, int calories, measurementUnits unit, IngredientCategory category)
        {
            this.name = name;
            this.calories = calories;
            this.unit = unit;
            this.category = category;
        }

        public Ingredient(String name, int calories, int unit, int category)
        {
            this.name = name;
            this.calories = calories;
            this.unit = (measurementUnits)unit;
            this.category = (IngredientCategory)category;
        }

        public Ingredient(String json)
        {
            try
            {
                Ingredient imported = JsonConvert.DeserializeObject<Ingredient>(json);
                this.uri = imported.uri;
                this.name = imported.name;
                this.calories = imported.calories;
                this.unit = imported.unit;
                this.category = imported.category;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("The given JSON could not be parsed into an ingredient");
                return;
            }
        } 

        public override bool PushNewItem()
        {
            try
            {
                String jsonWithURI = Models.APICalls.postNewIngredient(this);
                Ingredient confirmed = Models.APICalls.extractFromJson<Ingredient>(jsonWithURI, "ingredient");
                this.uri = confirmed.uri;
                return true;
            }
            catch(Exception e)
            {
                //There must have been an issue deserializing the result of the request.
                System.Windows.Forms.MessageBox.Show(String.Format("There was an issue posting {0}: {1}", this.name, e.Message));
                return false;
            }
        }

        public bool Equals(Ingredient ingr)
        {
            return this.name.Equals(ingr.name);
        }

        public static double getUnitDouble(String unitName)
        {
            switch(unitName)
            {
                case "tsp": return 1.0;
                    break;
                case "tbsp": return 3.0;
                    break;
                case "cups": return 48.0;
                    break;
                case "lbs": return 144.0;
                    break;
                case "quarts": return 192.0;
                    break;
                case "gallons": return 768.0;
                    break;
                case "oz": return 9.0;
                    break;
                case "na": return 1.0;
                    break;
                default:
                    return 1.0;
            }
        }

        public static double getUnitDouble(Ingredient.measurementUnits unitName)
        {
            switch (unitName)
            {
                case Ingredient.measurementUnits.tsp:
                    return 1.0;
                    break;
                case Ingredient.measurementUnits.tbsp:
                    return 3.0;
                    break;
                case Ingredient.measurementUnits.cups:
                    return 48.0;
                    break;
                case Ingredient.measurementUnits.lbs:
                    return 144.0;
                    break;
                case Ingredient.measurementUnits.quarts:
                    return 192.0;
                    break;
                case Ingredient.measurementUnits.gallons:
                    return 768.0;
                    break;
                case Ingredient.measurementUnits.oz:
                    return 9.0;
                    break;
                case Ingredient.measurementUnits.na:
                    return 1.0;
                    break;
                default:
                    return 1.0;
            }
        }

    }
}
