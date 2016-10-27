﻿using System;
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
    public partial class EditRecipe : Form
    {
        private Recipe indivRecipe;
        public EditRecipe(int id)
        {
            InitializeComponent();

            //Grab the contents of this recipe from the API
            bool successfulPull = PullRecipeByID(id);
            if (!successfulPull)
            {
                Console.Error.Write(String.Format("Did not successfully pull recipe with id: %d", id));
            }

            InitializeFields();
        }

        public EditRecipe(String json)
        {
            InitializeComponent();
            indivRecipe = new _393_Food_Machine.Recipe(json);
            InitializeFields();
        }

        private void InitializeFields()
        {
            //Set title
            title.Text = indivRecipe.name;

            //Add the ingredients
            foreach (Tuple<Ingredient, double> ingredient in indivRecipe.ingredientList)
            {
                ingredientListBox.Items.Add(String.Format("{0}\t\t{1} {2}",
                    ingredient.Item1.name,
                    ingredient.Item2,
                    ingredient.Item1.unit));
            }
            //Add prep description
            prepTimeBox.Text = (String.Format("{0}", indivRecipe.prepTime));
            servingsBox.Text = (String.Format("{0}", indivRecipe.numServings));
            descriptionTextBox.Text = indivRecipe.description;
        }

        //Initialize the Recipe object of this UI page from the JSON returned from the API
        public bool PullRecipeByID(int id)
        {
            //Get the Recipe from the API - make an HTTP request for GetRecipe(ID)
            String jsonObj = "";
            indivRecipe = new _393_Food_Machine.Recipe(jsonObj);
            if (/* jsonObj received from HTTP request */ true)
            {
                return true;
            }
            else
            {
                //return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
