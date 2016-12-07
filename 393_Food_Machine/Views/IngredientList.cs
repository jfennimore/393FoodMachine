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
            filterValue.Visible = false;
            filterOK.Visible = false;
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
            ingrList = Models.APICalls.extractFromJson<List<Ingredient>>(Models.APICalls.getAllIngredients(), "ingredients");
            ls.Close();
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
                bool requestSuccessful = newIngr.PushNewItem();
                if(requestSuccessful)
                {
                    //Adding to the list has to happen AFTER PushNewItem() because it actually changes the state of the Ingredient- adds the URI
                    ingrList.Add(newIngr);
                    populateIngredientsBox();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("There was a problem posting the new ingredient!");
                }
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
                bool requestSuccessful = current.DeleteItem();
                if (requestSuccessful)
                {
                    ingrList.RemoveAt(ingredientListBox.SelectedIndex);
                    editIngredientName.Text = "";
                    editIngredientCalories.Text = "";
                    editIngredientUnit.Text = "";
                    editCategoryBox.Text = "";
                    populateIngredientsBox();
                }
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

        private void applySort()
        {
            switch (ingredientSort.Text)
            {
                case "Alphabetical":
                    ingrList.Sort(delegate (Ingredient i1, Ingredient i2) { return i1.name.CompareTo(i2.name); });
                    break;
                case "Category":
                    ingrList.Sort(delegate (Ingredient i1, Ingredient i2) { return i1.category.CompareTo(i2.category); });
                    break;
                case "Calories (Low)":
                    ingrList.Sort(delegate (Ingredient i1, Ingredient i2) { return i1.calories.CompareTo(i2.calories); });
                    break;
                case "Calories (High)":
                    ingrList.Sort(delegate (Ingredient i1, Ingredient i2) { return i2.calories.CompareTo(i1.calories); });
                    break;
            }
            populateIngredientsBox();
        }

        public void setFilterText(String filter)
        {
            ingredientFilter.Text = filter;
        }

        private void ingredientFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ingredientFilter.Text)
            {
                case "Category":
                    IngredientCategorySelect ics = new IngredientCategorySelect(this);
                    ics.Show();
                    //Filter out by category- triggered by the OK from the RCS
                    filterValue.Visible = false;
                    filterOK.Visible = false;
                    break;
                case "Calories":
                    filterOK.Visible = true;
                    filterValue.Visible = true;
                    filterValue.Text = "(Cutoff)";
                    break;
                case "Search":
                    filterOK.Visible = true;
                    filterValue.Visible = true;
                    filterValue.Text = "(Name)";
                    break;
                //Reset the filters
                case "No Filter":
                    filterValue.Visible = false;
                    filterOK.Visible = false;
                    PullItems();
                    applySort();
                    break;
            }
        }

        public void filterByCategory(Ingredient.IngredientCategory category)
        {
            PullItems();
            List<Ingredient> newIngrList = new List<Ingredient>();
            foreach (Ingredient ingr in ingrList)
            {
                if (ingr.category.Equals(category))
                {
                    newIngrList.Add(ingr);
                }
            }
            ingrList = newIngrList;
            populateIngredientsBox();
        }

        private void ingredientSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            applySort();
        }

        private void filterOK_Click(object sender, EventArgs e)
        {
            PullItems();
            switch (ingredientFilter.Text)
            {
                case "Calories":
                    filterByCaloriesMax();
                    break;
                case "Search":
                    filterBySearch();
                    break;
            }
            applySort();
        }

        private void filterByCaloriesMax()
        {
            int calThreshold = int.MaxValue;
            if (Models.FieldValidator.ValidateIntNumeric(filterValue, "Filter Calorie Cutoff"))
            {
                //Remove all recipes above cost threshhold
                calThreshold = Int32.Parse(filterValue.Text);
            }
            if (calThreshold != Int32.MaxValue)
            {
                List<Ingredient> newIngrList = new List<Ingredient>();
                foreach (Ingredient ingr in ingrList)
                {
                    if (ingr.calories <= calThreshold)
                    {
                        newIngrList.Add(ingr);
                    }
                }
                ingrList = newIngrList;
            }
        }

        private void filterBySearch()
        {
            String fragment = "";
            if (Models.FieldValidator.ValidateString(filterValue, "Searched Recipe Name", new String[] { "(Name)" }))
            {
                //Remove all recipes above cost threshhold
                fragment = filterValue.Text;
            }
            if (fragment != "")
            {
                List<Ingredient> newIngrList = new List<Ingredient>();
                foreach (Ingredient ingr in ingrList)
                {
                    if (ingr.name.IndexOf(fragment) != -1)
                    {
                        newIngrList.Add(ingr);
                    }
                }
                ingrList = newIngrList;
            }
        }
    }
}
