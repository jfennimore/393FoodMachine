# 393FoodMachine

FoodMachine Desktop Client
Joe Fennimore
jrf118@case.edu

See the Food Machine API repo here: https://github.com/ParceledTongue/food-machine-api
That work was done by Zach Palumbo!

## Desktop Client
This repo stores the C# code for the Food Machine Desktop Client- The UI Forms and the classes which abstract the data they represent.  
The executable lives in 393_Food_Machine/bin/Debug

## Recipes
From the Home Menu, if you open **Recipes**, you'll get a list of the full library of Recipes.  These can be filtered and sorted using the two drop down bars above the list.
### Filtering
Filtering will always remove recipes from the list that do not match the given criteria.  Some filters, such as Calories, will ask for a cutoff value by which to filter, and the filtration will then only occur when you click OK.  **A basic Search is included inside of the Filters** because in a way, searching *is* filtering.
### Sorting
Sorting acts on the current (filtered) list of ingredients.  As long as something is present in the Sort box, the list will be sorted in that order, even if your last action was to apply a new/different filter.
### Editing/Creating Recipes
Both the **New Recipe** button in the Recipe List page and the **Edit Recipe** button within an Individual Recipe page will direct you to the same type of page.  From there, you can change all fields associated with the Recipe, and alter the ingredients which compose that recipe.  **No fields may be left blank** and the Client should warn you specifically what fields have been neglected if you attempt to confirm a recipe that is incomplete.
### Adding New Ingredients
Within a Recipe, New Ingredients may be added by hitting the **Browse** button and selecting an Ingredient from the existing library, or just typing in the name of the ingredient, the amount required, and the unit.  *If that ingredient does not yet exist* a **QuickNewIngredient** window will open, indicating that the ingredient does not exist, and will provide you a means to quickly add it.  Once you click OK, and the new ingredient is created, you will need to hit **Add New** again to actually add the ingredient.

If you add a "New Ingredient" that was already in the list of Ingredients for that Recipe, it will add it to the existing listing of the Ingredient rather than add a redundant listing.  It will convert the total into the unit that the ingredient was initially added as.  This is not the only means to alter ingredients, though.  Clicking on an ingredient in the list box will populate the **Edit Ingredient** fields directly beneath the listbox, and amount and unit can both be altered there, as well as outright removed.

### Import and Export
Recipes can be directly Imported and Exported into Food Machine.  The **Import** button is in the Recipe List page, and will prompt you to locate the JSON file in your File Explorer.  The **Export** button lives inside of the Individual Recipe page.  *If you attempt to import an invalid JSON file for a Recipe, the Client will warn you that it could not parse the file into a Recipe.*

## Ingredients
Going to Ingredients from the Home Page opens a master list of Ingredients very similar to the Recipe List page, except that the generation and editing of Ingredients can be done from the same view.

## Stores
As of 12/9, we did not finish implementing the Stores feature, and so all estimations of Cost for Recipes is currently non-functional.  The estimated cost of every Recipe is $0. The *idea* for Stores, was that by storing the cost of certain ingredients in various stores, you could generate dynamically, just from the ingredients listed in a recipe, the average cost per serving of the recipe.  These statistics in turn could be useful for the frugal home cook!

## Grocery Lists
Similar to Stores, we did not complete Grocery Lists, but this is really for the better- a Grocery List feature isn't practical as a part of a Desktop Client.  It would be great for a Mobile App which utilizes the API, however.  Then, interface with the Recipes would allow a user to create a Grocery List based on the ingredients in a recipe they are observing, and use cost data from the stores to estimate the likely cost of a grocery list at a particular store.

Please email me with any questions or concerns!
jrf118@case.edu
