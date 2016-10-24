using Microsoft.VisualStudio.TestTools.UnitTesting;
using _393_Food_Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _393_Food_Machine.Tests
{
    [TestClass()]
    public class RecipeTests
    {
        Recipe sample;

        [TestInitialize]
        public void Initialize()
        {
            List<Tuple<Ingredient, double>> ingredients = new List<Tuple<Ingredient, double>>();
            Ingredient butter = new Ingredient("Butter", 400, 1, "tbsp", Ingredient.IngredientCategory.Dairy);
            Ingredient flour = new Ingredient("Flour", 100, 1, "cup", Ingredient.IngredientCategory.Grains_Pasta);
            Ingredient water = new Ingredient("Water", 0, 1, "tbsp", Ingredient.IngredientCategory.Produce);
            ingredients.Add(new Tuple<Ingredient, double>(butter, 3.0));
            ingredients.Add(new Tuple<Ingredient, double>(flour, 2.5));
            ingredients.Add(new Tuple<Ingredient, double>(water, 1.0));
            sample = new _393_Food_Machine.Recipe("Pie Crust", "Add all ingredients and mix", Recipe.RecipeCategory.Dessert, 100, DateTime.Today, 12,
                ingredients);
        }
        
        //Run the basic operations on a sample recipe
        [TestMethod()]
        public void TestSample()
        {
            Assert.AreEqual("Pie Crust", sample.GetName());
            Assert.AreEqual("Add all ingredients and mix", sample.GetDescription());
            Assert.AreEqual(Recipe.RecipeCategory.Dessert, sample.GetCategory());
            Assert.AreEqual(100, sample.GetPrepTime());
            Assert.AreEqual(DateTime.Today, sample.GetDateAdded());
            Assert.AreEqual(12, sample.GetNumServings());
        }

        [TestMethod()]
        public void TestAlterRecipeDesc()
        {
            sample.SetDescription("Crumble butter with a fork");
            Assert.AreEqual("Crumble butter with a fork", sample.GetDescription());
            Assert.AreNotEqual("Add all ingredients and mix", sample.GetDescription());
        }

        [TestMethod()]
        public void TestAlterRecipePrepTime()
        {
            sample.SetPrepTime(50);
            Assert.AreEqual(50, sample.GetPrepTime());
            Assert.AreNotEqual(100, sample.GetPrepTime());
        }

        [TestMethod()]
        public void TestAlterRecipeCategory()
        {
            sample.SetCategory(Recipe.RecipeCategory.Breakfast);
            Assert.AreEqual(Recipe.RecipeCategory.Breakfast, sample.GetCategory());
            Assert.AreNotEqual(Recipe.RecipeCategory.Dessert, sample.GetCategory());
        }

        [TestMethod()]
        public void TestAlterRecipeDate()
        {
            sample.SetDateAdded(DateTime.Today.AddDays(1));
            Assert.AreEqual(DateTime.Today.AddDays(1), sample.GetDateAdded());
            Assert.AreNotEqual(DateTime.Today, sample.GetDateAdded());
        }

        [TestMethod()]
        public void TestAlterRecipeServings()
        {
            sample.SetNumServings(10);
            Assert.AreEqual(10, sample.GetNumServings());
            Assert.AreNotEqual(12, sample.GetNumServings());
        }


        /*
        [TestMethod()]
        public void RecipeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RecipeTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PushItemTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPrepTimeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetPrepTimeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAvgCostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetAmountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDescriptionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetDescriptionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetCategoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDateAddedTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetDateAddedTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetNumServingsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetNumServingsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCaloriesPerServingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetCaloriesPerServingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetIngredientListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetIngredientListTest()
        {
            Assert.Fail();
        } */
    }
}