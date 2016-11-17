using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _393_Food_Machine
{
    public partial class IndivRecipeUI : Form
    {
        private Recipe indivRecipe;

        public IndivRecipeUI(int id)
        {
            InitializeComponent();

            //Grab the contents of this recipe from the API
            bool successfulPull = PullRecipeByID(id);
            if(!successfulPull)
            {
                Console.Error.Write(String.Format("Did not successfully pull recipe with id: %d", id));
            }
            InitializeFields();
        }

        public IndivRecipeUI(String json)
        {
            InitializeComponent();
            indivRecipe = new Recipe(json);
            InitializeFields();
        }

        private void InitializeFields()
        {
            //Set title
            title.Text = indivRecipe.name;

            //Set recipe Category
            categoryLabel.Text = Enum.GetName(typeof(Recipe.RecipeCategory), indivRecipe.category);

            //Add the ingredients
            foreach (Tuple<Ingredient, double, Ingredient.measurementUnits> ingredient in indivRecipe.ingredientList)
            {
                ingredientListBox.Items.Add(String.Format("{0}\t\t{1} {2}",
                    ingredient.Item1.name,
                    ingredient.Item2,
                    ingredient.Item3));
            }
            //Add prep description
            StringBuilder recipeDesc = new StringBuilder();
            recipeDesc.AppendLine(String.Format("Prep Time: {0} min.", indivRecipe.prepTime));
            recipeDesc.AppendLine(String.Format("Number of Servings: {0}", indivRecipe.numServings));
            recipeDesc.AppendLine(String.Format("Calories per Serving: {0}", indivRecipe.caloriesPerServing));
            recipeDesc.AppendLine(String.Format("Avg Cost to make: {0}{1}", indivRecipe.avgCost, Environment.NewLine));
            recipeDesc.AppendLine(String.Format("Description:\t{0}",indivRecipe.description));
            descriptionTextBox.Text = recipeDesc.ToString();
            descriptionTextBox.ReadOnly = true;
        }

        //Initialize the Recipe object of this UI page from the JSON returned from the API
        public bool PullRecipeByID(int id)
        {
            //Get the Recipe from the API - make an HTTP request for GetRecipe(ID)
            String jsonObj = "";
            indivRecipe = new _393_Food_Machine.Recipe(jsonObj);
            if (/* jsonObj received from HTTP request */ true)
            {
                return true;
            }
            else
            {
                //return false;
            }
        }

        private void editRecipeButton_Click(object sender, EventArgs e)
        {
            (new EditRecipe(indivRecipe.ToString())).Show();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            (new RecipeList()).Show();
            this.Close();
        }

        //Let user specify where they want the exported recipe to go, then create a file with the name of the recipe.json
        private void exportButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult pathResult = fbd.ShowDialog();
            String newFilePath = fbd.SelectedPath + "\\" + indivRecipe.name + ".json";
            System.IO.FileStream jsonFile = System.IO.File.Create(newFilePath);
            jsonFile.Close();
            System.IO.File.WriteAllText(newFilePath, indivRecipe.ToString());
        }
    }
}
