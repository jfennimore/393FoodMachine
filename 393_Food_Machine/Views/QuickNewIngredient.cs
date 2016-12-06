using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _393_Food_Machine.Views
{
    public partial class QuickNewIngredient : Form
    {
        public QuickNewIngredient(String nonExistentIngr)
        {
            InitializeComponent();
            populateComboBoxes();
            messageLabel.Text = String.Format("{0} does not exist in the current ingredient library.  Would you like to add it?", nonExistentIngr);
            newIngredientName.Text = nonExistentIngr;
        }

        private void populateComboBoxes()
        {
            newCategoryBox.Items.AddRange(Enum.GetNames(typeof(Ingredient.IngredientCategory)));
            newIngredientUnit.Items.AddRange(Enum.GetNames(typeof(Ingredient.measurementUnits)));
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
                if (!requestSuccessful)
                {
                    System.Windows.Forms.MessageBox.Show("There was a problem posting the new ingredient!");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
