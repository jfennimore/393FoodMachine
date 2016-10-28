using Microsoft.VisualStudio.TestTools.UnitTesting;
using _393_Food_Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            Ingredient butter = new Ingredient("Butter", 400, Ingredient.measurementUnits.tbsp, Ingredient.IngredientCategory.Dairy);
            Ingredient flour = new Ingredient("Flour", 100, Ingredient.measurementUnits.cups, Ingredient.IngredientCategory.Grains_Pasta);
            Ingredient water = new Ingredient("Water", 0, Ingredient.measurementUnits.tbsp, Ingredient.IngredientCategory.Produce);
            ingredients.Add(new Tuple<Ingredient, double>(butter, 3.0));
            ingredients.Add(new Tuple<Ingredient, double>(flour, 2.5));
            ingredients.Add(new Tuple<Ingredient, double>(water, 1.0));
            sample = new _393_Food_Machine.Recipe("Pie Crust", "Add all ingredients and mix", Recipe.RecipeCategory.Dessert, 100, DateTime.Today, 12,
                ingredients);
        }
        
        //Run the basic 'get' operations on a sample recipe
        [TestMethod()]
        public void TestSampleRecipe()
        {
            Assert.AreEqual("Pie Crust", sample.name);
            Assert.AreEqual("Add all ingredients and mix", sample.description);
            Assert.AreEqual(Recipe.RecipeCategory.Dessert, sample.category);
            Assert.AreEqual(100, sample.prepTime);
            Assert.AreEqual(DateTime.Today, sample.dateAdded);
            Assert.AreEqual(12, sample.numServings);
        }

        [TestMethod()]
        public void TestAlterRecipeDesc()
        {
            sample.description = "Crumble butter with a fork";
            Assert.AreEqual("Crumble butter with a fork", sample.description);
            Assert.AreNotEqual("Add all ingredients and mix", sample.description);
        }

        [TestMethod()]
        public void TestAlterRecipePrepTime()
        {
            sample.prepTime = 50;
            Assert.AreEqual(50, sample.prepTime);
            Assert.AreNotEqual(100, sample.prepTime);
        }

        [TestMethod()]
        public void TestAlterRecipeCategory()
        {
            sample.category = Recipe.RecipeCategory.Breakfast;
            Assert.AreEqual(Recipe.RecipeCategory.Breakfast, sample.category);
            Assert.AreNotEqual(Recipe.RecipeCategory.Dessert, sample.category);
        }

        [TestMethod()]
        public void TestAlterRecipeDate()
        {
            sample.dateAdded = DateTime.Today.AddDays(1);
            Assert.AreEqual(DateTime.Today.AddDays(1), sample.dateAdded);
            Assert.AreNotEqual(DateTime.Today, sample.dateAdded);
        }

        [TestMethod()]
        public void TestAlterRecipeServings()
        {
            sample.numServings = 10;
            Assert.AreEqual(10, sample.numServings);
            Assert.AreNotEqual(12, sample.numServings);
        }

        [TestMethod()]
        //The Recipe should be the same before and after serialization
        public void TestJSONSerialization()
        {
            String jsonObj = sample.ToString(); //This IS the JSON Serialization
            Recipe deserialized = JsonConvert.DeserializeObject<Recipe>(jsonObj);
            Assert.IsTrue(sample.Equals(deserialized));
        }

        [TestMethod()]
        public void TestCalculateCalories()
        { 
            //Butter 400 * 3 + Flour 100 * 2.5 + Water 0 * 1 = 1450
            // 1450/numServings = 1450/12 = 120.83
            Assert.AreEqual(120, sample.caloriesPerServing);
            //CalculateCalories needs to recalculate whenever the number of servings changes.
            sample.numServings = 10;
            Assert.AreEqual(145, sample.caloriesPerServing);
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