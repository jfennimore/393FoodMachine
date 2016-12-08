using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _393_Food_Machine
{
    public class Recipe : Editable
    {
        //All of the categories of Ingredients for Food Machine
        public enum RecipeCategory
        {
           Entree,
           Side_Dish,
           Appetizer,
           Dessert,
           Soups_Stews,
           Breakfast
        }

        public enum DishType
        {
            Other,
            Roast,
            Casserole,
            Stew,
            Soup,
            Dough,
            Pie,
            Cake,
            Cookie
        }


        //JSON Serialization requires that all of these properties be public, but the Get/Set ensures getter/setter functionality
        public String description { get; set; }
        public RecipeCategory category { get; set; }
        public DishType dishType { get; set; }
        public int prepTime { get; set; }
        public DateTime dateAdded { get; set; }
        //If this isn't confusing, I don't know what is - the property can't reference itself when you spell out the accessors
        private int NumServings;
        public int numServings
        {
            get
            {
                return NumServings;
            }
            set
            {
                NumServings = value;
                caloriesPerServing = CalculateCalories(); //Changing the number of servings for the recipe necessarily changes the number of calories per serving
            }
        }
        public int caloriesPerServing { get; set; }
        public double avgCost { get; set; }

        //The list of ingredients for the recipe, paired with the amount of servings of that Ingredient required
        public List<Tuple<Ingredient, double, Ingredient.measurementUnits>> ingredientList { get; set; }

        [JsonConstructor]
        public Recipe(String name, String description, RecipeCategory category, DishType dishType, 
            int prepTime, DateTime dateAdded, 
            int numServings, List<Tuple<Ingredient, double, Ingredient.measurementUnits>> ingredientList)
        {
            this.uri = "";
            this.name = name; 
            this.description = description;
            this.category = category;
            this.dishType = dishType;
            this.prepTime = prepTime;
            this.dateAdded = dateAdded;
            this.ingredientList = ingredientList;
            this.numServings = numServings;
            this.caloriesPerServing = CalculateCalories();
            this.avgCost = CalculateAvgCost();
        }

        public Recipe(String json)
        {
            try
            {
                Recipe imported = JsonConvert.DeserializeObject<Recipe>(json);
                this.uri = imported.uri;
                this.name = imported.name;
                this.description = imported.description;
                this.category = imported.category;
                this.dishType = imported.dishType;
                this.prepTime = imported.prepTime;
                this.dateAdded = imported.dateAdded;
                this.ingredientList = imported.ingredientList;
                //IngredientList cannot be null when assigning to numServings
                this.numServings = imported.numServings;
                //TODO: Do we take the JSON Object's word for it that these values are accurate?  For now, yes.
                this.caloriesPerServing = imported.caloriesPerServing;
                this.avgCost = imported.avgCost;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("The given JSON could not be parsed into a recipe");
                return;
            }
                       
        }

        //PushItem basically IS 'ExportRecipe()'
        public override bool PushNewItem()
        {
            try
            {
                String jsonWithURI = Models.APICalls.postNewRecipe(this);
                Recipe confirmed = Models.APICalls.extractFromJson<Recipe>(jsonWithURI, "recipe");
                this.uri = confirmed.uri;
                return true;
            }
            catch (Exception e)
            {
                //There must have been an issue deserializing the result of the request.

                System.Windows.Forms.MessageBox.Show(String.Format("There was an issue posting {0}: {1}", this.name, e.Message));
                return false;
            }
        }

        //Calculate Avg Cost and Calories Per Serving based on information from Store and Ingredients
        private int CalculateCalories()
        {
            double calories = 0.0;
            foreach(Tuple<Ingredient,double,Ingredient.measurementUnits> ingredient in ingredientList)
            {
                //Adds the calories per unit/serving of the ingredient times the amount of that ingredient called for in the recipe
                double conversionFactor = DetermineConversionFactor(ingredient.Item1.unit, ingredient.Item3);
                calories += ingredient.Item1.calories * conversionFactor * ingredient.Item2;
            }
            //Round off the calories
            return (int) (calories/numServings); 
        }

        private double DetermineConversionFactor(Ingredient.measurementUnits ingrUnit, Ingredient.measurementUnits recipeUnit)
        {
            //Things with unit 'na' are for miscellaneous ingredients where the number of it implies 'one of these' like 1 egg.
            //Therefore, ignore any 'conversion' that might go on with this, because it's impossible to tell how large 'one of' could be.
            if (recipeUnit == 0 || ingrUnit == 0)
            {
                return 1;
            }
            else
            {
                return Ingredient.getUnitDouble(recipeUnit) / Ingredient.getUnitDouble(ingrUnit);
            }
            
        }

        private double CalculateAvgCost()
        {
            //TODO: reach out to API to get this information
            //This method does need the API since all of the cost information is in the Store table.
            return 0.0;
        }

        public bool Equals(Recipe rec)
        {
            bool recipeInfoEqual = this.uri == rec.uri &&
                this.name == rec.name &&
                this.description.Equals(rec.description) &&
                this.dateAdded.Equals(rec.dateAdded) &&
                this.category == rec.category &&
                this.dishType == rec.dishType &&
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

        public int recipeContains(Ingredient ingredient)
        {
            int index = 0;
            foreach (Tuple<Ingredient,double,Ingredient.measurementUnits> tuple in ingredientList)
            {
                if (tuple.Item1.Equals(ingredient))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public void addIngredient(Ingredient ingredient, String amount, String unit)
        {
            if(recipeContains(ingredient) == -1)
            {
                ingredientList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>
                                    (ingredient,
                                    Double.Parse(amount),
                                    (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), unit))
                                );
            }
            else
            {
                Tuple<Ingredient, double, Ingredient.measurementUnits> original = ingredientList[recipeContains(ingredient)];
                Tuple<Ingredient, double, Ingredient.measurementUnits> additional = new Tuple<Ingredient, double, Ingredient.measurementUnits>
                                    (ingredient,
                                    Double.Parse(amount),
                                    (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), unit));
                double newAmount = (original.Item2 * Ingredient.getUnitDouble(original.Item3) + additional.Item2 * Ingredient.getUnitDouble(additional.Item3)) / Ingredient.getUnitDouble(original.Item3);
                Tuple<Ingredient, double, Ingredient.measurementUnits> result = new Tuple<Ingredient, double, Ingredient.measurementUnits>(
                                    ingredient,
                                    newAmount,
                                    original.Item3
                    );
                ingredientList[recipeContains(ingredient)] = result;
            }
            
        }

        public void updateIngredient(int index, Ingredient ingredient, String amount, String unit)
        {
            ingredientList[index] = (new Tuple<Ingredient, double, Ingredient.measurementUnits>
                    (ingredient,
                    Double.Parse(amount),
                    (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), unit))
                );
        }

    }
}
