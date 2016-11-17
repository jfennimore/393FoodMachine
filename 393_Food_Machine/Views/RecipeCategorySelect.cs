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
    public partial class RecipeCategorySelect : Form
    {

        private RecipeList rl;
        public RecipeCategorySelect(RecipeList recipes)
        {
            InitializeComponent();
            this.rl = recipes;
            categoryComboBox.Items.AddRange(Enum.GetNames(typeof(Recipe.RecipeCategory)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rl.setFilterText("Category: " + categoryComboBox.Text);
            this.Close();
        }
    }
}
