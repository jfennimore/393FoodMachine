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

        public int calories;
        public double amount;
        public String unit;
        public IngredientCategory category;

        public Ingredient(String name, int calories, double amount, String unit, IngredientCategory category)
        {
            this.id = 0;
            this.name = name;
            this.calories = calories;
            this.amount = amount;
            this.unit = unit;
            this.category = category;
        }

        public Ingredient(String json)
        {
            Ingredient imported = JsonConvert.DeserializeObject<Ingredient>(json);
            this.id = imported.GetID();
            this.name = imported.GetName();
            this.calories = imported.GetCalories();
            this.amount = imported.GetAmount();
            this.unit = imported.GetUnit();
            this.category = imported.GetCategory();
        } 

        public override bool PushItem()
        {
            String jsonObj = JsonConvert.SerializeObject(this);
            Console.Out.WriteLine(jsonObj);
            return true;
        }

        //Getters and Setters for all Ingredient Fields
        public int GetCalories()
        {
            return calories;
        }

        public void SetCalories(int calories)
        {
            this.calories = calories;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void SetAmount(double amount)
        {
            this.amount = amount;
        }

        public String GetUnit()
        {
            return unit;
        }

        public void SetUnit(String unit)
        {
            this.unit = unit;
        }

        public IngredientCategory GetCategory()
        {
            return category;
        }

        public void SetCategory(IngredientCategory category)
        {
            this.category = category;
        }
    }
}
