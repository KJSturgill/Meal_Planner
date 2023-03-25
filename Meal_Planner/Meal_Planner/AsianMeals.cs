using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class AsianMeals
    {
        public static List<Meal> ListAsianMeals()
        { 
            List<Meal> result = new List<Meal>(); 
            result.Add(new Meal(1, "Ramen", new string[] {"pork","chicken","tofu","veggie", "egg"}, "test, will add later"));
            result.Add(new Meal(2, "Onigiri", new string[] { "spam", "tuna"}, "test, will add later"));
            result.Add(new Meal(3, "Sesame Garlic (protien)", new string[] {"chicken", "tofu" }, "test, will add later"));
            result.Add(new Meal(4, "Hot Pot", new string[] { "pork", "chicken", "tofu", "veggie", "steak", "spam" }, "test, will add later"));
            result.Add(new Meal(5, "Egg Drop Soup", new string[] { "egg" }, "test, will add later"));
            result.Add(new Meal(6, "Keroan Potato Soup", new string[] { "veggie" }, "test, will add later"));
            return result;
        }
    }
}
// protiens involved (pork, chicken, tofu, veggie, egg, spam, tuna, steak)