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
            PullItems();
            
            foreach (Tuple<String,int> recipe in recipeList)
            {
                recipeListBox.Items.Add(recipe.Item1);
                //ListViewItem newItem = new ListViewItem();
                //newItem.Text = recipe.Item1;
                //newItem.Tag = recipe.Item2;
                //recipeListBox.Items.Add(newItem);
            }
        }

        public bool PullItems()
        {
            //Get the list of recipe names and ID's from the API
            recipeList = new List<Tuple<String, int>>();
            recipeList.Add(new Tuple<String, int>("Cake", 3));
            return true;
        }

        //User selected an item in the list
        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Out.Write(recipeListBox.SelectedIndex);
            //Match the selected index to the index of the Recipe in the list and get the id for that recipe
            //Application.Run(new IndivRecipeUI());
        }
    }
}
