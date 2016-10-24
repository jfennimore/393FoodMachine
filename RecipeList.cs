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
    public partial class RecipeList : Form
    {
        //Binds recipe names with their ID's
        private List<Tuple<String, int>> recipeList;

        public RecipeList()
        {
            InitializeComponent();
            foreach(Tuple<String,int> recipe in recipeList)
            {
                recipeListBox.Items.Add(new KeyValuePair<String, int>(recipe.Item1,recipe.Item2));
            }
            
        }

        public bool PullItems()
        {
            //Get the list of recipe names and ID's from the API
            return true;
        }
    }
}
