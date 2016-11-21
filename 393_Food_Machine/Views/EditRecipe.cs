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
        private bool isNewRecipe;
        public EditRecipe(int id)
        {
            InitializeComponent();
            isNewRecipe = false;
            //Grab the contents of this recipe from the API
            bool successfulPull = PullRecipeByID(id);
            if (!successfulPull)
            {
                Console.Error.Write(String.Format("Did not successfully pull recipe with id: {0}", id));
                this.Close();
            }
            populateComboBoxes();
            InitializeFields();
        }

        public EditRecipe(String json)
        {
            InitializeComponent();
            isNewRecipe = false;
            indivRecipe = new _393_Food_Machine.Recipe(json);
            populateComboBoxes();
            InitializeFields();
        }

        //Empty EditRecipe will be the same as Creating a new recipe
        public EditRecipe()
        {
            InitializeComponent();
            isNewRecipe = true;
            Text = "Create New Recipe";
            recipeCategoryBox.Text = "<Recipe Category>";
            deleteButton.Visible = false;
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
                String unitName = Models.FieldValidator.getComboName(typeof(Ingredient.measurementUnits), ingredient.Item3);
                ingredientListBox.Items.Add(String.Format("{0}\t\t{1} {2}",
                    ingredient.Item1.name,
                    ingredient.Item2,
                    unitName));
            }
        }

        //Initialize the Recipe object of this UI page from the JSON returned from the API
        public bool PullRecipeByID(int id)
        {
            //Get the Recipe from the API - make an HTTP request for GetRecipe(ID)
            indivRecipe = new Recipe(Models.APICalls.getCall(indivRecipe.uri));
            if (indivRecipe != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if(!isNewRecipe)
            {
                (new IndivRecipeUI(indivRecipe.ToString())).Show();
            }
            else
            {
                (new RecipeList()).Show();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool isNewRecipe = false;

            if (indivRecipe == null)
            {
                //Create a dummy recipe- all of this data is about to be written over anyway.
                isNewRecipe = true;
                indivRecipe = new _393_Food_Machine.Recipe("Dummy", "", Recipe.RecipeCategory.Appetizer, 0, DateTime.Today, 0, new List<Tuple<Ingredient, double, Ingredient.measurementUnits>>());
            }

            //Collect all of the recipe info on the page and push that to the API
            //In the meantime, for demo purposes- go back to IndivRecipe mode showing the changes.
            bool recipeFieldsValid = validateRecipeFields();

            if(recipeFieldsValid)
            {
                indivRecipe.name = title.Text;
                indivRecipe.numServings = Int32.Parse(servingsBox.Text);
                indivRecipe.prepTime = Int32.Parse(prepTimeBox.Text);
                indivRecipe.description = descriptionTextBox.Text;
                indivRecipe.category = (Recipe.RecipeCategory)recipeCategoryBox.SelectedIndex;

                this.Close();
                if (isNewRecipe)
                {
                    indivRecipe.PushNewItem();
                }
                else
                {
                    indivRecipe.PushExistingItem();
                }

                (new IndivRecipeUI(indivRecipe.ToString())).Show();
            }
        }

        private bool validateRecipeFields()
        {
            /* 
             * Validation strategy: Check on each field value, and if there's an issue, short circuit- we'll only allow a push if all fields are valid
             */
            //Validate Title
            if (!Models.FieldValidator.ValidateString(title, "Title", new String[] { "Recipe Name" }))
            {
                return false;
            }
            //Validate Description
            if (!Models.FieldValidator.ValidateString(descriptionTextBox, "Description", new String[] { }))
            {
                return false;
            }
            //Validate number of servings and prep time
            if (!Models.FieldValidator.ValidateIntNumeric(servingsBox, "Number of Servings"))
            {
                return false;
            }
            if (!Models.FieldValidator.ValidateIntNumeric(prepTimeBox, "Prep Time"))
            {
                return false;
            }
            //Validate that there are ingredients
            if (!Models.FieldValidator.ValidateStructureNotEmpty(indivRecipe.ingredientList, "Ingredients"))
            {
                return false;
            }
            //Validate Recipe Category
            if (!Models.FieldValidator.ValidateWithinRange(recipeCategoryBox.SelectedIndex, typeof(Recipe.RecipeCategory), "Recipe Category", recipeCategoryBox.Text))
            {
                return false;
            }
            //If we made it this far, then the recipe is valid.
            return true;
        }

        private void ingredientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ingredientListBox.SelectedIndex;
            //It's possible to select an 'empty' row, and so we need to prevent an OutOfBounds exception.
            if (index < indivRecipe.ingredientList.Count)
            {
                Tuple<Ingredient, double, Ingredient.measurementUnits> selectedIngredient = indivRecipe.ingredientList.ElementAt(index);
                editIngredientName.Text = selectedIngredient.Item1.name;
                editIngredientAmount.Text = selectedIngredient.Item2.ToString();
                editIngredientUnit.Text = selectedIngredient.Item1.unit.ToString();
            }
        }

        private void editIngredientConfirm_Click(object sender, EventArgs e)
        {
            bool editFieldsValid = validateEditFields();
            if(editFieldsValid)
            {
                if (ingredientListBox.SelectedIndex != -1)
                {
                    indivRecipe.ingredientList[ingredientListBox.SelectedIndex] =
                        new Tuple<Ingredient, double, Ingredient.measurementUnits>(indivRecipe.ingredientList[ingredientListBox.SelectedIndex].Item1,
                        Double.Parse(editIngredientAmount.Text),
                        (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits),editIngredientUnit.Text)
                        );
                }
                populateIngredientsBox();
            }
        }

        private bool validateEditFields()
        {
            //Ingredient Name
            if (!Models.FieldValidator.ValidateString(editIngredientName, "Editing Ingredient Name", new String[] { "(Existing Ingredient Name)" }))
            {
                //TODO: Check that the given ingredient name actually exists in the API
                return false;
            }
            //Ingredient Amount
            if (!Models.FieldValidator.ValidateDoubleNumeric(editIngredientAmount, "Edit Ingredient Amount"))
            {
                return false;
            }
            //Ingredient Unit
            if (!Models.FieldValidator.ValidateWithinRange(editIngredientUnit.SelectedIndex, typeof(Ingredient.measurementUnits), "Edit Ingredient Unit", editIngredientUnit.Text))
            {
                return false;
            }

            return true;
        }

        private void newIngrButton_Click(object sender, EventArgs e)
        {
            bool newIngrFieldsValid = validateNewIngrFields();
            if (newIngrFieldsValid)
            {
                //TODO: Get ingredient ID from the name
                Ingredient newIngr = new Ingredient(Models.APICalls.getIngredientByName(newIngredientName.Text));
                indivRecipe.ingredientList.Add(
                    new Tuple<Ingredient,double,Ingredient.measurementUnits>
                    (newIngr, 
                    Double.Parse(editIngredientAmount.Text), 
                    (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), editIngredientUnit.Text))
                );
                //Add ingredient to this Recipe
                populateIngredientsBox();
            }
        }

        private bool validateNewIngrFields()
        {
            //Ingredient Name
            if (!Models.FieldValidator.ValidateString(newIngredientName, "New Ingredient Name", new String[] { "(New Ingredient Name)" }))
            {
                return false;
            }
            //Ingredient Amount
            if (!Models.FieldValidator.ValidateDoubleNumeric(newIngredientAmount, "New Ingredient Amount"))
            {
                return false;
            }
            //Ingredient Unit
            if (!Models.FieldValidator.ValidateWithinRange(newIngredientUnit.SelectedIndex, typeof(Ingredient.measurementUnits), "New Ingredient Unit", newIngredientUnit.Text))
            {
                return false;
            }

            return true;
        }

        private void editIngredientRemove_Click(object sender, EventArgs e)
        {
            if(ingredientListBox.SelectedIndex != -1 && ingredientListBox.SelectedIndex < indivRecipe.ingredientList.Count)
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
