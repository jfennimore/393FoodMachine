# 393FoodMachine

FoodMachine Desktop Client
(Joe Fennimore)

This repo stores the C# code for the Desktop Client- The UI Forms and the classes which abstract the data they represent.  
The executable lives in 393_Food_Machine/bin/Debug

10/28/2016
At the moment, only the Recipes are traversable from the Home Screen.
Selecting a recipe opens up the Individual Recipe view.
Editing a recipe- you can currently edit any part of the recipe except for the Ingredients, hit confirm, and see those changes reflected in the Individual Recipe. We are not yet communicating with the actual database, which is API-side, and so 'edits' to the recipes are not permanent in this current code.
