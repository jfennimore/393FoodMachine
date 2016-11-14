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

namespace _393_Food_Machine
{
    public partial class RecipeList : Form
    {
        //Binds recipe names with their ID's and their JSON representations
        private List<Tuple<String, int, String>> recipeList;

        public RecipeList()
        {
            InitializeComponent();
            PullItems();
            
            foreach (Tuple<String,int,String> recipe in recipeList)
            {
                recipeListBox.Items.Add(recipe.Item1);
            }

            
        }

        public bool PullItems()
        {
            //Get the list of recipe names and ID's from the API
            recipeList = new List<Tuple<String, int, String>>();
            //The following a just demo recipes generated client-side to add to this list
            recipeList.Add(new Tuple<String, int,String>("Cake", 3, jsonCake()));
            recipeList.Add(new Tuple<String, int, String>("Meatballs", 5, jsonMeatballs()));
            return true;
        }

        //User selected an item in the list
        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = recipeListBox.SelectedIndex;
            int recipeId = recipeList.ElementAt(index).Item2;
            //Match the selected index to the index of the Recipe in the list and get the id for that recipe
            String jsonRecipe = recipeList.ElementAt(index).Item3;
            (new IndivRecipeUI(jsonRecipe)).Show();
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
                Recipe.RecipeCategory.Dessert, 30, DateTime.Today, 8, ingrList);
            return cake.ToString();
        }

        private String jsonMeatballs()
        {
            Ingredient egg = new Ingredient("Egg", 100, Ingredient.measurementUnits.tbsp, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient ground_beef = new Ingredient("Ground Beef", 300, Ingredient.measurementUnits.lbs, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient breadcrumbs = new Ingredient("Breadcrumbs", 100, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Baking_Spices);
            Ingredient cheese = new Ingredient("Grated Cheese", 200, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Dairy);
            List<Tuple<Ingredient, double, Ingredient.measurementUnits>> ingrList = new List<Tuple<Ingredient, double, Ingredient.measurementUnits>>();
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(egg, 1, Ingredient.measurementUnits.na));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(ground_beef, 1, Ingredient.measurementUnits.lbs));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(breadcrumbs, 1.5, Ingredient.measurementUnits.cups));
            ingrList.Add(new Tuple<Ingredient, double, Ingredient.measurementUnits>(cheese, 1, Ingredient.measurementUnits.cups));
            Recipe meatballs = new _393_Food_Machine.Recipe("Meatballs",
                "Mix together meat, eggs, breadcrumbs all at once, then break off pieces, roll into balls, place on a pan and bake at 350F for 20 minutes.",
                Recipe.RecipeCategory.Dessert, 30, DateTime.Today, 6, ingrList);
            return meatballs.ToString();
        }

        private void recipeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(recipeFilter.Text)
            {
                case "Category":
                    RecipeCategorySelect rsc = new RecipeCategorySelect(this);
                    rsc.Show();
                    //Filter out by category
                    break;
                case "Calories":
                    break;
                case "Cost":
                    break;
                case "Ingredient":
                    break;
            }
        }

        public void setFilterText(String filter)
        {
            recipeFilter.Text = filter;
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new EditRecipe()).Show();
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
                    recipeList.Add(new Tuple<string, int, string>(importedRec.name, 5, jsonObj));
                    recipeListBox.Items.Add(importedRec.name);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Recipes can only be imported in JSON format");
            }
        }
    }
}
