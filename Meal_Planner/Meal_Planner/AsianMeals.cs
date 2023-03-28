using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class AsianMeals
    {
        public static List<Meal> GetAsianMealsList()
        { 
            List<Meal> result = new List<Meal>(); 
            result.Add(new Meal(1, "Ramen", new string[] {"pork","chicken","tofu","veggie", "egg"}, "Ramen noodles\nMushrooms\nGreen onions\nBok choy\nOptional Meat\nChicken/Veggie Broth\nMiso Paste\nEgg"));
            result.Add(new Meal(2, "Onigiri", new string[] { "spam", "tuna"}, "Rice\nFilling\nSeaweed\nSpicy Mayo"));
            result.Add(new Meal(3, "Sesame Garlic (protein)", new string[] {"chicken", "tofu" }, "Extra firm tofu or Meat\nChili Paste\nGarlic Paste\nGreen Onions\nRice"));
            result.Add(new Meal(4, "Hot Pot", new string[] { "pork", "chicken", "tofu", "veggie", "steak", "spam" }, "Optional Meat or Tofu\nRice\nNoodles\nSoup Base\nBaby Bok Choy\nLotus Root\nEnoki Mushrooms\nShiitake Mushrooms\nSoy Puffs\nPotato"));
            result.Add(new Meal(5, "Egg Drop Soup", new string[] { "egg" }, "Eggs\nChicken Broth\nGreen Onions\nOptional Corn"));
            result.Add(new Meal(6, "Korean Potato Soup", new string[] { "veggie" }, "Potato\nVeggie Broth\nMushrooms\nDoenjang\nGochugaru\nGochujang\nYukon gold potatoes\nBean sprouts\nOptional noodles"));
            result.Add(new Meal(7, "Hibachi", new string[] { "chicken", "steak", "tofu" }, "Meat or Tofu\nRice\nOnion\nZucchini\nMushroom "));
            return result;
        }
    }
}
// protiens involved (pork, chicken, tofu, veggie, egg, spam, tuna, steak)