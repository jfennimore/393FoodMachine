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
    public partial class EditRecipe : Form
    {
        private Recipe indivRecipe;
        public EditRecipe(int id)
        {
            InitializeComponent();

            //Grab the contents of this recipe from the API
            bool successfulPull = PullRecipeByID(id);
            if (!successfulPull)
            {
                Console.Error.Write(String.Format("Did not successfully pull recipe with id: %d", id));
            }
            populateComboBoxes();
            InitializeFields();
        }

        public EditRecipe(String json)
        {
            InitializeComponent();
            indivRecipe = new _393_Food_Machine.Recipe(json);
            populateComboBoxes();
            InitializeFields();
        }

        //Empty EditRecipe will be the same as Creating a new recipe
        public EditRecipe()
        {
            InitializeComponent();
            Text = "Create New Recipe";
            populateComboBoxes();
        }

        private void InitializeFields()
        {
            //Set title
            title.Text = indivRecipe.name;

            //Add the ingredients
            populateIngredientsBox();

            //Add prep description
            prepTimeBox.Text = (String.Format("{0}", indivRecipe.prepTime));
            servingsBox.Text = (String.Format("{0}", indivRecipe.numServings));
            descriptionTextBox.Text = indivRecipe.description;

            recipeCategoryBox.Text = Enum.GetName(typeof(Recipe.RecipeCategory), indivRecipe.category);
            editIngredientName.ReadOnly = true;
        }

        //All of the combo boxes in the form need to be filled in with the Enum values
        private void populateComboBoxes()
        {
            recipeCategoryBox.Items.AddRange(Enum.GetNames(typeof(Recipe.RecipeCategory)));
            editIngredientUnit.Items.AddRange(Enum.GetNames(typeof(Ingredient.measurementUnits)));
            newIngredientUnit.Items.AddRange(Enum.GetNames(typeof(Ingredient.measurementUnits)));
        }

        private void populateIngredientsBox()
        {
            ingredientListBox.Items.Clear();
            foreach (Tuple<Ingredient, double, Ingredient.measurementUnits> ingredient in indivRecipe.ingredientList)
            {
                ingredientListBox.Items.Add(String.Format("{0}\t\t{1} {2}",
                    ingredient.Item1.name,
                    ingredient.Item2,
                    ingredient.Item3));
            }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new IndivRecipeUI(indivRecipe.ToString())).Show();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool allFieldsValid = true;

            if (indivRecipe == null)
            {
                //Create a dummy recipe- all of this data is about to be written over anyway.
                indivRecipe = new _393_Food_Machine.Recipe("Dummy", "", Recipe.RecipeCategory.Appetizer, 0, DateTime.Today, 0, new List<Tuple<Ingredient, double, Ingredient.measurementUnits>>());
            }

            //Collect all of the recipe info on the page and push that to the API
            //In the meantime, for demo purposes- go back to IndivRecipe mode showing the changes.

            /* 
             * Validation strategy: Check on each field value, and if there's an issue, short circuit- we'll only allow a push if all fields are valid
             */
            //Validate Title
            if(! _393_Food_Machine.Models.FieldValidator.ValidateString(title,"Title",new String[] { "Recipe Name" }))
            {
                return;
            }
            //Validate Description
            if (!_393_Food_Machine.Models.FieldValidator.ValidateString(descriptionTextBox, "Description", new String[] { }))
            {
                return;
            }
            //Validate number of servings and prep time
            if (!_393_Food_Machine.Models.FieldValidator.ValidateIntNumeric(servingsBox,"Number of Servings"))
            {
                return;
            }
            if (!_393_Food_Machine.Models.FieldValidator.ValidateIntNumeric(prepTimeBox,"Prep Time"))
            {
                return;
            }
            //Validate that there are ingredients
            if (!_393_Food_Machine.Models.FieldValidator.ValidateStructureNotEmpty(indivRecipe.ingredientList,"Ingredients"))
            {
                return;
            }
            //Validate Recipe Category
            if (!_393_Food_Machine.Models.FieldValidator.ValidateWithinRange(recipeCategoryBox.SelectedIndex,typeof(Recipe.RecipeCategory),"Recipe Category"))
            {
                return;
            }
            //If we made it this far, then the recipe is valid.
            indivRecipe.name = title.Text;
            indivRecipe.numServings = Int32.Parse(servingsBox.Text);
            indivRecipe.prepTime = Int32.Parse(prepTimeBox.Text);
            indivRecipe.description = descriptionTextBox.Text;
            indivRecipe.category = (Recipe.RecipeCategory)recipeCategoryBox.SelectedIndex;

            this.Hide();
            indivRecipe.PushItem();
            (new IndivRecipeUI(indivRecipe.ToString())).Show();
        }

        private void ingredientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ingredientListBox.SelectedIndex;
            Tuple<Ingredient, double, Ingredient.measurementUnits> selectedIngredient = indivRecipe.ingredientList.ElementAt(index);
            editIngredientName.Text = selectedIngredient.Item1.name;
            editIngredientAmount.Text = selectedIngredient.Item2.ToString();
            editIngredientUnit.Text = selectedIngredient.Item1.unit.ToString(); 
        }

        private void editIngredientConfirm_Click(object sender, EventArgs e)
        {
            if (!_393_Food_Machine.Models.FieldValidator.ValidateString(editIngredientName, "Editing Ingredient Name", new String[] { "(Existing Ingredient Name)" }))
            {
                //TODO: Check that the given ingredient name actually exists in the API
                return;
            }
            if (!_393_Food_Machine.Models.FieldValidator.ValidateDoubleNumeric(editIngredientAmount, "Edit Ingredient Amount"))
            {
                return;
            }
            if (!_393_Food_Machine.Models.FieldValidator.ValidateWithinRange(editIngredientUnit.SelectedIndex, typeof(Ingredient.measurementUnits), "Edit Ingredient Unit"))
            {
                return;
            }

            if (ingredientListBox.SelectedIndex != -1)
            {
                indivRecipe.ingredientList[ingredientListBox.SelectedIndex] = 
                    new Tuple<Ingredient, double, Ingredient.measurementUnits>(new Ingredient(
                        editIngredientName.Text, 
                        0, 
                        (Ingredient.measurementUnits) editIngredientUnit.SelectedIndex,
                        indivRecipe.ingredientList[ingredientListBox.SelectedIndex].Item1.category), 
                        Double.Parse(editIngredientAmount.Text),
                        (Ingredient.measurementUnits) editIngredientUnit.SelectedIndex
                    );
            }
            populateIngredientsBox();
        }


        private void addNewIngrButton_Click(object sender, EventArgs e)
        {
            if (!_393_Food_Machine.Models.FieldValidator.ValidateString(newIngredientName, "New Ingredient Name", new String[] { "(New Ingredient Name)" }))
            {
                return;
            }
            if (!_393_Food_Machine.Models.FieldValidator.ValidateDoubleNumeric(newIngredientAmount, "New Ingredient Amount"))
            {
                return;
            }
            if (!_393_Food_Machine.Models.FieldValidator.ValidateWithinRange(newIngredientUnit.SelectedIndex,typeof(Ingredient.measurementUnits),"New Ingredient Unit"))
            {
                return;
            }
            
            //Get ingredient ID from the name
            //Add ingredient to this Recipe
            populateIngredientsBox();
            
        }

        private void editIngredientRemove_Click(object sender, EventArgs e)
        {
            if(ingredientListBox.SelectedIndex != -1)
            {
                indivRecipe.ingredientList.RemoveAt(ingredientListBox.SelectedIndex);
                editIngredientName.Text = "";
                editIngredientAmount.Text = "";
                editIngredientUnit.Text = "";
                populateIngredientsBox();
            }
        }
    }
}
