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
            
            //Set title
            title.Text = indivRecipe.GetName();
            
            //Add the ingredients
            foreach (Tuple<Ingredient, double> ingredient in indivRecipe.GetIngredientList())
            {
                ingredientListBox.Items.Add(String.Format("%s\t\t\t%d %s", 
                    ingredient.Item1.GetName(), 
                    ingredient.Item2, 
                    ingredient.Item1.GetUnit()));
            }
            //Add prep description
            descriptionListBox.Items.Add(String.Format("Prep Time: %d",indivRecipe.GetPrepTime()));
            descriptionListBox.Items.Add(String.Format("Number of Servings: %d", indivRecipe.GetNumServings()));
            descriptionListBox.Items.Add(String.Format("Calories per Serving: %d\n", indivRecipe.GetCaloriesPerServing()));
            descriptionListBox.Items.Add(indivRecipe.GetDescription());
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
    }
}
