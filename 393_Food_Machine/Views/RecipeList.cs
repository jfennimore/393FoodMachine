using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace _393_Food_Machine
{
    public partial class RecipeList : Form
    {
        //Binds recipe names with their ID's and their JSON representations
        private List<Recipe> recipeList;

        public RecipeList()
        {
            InitializeComponent();
            filterValue.Visible = false;
            filterOK.Visible = false;
            PullItems();
            populateRecipeList();
        }

        public bool PullItems()
        {
            Views.LoadingScreen ls = new Views.LoadingScreen();
            ls.Show();
            JObject outerLayer = JObject.Parse(Models.APICalls.getAllRecipes());
            ls.Hide();
            recipeList = JsonConvert.DeserializeObject<List<Recipe>>(outerLayer.GetValue("recipes").ToString());
            recipeList = new List<Recipe>();
            recipeList.Add(new Recipe(jsonCake()));
            recipeList.Add(new Recipe(jsonMeatballs()));
            return true;
        }

        private void populateRecipeList()
        {
            recipeListBox.Items.Clear();
            foreach (Recipe recipe in recipeList)
            {
                recipeListBox.Items.Add(recipe.name);
            }
        }

        //User selected an item in the list
        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = recipeListBox.SelectedIndex;
            String jsonRecipe = recipeList.ElementAt(index).ToString();
            (new IndivRecipeUI(jsonRecipe)).Show();
            this.Close();
        }

        private String jsonCake()
        {
            Ingredient egg = new Ingredient("Egg", 100, Ingredient.measurementUnits.tbsp, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient sugar = new Ingredient("Sugar", 200, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient flour = new Ingredient("Flour", 100, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient butter = new Ingredient("Butter", 100, Ingredient.measurementUnits.tbsp, Ingredient.IngredientCategory.Dairy);
            List<Tuple<Ingredient, double, Ingredient.measurementUnits>> ingrList = new List<Tuple<Ingredient, double, Ingredient.measurementUnits>>();
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(egg, 3, Ingredient.measurementUnits.na));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(sugar, 2, Ingredient.measurementUnits.lbs));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(flour, 2, Ingredient.measurementUnits.cups));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(butter, 1, Ingredient.measurementUnits.lbs));
            Recipe cake = new _393_Food_Machine.Recipe("Cake", 
                "Blend on high mix, thoroughly whipping the butter and sugar together until they are creamy and smooth.  Then slowly add the flour a few tablespoons at a time until just mixed.", 
                Recipe.RecipeCategory.Dessert, Recipe.DishType.Cake, 50, DateTime.Today.Subtract(TimeSpan.FromDays(1)), 8, ingrList);
            return cake.ToString();
        }

        private String jsonMeatballs()
        {
            Ingredient egg = new Ingredient("Egg", 100, Ingredient.measurementUnits.tbsp, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient ground_beef = new Ingredient("Ground Beef", 300, Ingredient.measurementUnits.lbs, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient breadcrumbs = new Ingredient("Breadcrumbs", 100, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient cheese = new Ingredient("Grated Cheese", 200, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Dairy);
            Ingredient milk = new Ingredient("Milk", 150, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Dairy);
            List<Tuple<Ingredient, double, Ingredient.measurementUnits>> ingrList = new List<Tuple<Ingredient, double, Ingredient.measurementUnits>>();
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(egg, 1, Ingredient.measurementUnits.na));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(ground_beef, 1, Ingredient.measurementUnits.lbs));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(breadcrumbs, 1.5, Ingredient.measurementUnits.cups));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(cheese, 1, Ingredient.measurementUnits.cups));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(milk, .5, Ingredient.measurementUnits.cups));
            Recipe meatballs = new _393_Food_Machine.Recipe("Meatballs",
                "Mix together meat, eggs, breadcrumbs all at once, then break off pieces, roll into balls, place on a pan and bake at 350F for 20 minutes.",
                Recipe.RecipeCategory.Entree, Recipe.DishType.Roast, 30, DateTime.Today, 6, ingrList);
            return meatballs.ToString();
        }

        private void recipeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(recipeFilter.Text)
            {
                case "Category":
                    RecipeCategorySelect rsc = new RecipeCategorySelect(this);
                    rsc.Show();
                    //Filter out by category- triggered by the OK from the RSC
                    filterValue.Visible = false;
                    filterOK.Visible = false;
                    break;
                case "Calories":
                    filterOK.Visible = true;
                    filterValue.Visible = true;
                    filterValue.Text = "(Cutoff)";
                    break;
                case "Cost":
                    filterOK.Visible = true;
                    filterValue.Visible = true;
                    filterValue.Text = "(Cutoff)";
                    break;
                case "Ingredient":
                    break;
                //Reset the filters
                case "No Filter":
                    filterValue.Visible = false;
                    filterOK.Visible = false;
                    PullItems();
                    populateRecipeList();
                    break;
            }
        }

        public void setFilterText(String filter)
        {
            recipeFilter.Text = filter;
        }

        public void filterByCategory(Recipe.RecipeCategory category)
        {
            PullItems();
            List<Recipe> newRecipeList = new List<Recipe>();
            foreach (Recipe recipe in recipeList)
            {
                if (recipe.category.Equals(category))
                {
                    newRecipeList.Add(recipe);
                }
            }
            recipeList = newRecipeList;
            populateRecipeList();
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            (new EditRecipe()).Show();
            this.Close();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            DialogResult pathResult = fileDialog.ShowDialog();
            String newRecipePath = fileDialog.FileName;
            if(Path.GetExtension(newRecipePath).Equals(".json")) {
                String jsonObj = System.IO.File.ReadAllText(newRecipePath, ASCIIEncoding.ASCII);
                //Constructor of Recipe will validate JSON as good recipe
                Recipe importedRec = new Recipe(jsonObj);
                if(importedRec.name != null)
                {
                    //importedRec.PushNewItem();
                    recipeList.Add(importedRec);
                    recipeListBox.Items.Add(importedRec.name);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Recipes can only be imported in JSON format");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recipeSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (recipeSort.Text)
            {
                case "Category":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r1.category.CompareTo(r2.category); });
                    break;
                case "Recently Added":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r2.dateAdded.CompareTo(r1.dateAdded); });
                    break;
                case "Oldest":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r1.dateAdded.CompareTo(r2.dateAdded); });
                    break;
                case "Calories (Low)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r1.caloriesPerServing.CompareTo(r2.caloriesPerServing); });
                    break;
                case "Calories (High)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r2.caloriesPerServing.CompareTo(r1.caloriesPerServing); });
                    break;
                case "Cost (Low)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r1.avgCost.CompareTo(r2.avgCost); });
                    break;
                case "Prep Time (Low)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r1.prepTime.CompareTo(r2.prepTime); });
                    break;
                case "Number of Servings (Low)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r1.numServings.CompareTo(r2.numServings); });
                    break;
                case "Number of Ingredients (Low)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r1.ingredientList.Count.CompareTo(r2.ingredientList.Count); });
                    break;
                case "Cost (High)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r2.avgCost.CompareTo(r1.avgCost); });
                    break;
                case "Prep Time (High)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r2.prepTime.CompareTo(r1.prepTime); });
                    break;
                case "Number of Servings (High)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r2.numServings.CompareTo(r1.numServings); });
                    break;
                case "Number of Ingredients (High)":
                    recipeList.Sort(delegate (Recipe r1, Recipe r2) { return r2.ingredientList.Count.CompareTo(r1.ingredientList.Count); });
                    break;
            }
            populateRecipeList();
        }

        private void filterOK_Click(object sender, EventArgs e)
        {
            switch(recipeFilter.Text)
            {
                case "Cost":
                    PullItems();
                    double costThreshold = Double.MaxValue;
                    if (Models.FieldValidator.ValidateDoubleNumeric(filterValue, "Filter Cost Cutoff"))
                    {
                        //Remove all recipes above cost threshhold
                        costThreshold = Double.Parse(filterValue.Text);
                    }
                    else
                    {
                        try
                        {
                            decimal testCurrency = decimal.Parse(filterValue.Text, NumberStyles.Currency);
                            costThreshold = (double)testCurrency;
                        }
                        catch (Exception e2)
                        {
                            return;
                        }
                    }

                    if(costThreshold != Double.MaxValue)
                    {
                        List<Recipe> newRecipeList = new List<Recipe>();
                        foreach(Recipe recipe in recipeList)
                        {
                            if(recipe.avgCost <= costThreshold)
                            {
                                newRecipeList.Add(recipe);
                            }
                        }
                        recipeList = newRecipeList;
                        populateRecipeList();
                    }
                    break;
                case "Calories":
                    PullItems();
                    int calThreshold = int.MaxValue;
                    if (Models.FieldValidator.ValidateIntNumeric(filterValue, "Filter Calorie Cutoff"))
                    {
                        //Remove all recipes above cost threshhold
                        calThreshold = Int32.Parse(filterValue.Text);
                    }
                    if (calThreshold != Int32.MaxValue)
                    {
                        List<Recipe> newRecipeList = new List<Recipe>();
                        foreach (Recipe recipe in recipeList)
                        {
                            if (recipe.caloriesPerServing <= calThreshold)
                            {
                                newRecipeList.Add(recipe);
                            }
                        }
                        recipeList = newRecipeList;
                        populateRecipeList();
                    }
                    break;
            }
        }
    }
}
