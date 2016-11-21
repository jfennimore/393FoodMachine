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
    public partial class EditStore : Form
    {

        public Store indivStore;

        public EditStore()
        {
            InitializeComponent();
        }

        private void populateIngredientsBox()
        {
            ingredientListBox.Items.Clear();
            foreach (Tuple<Ingredient, double> ingredient in indivStore.ingredientCosts)
            {
                ingredientListBox.Items.Add(String.Format("{0}\t\t{1}",
                    ingredient.Item1.name,
                    ingredient.Item2));
            }
        }

        private void ingredientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ingredientListBox.SelectedIndex;
            //It's possible to select an 'empty' row, and so we need to prevent an OutOfBounds exception.
            if (index < indivStore.ingredientCosts.Count)
            {
                Tuple<Ingredient, double> selectedIngredient = indivStore.ingredientCosts.ElementAt(index);
                editIngredientName.Text = selectedIngredient.Item1.name;
                editIngredientPrice.Text = selectedIngredient.Item2.ToString();
            }
        }

        private void editIngredientConfirm_Click(object sender, EventArgs e)
        {
            bool editFieldsValid = validateEditFields();
            if (editFieldsValid)
            {
                if (ingredientListBox.SelectedIndex != -1)
                {
                    indivStore.ingredientCosts[ingredientListBox.SelectedIndex] =
                        new Tuple<Ingredient, double>(
                            indivStore.ingredientCosts[ingredientListBox.SelectedIndex].Item1,
                            Double.Parse(editIngredientPrice.Text)
                        );
                }
                populateIngredientsBox();
            }
        }

        private void newIngrButton_Click(object sender, EventArgs e)
        {
            bool newIngrFieldsValid = validateNewIngrFields();
            if (newIngrFieldsValid)
            {
                //TODO: Get ingredient ID from the name
                Ingredient newIngr = new Ingredient(Models.APICalls.getIngredientByName(newIngredientName.Text));
                indivStore.ingredientCosts.Add(
                    new Tuple<Ingredient, double>(
                        newIngr,
                        Double.Parse(editIngredientPrice.Text)
                    )
                );
                //Add ingredient to this Store
                populateIngredientsBox();
            }
        }

        private void editIngredientRemove_Click(object sender, EventArgs e)
        {

        }

        private bool validateEditFields()
        {
            //Ingredient Name
            if (!Models.FieldValidator.ValidateString(editIngredientName, "Edit Ingredient Name", new String[] { "(Existing Ingredient Name)" }))
            {
                //TODO: Check that the given ingredient name actually exists in the API
                return false;
            }
            //Ingredient Amount
            if (!Models.FieldValidator.ValidateDoubleNumeric(editIngredientPrice, "Edit Ingredient Amount"))
            {
                return false;
            }

            return true;
        }

        private bool validateNewIngrFields()
        {
            //Ingredient Name
            if (!Models.FieldValidator.ValidateString(newIngredientName, "Edit Ingredient Name", new String[] { "(Existing Ingredient Name)" }))
            {
                //TODO: Check that the given ingredient name actually exists in the API
                return false;
            }
            //Ingredient Amount
            if (!Models.FieldValidator.ValidateDoubleNumeric(newIngredientPrice, "Edit Ingredient Amount"))
            {
                return false;
            }

            return true;
        }
    }
}
