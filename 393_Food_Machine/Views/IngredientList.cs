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
    public partial class IngredientList : Form
    {
        private List<Tuple<String, int, String>> ingrList;

        public IngredientList()
        {
            InitializeComponent();
            PullItems();

            foreach (Tuple<String, int, String> ingredient in ingrList)
            {
                ingredientListBox.Items.Add(ingredient.Item1);
            }


        }

        private bool PullItems()
        {
            //Get the list of recipe names and ID's from the API
            ingrList = new List<Tuple<String, int, String>>();
            return true;
        }

        private void ingredientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ingredientListBox.SelectedIndex;
            int recipeId = ingrList.ElementAt(index).Item2;
            //Match the selected index to the index of the Recipe in the list and get the id for that recipe
            String jsonRecipe = ingrList.ElementAt(index).Item3;
            //(new IndivIngredientUI(jsonRecipe)).Show();
        }
    }
}
