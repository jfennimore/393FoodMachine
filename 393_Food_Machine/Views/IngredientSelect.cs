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

namespace _393_Food_Machine.Views
{
    public partial class IngredientSelect : Form
    {
        public IngredientSelect()
        {
            InitializeComponent();
        }

        private RecipeList rl;
        private EditRecipe editR;
        private List<Ingredient> allIngrs;
        public IngredientSelect(RecipeList recipes)
        {
            InitializeComponent();
            this.rl = recipes;
            allIngrs = Models.APICalls.extractFromJson<List<Ingredient>>(Models.APICalls.getAllIngredients(), "ingredients");
            foreach (Ingredient ingr in allIngrs)
            {
                ingredientComboBox.Items.Add(ingr.name);
            }
            
        }

        public IngredientSelect(EditRecipe recipe)
        {
            InitializeComponent();
            this.editR = recipe;
            allIngrs = Models.APICalls.extractFromJson<List<Ingredient>>(Models.APICalls.getAllIngredients(), "ingredients");
            foreach (Ingredient ingr in allIngrs)
            {
                ingredientComboBox.Items.Add(ingr.name);
            }

        }

        private void okButton_Click_1(object sender, EventArgs e)
        {
            if(editR == null)
            {
                rl.setFilterText("Ingredient: " + ingredientComboBox.Text);
                rl.filterByIngredient(allIngrs[ingredientComboBox.SelectedIndex]);
                this.Close();
            }
            else
            {
                editR.setBrowsedIngr(allIngrs[ingredientComboBox.SelectedIndex]);
                this.Close();
            }
            
        }
    }
}
