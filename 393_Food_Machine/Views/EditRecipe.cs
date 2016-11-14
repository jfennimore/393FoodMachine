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

            InitializeFields();
        }

        public EditRecipe(String json)
        {
            InitializeComponent();
            indivRecipe = new _393_Food_Machine.Recipe(json);
            InitializeFields();
        }

        //Empty EditRecipe will be the same as Creating a new recipe
        public EditRecipe()
        {
            InitializeComponent();
            Text = "Create New Recipe";
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

            //Ingredient Unit Combo boxes
            editIngredientUnit.Items.AddRange(Enum.GetNames(typeof(Ingredient.measurementUnits)));
            newIngredientUnit.Items.AddRange(Enum.GetNames(typeof(Ingredient.measurementUnits)));

            editIngredientName.ReadOnly = true;
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
            //Validate Title
            allFieldsValid = allFieldsValid && ValidateTitle();
            //Validate Description
            allFieldsValid = allFieldsValid && ValidateDescription();
            //Validate number of servings and prep time
            allFieldsValid = allFieldsValid && ValidateNumericFields();
            //Validate that there are ingredients
            allFieldsValid = allFieldsValid && ValidateIngredients();

            if (allFieldsValid)
            {
                this.Hide();
                indivRecipe.PushItem();
                (new IndivRecipeUI(indivRecipe.ToString())).Show();
            }
        }

        private bool ValidateIngredients()
        {
            if(indivRecipe.ingredientList.Count > 0)
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Cannot have a new recipe with no ingredients");
                return false;
            }
        }

        private bool ValidateNumericFields()
        {
            //Check if either is empty before anything else
            if (servingsBox.Text.Equals("") || prepTimeBox.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Neither the number of servings nor the prep time may be left empty.  Please fill these out with numeric values");
                return false;
            }
            int newNumServ;
            int newPrepTime;
            bool servingsParsed = Int32.TryParse(servingsBox.Text, out newNumServ);
            bool prepTimeParsed = Int32.TryParse(prepTimeBox.Text, out newPrepTime);
           
            if (!servingsParsed || !prepTimeParsed)
            {
                System.Windows.Forms.MessageBox.Show("Please only use numeric values for servings and prep time!");
                return false;
            }
            else
            {
                indivRecipe.numServings = newNumServ;
                indivRecipe.prepTime = newPrepTime;
                return true;
            }
        }

        private bool ValidateDescription()
        {
            if (!descriptionTextBox.Text.Equals(""))
            {
                indivRecipe.description = descriptionTextBox.Text;
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Description cannot be empty, please try again");
                return false;
            }
        }

        private bool ValidateTitle()
        {
            if (!title.Text.Equals(""))
            {
                //TODO: Check with the API if there is already a recipe with this title
                indivRecipe.name = title.Text;
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Title cannot be empty, please try again");
                return false;
            }
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
            bool editIngrFieldsValid = true;
            editIngrFieldsValid = editIngrFieldsValid && ValidateEditIngredientName();
            editIngrFieldsValid = editIngrFieldsValid && ValidateEditIngredientAmount();

            if (editIngrFieldsValid && ingredientListBox.SelectedIndex != -1)
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

        private bool ValidateEditIngredientName()
        {
            if (editIngredientName.Text.Equals("") || editIngredientName.Text.Equals("(Existing Ingredient Name"))
            {
                System.Windows.Forms.MessageBox.Show("There is no ingredient selected to edit!");
                return false;
            }
            else
            {
                //TODO: Check against the API that this ingredient exists
                return true;
            }
        }

        private bool ValidateEditIngredientAmount()
        {
            double ingredientAmount;
            bool editAmountParsed = Double.TryParse(editIngredientAmount.Text, out ingredientAmount);
            if(!editAmountParsed)
            {
                System.Windows.Forms.MessageBox.Show("Please input a valid numeric value for ingredient amount before confirming");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void addNewIngrButton_Click(object sender, EventArgs e)
        {
            bool newIngrFieldsValid = true;
            newIngrFieldsValid = newIngrFieldsValid && ValidateNewIngredientName();
            newIngrFieldsValid = newIngrFieldsValid && ValidateNewIngredientAmount();
            if(newIngrFieldsValid)
            {
                //Get ingredient ID from the name
                //Add ingredient to this Recipe
                populateIngredientsBox();
            }
        }

        private bool ValidateNewIngredientName()
        {
            if (newIngredientName.Text.Equals("") || newIngredientName.Text.Equals("(Existing Ingredient Name"))
            {
                System.Windows.Forms.MessageBox.Show("Please address the ingredient name before adding new ingredient");
                return false;
            }
            else
            {
                //TODO: Check against the API that this ingredient exists
                return true;
            }
        }

        private bool ValidateNewIngredientAmount()
        {
            double ingredientAmount;
            bool newAmountParsed = Double.TryParse(newIngredientAmount.Text, out ingredientAmount);
            if (!newAmountParsed)
            {
                System.Windows.Forms.MessageBox.Show("Please input a valid numeric value for ingredient amount before adding new ingredient");
                return false;
            }
            else
            {
                return true;
            }
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
