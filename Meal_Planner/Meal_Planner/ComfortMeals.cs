using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class ComfortMeals
    {
        public static List<Meal> GetComfortMealsList()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Lunchmeat Sammies", new string[] { "ham", "turkey" }, "Dijon mustard\nDried minced onions\nMeat\nSwiss cheese\nHawaiian rolls"));
            result.Add(new Meal(2, "Pizza", new string[] { "veggie", "pepperoni" }, "Pizza shells\nPizza sauce\nPepperonis\nPineapple\nMozzarella"));
            result.Add(new Meal(3, "Shepards Pie", new string[] { "lamb", "beef", "turkey" }, "Ground Meat\nYukon Gold Potatoes\nFrozen carrots and peas\nOnion\nTomato paste\nBeef broth\nCorn\nHeavy cream\nCheese"));
            result.Add(new Meal(4, "Steak", new string[] { "steak" }, "Steak\nGood butter\nCheck good seasonings\nPotatoes\nVeggie option"));
            result.Add(new Meal(5, "Ratatouille", new string[] { "veggie" }, "Red tomatoes\nEggplant\nPeppers\nZucchini\nYellow squash\nOnion"));
            result.Add(new Meal(6, "RedHot Crusted Chicken", new string[] { "chicken" }, "Meat\nHot sauce\nParmesan\nChicken broth\nLemon\nVeggie option"));
            result.Add(new Meal(7, "Lemon Pepper (protien)", new string[] { "chicken", "veggie" }, "Lemons\nChicken\nPotatoes\nOnion\nVeggie option"));
            result.Add(new Meal(8, "Meatloaf", new string[] { "beef", "turkey" }, "Ground Meat\nOnion\nEggs\nKetchup\nTomato paste\nPanko\nMilk\nBrown sugar\nWhite vinegar"));
            result.Add(new Meal(9, "Mashed Potato Bowl", new string[] { "veggie", "chicken" }, "Mashed Potatoes\nCorn\nChicken\nGravy\nCheddar cheese"));
            result.Add(new Meal(10, "Parmesan Crusted Chicken", new string[] { "chicken" }, "Veggie option\nMeat\nParmesan\nPanko\nEgg"));
            result.Add(new Meal(11, "Sesame Garlic (protien)", new string[] { "spam", "chicken","tofu" }, "Extra firm tofu or Meat\nChili Paste\nGarlic Paste\nGreen Onions\nRice"));
            result.Add(new Meal(12, "Chicken Salad", new string[] {"chicken" }, "Chicken\nLite Mayo\nWhite Grapes\nCelery\nCroissant"));
            result.Add(new Meal(13, "Chicken and Rice Bake", new string[] { "chicken" }, "Green peppers\nOnion\nLong grain rice\nChicken rice\nParmesan\nFranks Red Hot"));
            result.Add(new Meal(14, "Sweet Potato Tacos", new string[] { "chicken", "veggie", "turkey" }, "Mexican rice\nSweet potatoes\nOnion\nPeppers\nBlack beans\nCorn\nMexican cheese mix\nSeasoning powder\nTortilla"));
            return result;
        }
    }
}
// protiens involved (veggie, ham, turkey, pepperoni, lamb, beef, steak, chicken, tofu, spam