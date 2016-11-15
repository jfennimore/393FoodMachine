using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace _393_Food_Machine.Views
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            (new RecipeList()).Show();
        }

        private void ingredientButton_Click(object sender, EventArgs e)
        {
            String uri = "http://food-machine-api.herokuapp.com/ingredients";
            WebRequest wr = WebRequest.Create(uri);
            StreamReader response = new StreamReader(wr.GetResponse().GetResponseStream());
            StringBuilder fullResponse = new StringBuilder();
            String responseLine = "";
            while(responseLine != null)
            {
                responseLine = response.ReadLine();
                fullResponse.Append(responseLine);
            } 
            System.Windows.Forms.MessageBox.Show(fullResponse.ToString());
        }
    }
}
