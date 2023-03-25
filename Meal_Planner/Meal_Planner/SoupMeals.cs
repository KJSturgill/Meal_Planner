using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class SoupMeals
    {
        public static List<Meal> ListSoupMeals()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Chicken Noodle Soup", new string[] { "chicken" },  "test, will add later" ));
            result.Add(new Meal(2, "Potato Soup", new string[] { "veggie","bacon","sausage" },"test, will add later" ));
            result.Add(new Meal(3, "Potato Leak Soup", new string[] { "veggie","chicken" }, "test, will add later"));
            result.Add(new Meal(4, "Cajun Potato Soup", new string[] { "bacon", "sausage" }, "test, will add later"));
            result.Add(new Meal(5, "Tomato Soup", new string[] { "veggie" }, "test, will add later"));
            result.Add(new Meal(6, "Pot Pie Soup", new string[] { "veggie","chicken" }, "test, will add later"));
            result.Add(new Meal(7, "Chicken Dumpling Soup", new string[] { "chicken" }, "test, will add later"));
            result.Add(new Meal(8, "Tortilla Soup", new string[] { "veggie", "chicken" }, "test, will add later"));
            result.Add(new Meal(9, "French Onion Soup", new string[] { "veggie" }, "test, will add later"));
            result.Add(new Meal(10, "Mushroom Soup", new string[] { "veggie" }, "test, will add later"));
            result.Add(new Meal(11, "Stew", new string[] { "veggie", "beef" }, "test, will add later"));
            result.Add(new Meal(12, "Egg Drop Soup", new string[] { "egg" }, "test, will add later"));
            result.Add(new Meal(13, "Korean Potato Soup", new string[] { "veggie" }, "test, will add later"));
            result.Add(new Meal(14, "Chili", new string[] { "veggie","beef","chicken","turkey" }, "test, will add later"));
            return result;
        }
    }
}
// Protiens involved (chicken, sausage, bacon, veggie, beef, turkey)