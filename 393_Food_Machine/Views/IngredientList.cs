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
        private List<Tuple<String, int, String>> ingrList;

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
            foreach (Tuple<String, int, String> ingredient in ingrList)
            {
                ingredientListBox.Items.Add(ingredient.Item1);
            }
        }

        private bool PullItems()
        {
            //Get the list of recipe names and ID's from the API
            JObject outerLayer = JObject.Parse(Models.APICalls.getAllIngredients());
            List<Ingredient> apiIngredientList = JsonConvert.DeserializeObject<List<Ingredient>>(outerLayer.GetValue("ingredients").ToString());
            ingrList = new List<Tuple<String, int, String>>();
            foreach (Ingredient ingr in apiIngredientList)
            {
                ingrList.Add(new Tuple<string, int, string>(ingr.name, ingr.id, ingr.ToString()));
            }
            ingrList.Add(new Tuple<string, int, string>("Butter", 3, jsonButter()));
            ingrList.Add(new Tuple<string, int, string>("Flour", 4, jsonFlour()));
            List<Ingredient> jsonIngredients = new List<Ingredient>();
            jsonIngredients.Add(new Ingredient(jsonButter()));
            jsonIngredients.Add(new Ingredient(jsonFlour()));
            String listOfIngr = JsonConvert.SerializeObject(jsonIngredients);
            Console.Out.Write(listOfIngr);
            return true;
        }

        private void ingredientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ingredientListBox.SelectedIndex;
            //Possible to select a row that is empty, so prevent out of bounds exceptions!
            if (index < ingrList.Count)
            {
                Ingredient selectedIngr = new Ingredient(ingrList.ElementAt(index).Item3);
                editIngredientName.Text = selectedIngr.name;
                editIngredientCalories.Text = selectedIngr.calories.ToString();
                editIngredientUnit.Text = Enum.GetName(typeof(Ingredient.measurementUnits), selectedIngr.unit);
                editCategoryBox.Text = Enum.GetName(typeof(Ingredient.IngredientCategory), selectedIngr.category);
            }
        }

        private void editIngredientConfirm_Click(object sender, EventArgs e)
        {
            bool editFieldsValid = validateEditFields();
            if (editFieldsValid)
            {
                Ingredient newIngr = new Ingredient(editIngredientName.Text,
                            Int32.Parse(editIngredientCalories.Text),
                            (Ingredient.measurementUnits)Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), editIngredientUnit.Text),
                            (Ingredient.IngredientCategory)Models.FieldValidator.getComboIndex(typeof(Ingredient.IngredientCategory), editCategoryBox.Text));
                ingrList[ingredientListBox.SelectedIndex] = new Tuple<string, int, string>(newIngr.name, newIngr.id, newIngr.ToString());
                newIngr.PushExistingItem();
                        
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
                ingrList.Add(new Tuple<string, int, string>(newIngr.name, newIngr.id, newIngr.ToString()));
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

        private String jsonButter()
        {
            Ingredient butter = new Ingredient("Butter", 100, Ingredient.measurementUnits.tbsp, Ingredient.IngredientCategory.Dairy);
            return butter.ToString();
        }

        private String jsonFlour()
        {
            Ingredient flour = new Ingredient("Flour", 150, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Baking_Spices);
            return flour.ToString();
        }

        private void editIngredientRemove_Click(object sender, EventArgs e)
        {
            if (ingredientListBox.SelectedIndex != -1 && ingredientListBox.SelectedIndex < ingrList.Count)
            {
                Ingredient current = new Ingredient(ingrList.ElementAt(ingredientListBox.SelectedIndex).Item3);
                current.DeleteItem();
                ingrList.RemoveAt(ingredientListBox.SelectedIndex);
                editIngredientName.Text = "";
                editIngredientCalories.Text = "";
                editIngredientUnit.Text = "";
                editCategoryBox.Text = "";
                populateIngredientsBox();
            }
        }
    }
}
