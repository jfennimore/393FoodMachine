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

        private String description;
        private RecipeCategory category;
        private int prepTime;
        private DateTime dateAdded;
        private int numServings;
        private int caloriesPerServing;
        private double avgCost;

        //The list of ingredients for the recipe, paired with the amount of servings of that Ingredient required
        private List<Tuple<Ingredient, double>> ingredientList;
        
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
            this.caloriesPerServing = CalculateCalories();
            this.avgCost = CalculateAvgCost();
            this.ingredientList = ingredientList;
        }

        public Recipe(String json)
        {
            Recipe imported = JsonConvert.DeserializeObject<Recipe>(json);
            this.id = imported.GetID();
            this.name = imported.GetName();
            this.description = imported.GetDescription();
            this.category = imported.GetCategory();
            this.prepTime = imported.GetPrepTime();
            this.dateAdded = imported.GetDateAdded();
            this.numServings = imported.GetNumServings();
            //TODO: Do we take the JSON Object's word for it that these values are accurate?  For now, yes.
            this.caloriesPerServing = imported.GetCaloriesPerServing();
            this.avgCost = imported.GetAvgCost();
            this.ingredientList = imported.GetIngredientList();            
        }

        //PushItem basically IS 'ExportRecipe()'
        //TODO: Incorporate actual call to API
        public override bool PushItem()
        {
            String jsonObj = JsonConvert.SerializeObject(this);
            Console.Write(jsonObj);
            return true;
        }

        //Getters and Setters for all Ingredient Fields
        public int GetPrepTime()
        {
            return prepTime;
        }

        public void SetPrepTime(int prepTime)
        {
            this.prepTime = prepTime;
        }

        public double GetAvgCost()
        {
            return avgCost;
        }

        public void SetAmount(double amount)
        {
            this.avgCost = amount;
        }

        public String GetDescription()
        {
            return description;
        }

        public void SetDescription(String description)
        {
            this.description = description;
        }

        public RecipeCategory GetCategory()
        {
            return category;
        }

        public void SetCategory(RecipeCategory category)
        {
            this.category = category;
        }

        public DateTime GetDateAdded()
        {
            return dateAdded;
        }

        public void SetDateAdded(DateTime dateAdded)
        {
            this.dateAdded = dateAdded;
        }

        public int GetNumServings()
        {
            return numServings;
        }

        public void SetNumServings(int servings)
        {
            numServings = servings;
        }

        public int GetCaloriesPerServing()
        {
            return caloriesPerServing;
        }

        public void SetCaloriesPerServing(int calories)
        {
            caloriesPerServing = calories;
        }

        public List<Tuple<Ingredient, double>> GetIngredientList()
        {
            return ingredientList;
        }

        //TODO: Every time the ingredient list needs to be updated through an edit, the UI form is just going to recreate the List
        public void SetIngredientList(List<Tuple<Ingredient, double>> ingredientList)
        {
            this.ingredientList = ingredientList;
        }

        //Calculate Avg Cost and Calories Per Serving based on information from Store and Ingredients
        private int CalculateCalories()
        {
            //TODO: reach out to API to get this information
            return 0;
        }

        private double CalculateAvgCost()
        {
            //TODO: reach out to API to get this information
            return 0.0;
        }

    }
}
