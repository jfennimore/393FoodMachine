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
    public partial class IngredientCategorySelect : Form
    {
        public IngredientCategorySelect()
        {
            InitializeComponent();
        }

        private IngredientList ingrL;
        public IngredientCategorySelect(IngredientList ingrList)
        {
            InitializeComponent();
            this.ingrL = ingrList;
            categoryComboBox.Items.AddRange(Enum.GetNames(typeof(Ingredient.IngredientCategory)));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ingrL.setFilterText("Category: " + categoryComboBox.Text);
            ingrL.filterByCategory((Ingredient.IngredientCategory)Models.FieldValidator.getComboIndex(typeof(Ingredient.IngredientCategory), categoryComboBox.Text));
            this.Close();
        }
    }
}
