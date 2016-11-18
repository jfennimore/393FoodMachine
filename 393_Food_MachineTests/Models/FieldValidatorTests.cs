using Microsoft.VisualStudio.TestTools.UnitTesting;
using _393_Food_Machine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _393_Food_Machine.Models.Tests
{
    [TestClass()]
    public class FieldValidatorTests
    {
        [TestMethod()]
        public void getComboIndexAndNameTest()
        {
            String categoryName = "Entree";
            int index = Models.FieldValidator.getComboIndex(typeof(Recipe.RecipeCategory), categoryName);
            Assert.IsTrue(index != -1);
            Assert.AreEqual(categoryName, Models.FieldValidator.getComboName(typeof(Recipe.RecipeCategory), (Recipe.RecipeCategory)index));

            //There are two behaviors observed for enums in this system, since the Ingredient measurementUnits have int value associated with them.  Need to test both.
            String measureName = "lbs";
            int measureIndex = Models.FieldValidator.getComboIndex(typeof(Ingredient.measurementUnits), measureName);
            Assert.IsTrue(measureIndex != -1);
            Assert.AreEqual(measureName, Models.FieldValidator.getComboName(typeof(Ingredient.measurementUnits), (Ingredient.measurementUnits)measureIndex));
        }
    }
}