using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _393_Food_Machine
{
    public class Recipe : Editable
    {
        //All of the categories of Ingredients for Food Machine
        public enum RecipeCategory
        {
           Entree,
           Appetizer,
           Dessert,
           Soups_Stews,
           Breakfast
        }

        //JSON Serialization requires that all of these properties be public, but the Get/Set ensures getter/setter functionality
        public String description { get; set; }
        public RecipeCategory category { get; set; }
        public int prepTime { get; set; }
        public DateTime dateAdded { get; set; }
        public int numServings { get; set; }
        public int caloriesPerServing { get; set; }
        public double avgCost { get; set; }

        //The list of ingredients for the recipe, paired with the amount of servings of that Ingredient required
        public List<Tuple<Ingredient, double>> ingredientList { get; set; }

        [JsonConstructor]
        public Recipe(String name, String description, RecipeCategory category, 
            int prepTime, DateTime dateAdded, 
            int numServings, List<Tuple<Ingredient, double>> ingredientList)
        {
            //this.id =
            this.name = name; 
            this.description = description;
            this.category = category;
            this.prepTime = prepTime;
            this.dateAdded = dateAdded;
            this.numServings = numServings;
            this.ingredientList = ingredientList;
            this.caloriesPerServing = CalculateCalories();
            this.avgCost = CalculateAvgCost();
        }

        public Recipe(String json)
        {
            Recipe imported = JsonConvert.DeserializeObject<Recipe>(json);
            this.id = imported.id;
            this.name = imported.name;
            this.description = imported.description;
            this.category = imported.category;
            this.prepTime = imported.prepTime;
            this.dateAdded = imported.dateAdded;
            this.numServings = imported.numServings;
            //TODO: Do we take the JSON Object's word for it that these values are accurate?  For now, yes.
            this.caloriesPerServing = imported.caloriesPerServing;
            this.avgCost = imported.avgCost;
            this.ingredientList = imported.ingredientList;            
        }

        //PushItem basically IS 'ExportRecipe()'
        //TODO: Incorporate actual call to API
        public override bool PushItem()
        {
            String jsonObj = this.ToString();
            Console.Out.WriteLine(jsonObj);
            return true;
        }

        //Calculate Avg Cost and Calories Per Serving based on information from Store and Ingredients
        private int CalculateCalories()
        {
            double calories = 0.0;
            foreach(Tuple<Ingredient,double> ingredient in ingredientList)
            {
                //Adds the calories per unit/serving of the ingredient times the amount of that ingredient called for in the recipe
                calories += ingredient.Item1.calories * ingredient.Item2;
            }
            //Round off the calories
            return (int) calories; 
        }

        private double CalculateAvgCost()
        {
            //TODO: reach out to API to get this information
            //This method does need the API since all of the cost information is in the Store table.
            return 0.0;
        }

        public bool Equals(Recipe rec)
        {
            bool recipeInfoEqual = this.id == rec.id &&
                this.name == rec.name &&
                this.description.Equals(rec.description) &&
                this.dateAdded.Equals(rec.dateAdded) &&
                this.category == rec.category &&
                this.caloriesPerServing == rec.caloriesPerServing &&
                this.avgCost == rec.avgCost &&
                this.numServings == rec.numServings &&
                this.prepTime == rec.prepTime;
            //Do the easy calculations first
            if (recipeInfoEqual && ingredientList.Count() == rec.ingredientList.Count())
            {
                for (int index = 0; index < ingredientList.Count(); index++)
                {
                    if(ingredientList.ElementAt(index).Item2 != rec.ingredientList.ElementAt(index).Item2)
                    {
                        return false;
                    }
                    //In reality, we're not going to allow two ingredients with the same name, so the name is sufficient to compare
                    if(ingredientList.ElementAt(index).Item1.name != rec.ingredientList.ElementAt(index).Item1.name)
                    {
                        return false;
                    }
                }
                //Got through the full ingredient list without finding different ingredients of different amounts.
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
