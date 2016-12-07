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
    public partial class DishTypeSelect : Form
    {

        private RecipeList rl;
        public DishTypeSelect(RecipeList recipes)
        {
            InitializeComponent();
            this.rl = recipes;
            dishTypeComboBox.Items.AddRange(Enum.GetNames(typeof(Recipe.DishType)));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            rl.setFilterText("Dish Type: " + dishTypeComboBox.Text);
            rl.filterByDishType((Recipe.DishType)Models.FieldValidator.getComboIndex(typeof(Recipe.DishType), dishTypeComboBox.Text));
            this.Close();
        }
    }
}
