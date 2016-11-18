using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _393_Food_Machine.Views
{
    public partial class IngredientList : Form
    {
        private List<Ingredient> ingrList;

        public IngredientList()
        {
            InitializeComponent();
            PullItems();

            populateIngredientsBox();
            populateComboBoxes();
        }

        private void populateComboBoxes()
        {
            editCategoryBox.Items.AddRange(Enum.GetNames(typeof(Ingredient.IngredientCategory)));
            newCategoryBox.Items.AddRange(Enum.GetNames(typeof(Ingredient.IngredientCategory)));
            editIngredientUnit.Items.AddRange(Enum.GetNames(typeof(Ingredient.measurementUnits)));
            newIngredientUnit.Items.AddRange(Enum.GetNames(typeof(Ingredient.measurementUnits)));
        }

        private void populateIngredientsBox()
        {
            ingredientListBox.Items.Clear();
            foreach (Ingredient ingredient in ingrList)
            {
                ingredientListBox.Items.Add(ingredient.name);
            }
        }

        private bool PullItems()
        {
            LoadingScreen ls = new LoadingScreen();
            ls.Show();
            JObject outerLayer = JObject.Parse(Models.APICalls.getAllIngredients());
            ls.Close();
            ingrList = JsonConvert.DeserializeObject<List<Ingredient>>(outerLayer.GetValue("ingredients").ToString());
            return true;
        }

        private void ingredientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ingredientListBox.SelectedIndex;
            //Possible to select a row that is empty, so prevent out of bounds exceptions!
            if (index < ingrList.Count)
            {
                Ingredient selectedIngr = ingrList.ElementAt(index);
                editIngredientName.Text = selectedIngr.name;
                editIngredientCalories.Text = selectedIngr.calories.ToString();
                editIngredientUnit.Text = Models.FieldValidator.getComboName(typeof(Ingredient.measurementUnits),selectedIngr.unit);
                editCategoryBox.Text = Models.FieldValidator.getComboName(typeof(Ingredient.IngredientCategory), selectedIngr.category);
            }
        }

        private void editIngredientConfirm_Click(object sender, EventArgs e)
        {
            bool editFieldsValid = validateEditFields();
            if (editFieldsValid)
            {
                Ingredient editIngr = ingrList[ingredientListBox.SelectedIndex];
                editIngr.name = editIngredientName.Text;
                editIngr.calories = Int32.Parse(editIngredientCalories.Text);
                editIngr.unit = (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), editIngredientUnit.Text);
                editIngr.category = (Ingredient.IngredientCategory)Models.FieldValidator.getComboIndex(typeof(Ingredient.IngredientCategory), editCategoryBox.Text);
                editIngr.PushExistingItem();
                        
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
            //Ingredient Calories
            if (!Models.FieldValidator.ValidateIntNumeric(editIngredientCalories, "Edit Ingredient Calories"))
            {
                return false;
            }
            //Ingredient Unit
            if (!Models.FieldValidator.ValidateWithinRange(editIngredientUnit.SelectedIndex, typeof(Ingredient.measurementUnits), "Edit Ingredient Unit", editIngredientUnit.Text))
            {
                return false;
            }
            //Ingredient Category
            if (!Models.FieldValidator.ValidateWithinRange(editCategoryBox.SelectedIndex, typeof(Ingredient.IngredientCategory), "Edit Ingredient Category", editCategoryBox.Text))
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
                Ingredient newIngr = new Ingredient(newIngredientName.Text,
                            Int32.Parse(newIngredientCalories.Text),
                            (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), newIngredientUnit.Text),
                            (Ingredient.IngredientCategory)Models.FieldValidator.getComboIndex(typeof(Ingredient.IngredientCategory), newCategoryBox.Text));
                ingrList.Add(newIngr);
                newIngr.PushNewItem();
                populateIngredientsBox();
            }
        }

        private bool validateNewIngrFields()
        {
            //Ingredient Name
            if (!Models.FieldValidator.ValidateString(newIngredientName, "New Ingredient Name", new String[] { "(New Ingredient Name)" }))
            {
                //TODO: Check that the given ingredient name actually exists in the API
                return false;
            }
            //Ingredient Calories
            if (!Models.FieldValidator.ValidateIntNumeric(newIngredientCalories, "New Ingredient Calories"))
            {
                return false;
            }
            //Ingredient Unit
            if (!Models.FieldValidator.ValidateWithinRange(newIngredientUnit.SelectedIndex, typeof(Ingredient.measurementUnits), "New Ingredient Unit", newIngredientUnit.Text))
            {
                return false;
            }
            //Ingredient Category
            if (!Models.FieldValidator.ValidateWithinRange(newCategoryBox.SelectedIndex, typeof(Ingredient.IngredientCategory), "New Ingredient Category", newCategoryBox.Text))
            {
                return false;
            }

            return true;
        }

        private void editIngredientRemove_Click(object sender, EventArgs e)
        {
            if (ingredientListBox.SelectedIndex != -1 && ingredientListBox.SelectedIndex < ingrList.Count)
            {
                Ingredient current = ingrList.ElementAt(ingredientListBox.SelectedIndex);
                current.DeleteItem();
                ingrList.RemoveAt(ingredientListBox.SelectedIndex);
                editIngredientName.Text = "";
                editIngredientCalories.Text = "";
                editIngredientUnit.Text = "";
                editCategoryBox.Text = "";
                populateIngredientsBox();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TextBox getEditIngrName()
        {
            return editIngredientName;
        }
    }
}
