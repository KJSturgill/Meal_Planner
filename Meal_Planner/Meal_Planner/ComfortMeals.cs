using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class ComfortMeals
    {
        public static List<Meal> ListComfortMeals()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Lunchmeat Sammies", new string[] { "ham", "turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(2, "Pizza", new string[] { "veggie", "pepperoni" }, new string[] { "test, will add later" }));
            result.Add(new Meal(3, "Shepards Pie", new string[] { "lamb", "beef", "turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(4, "Steak", new string[] { "steak" }, new string[] { "test, will add later" }));
            result.Add(new Meal(5, "Ratatouille", new string[] { "veggie" }, new string[] { "test, will add later" }));
            result.Add(new Meal(6, "RedHot Crusted Chicken", new string[] { "chicken" }, new string[] { "test, will add later" }));
            result.Add(new Meal(7, "Lemon Pepper (protien)", new string[] { "chicken", "veggie" }, new string[] { "test, will add later" }));
            result.Add(new Meal(8, "Meatloaf", new string[] { "beef", "turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(9, "Mashed Potato Bowl", new string[] { "veggie", "chicken" }, new string[] { "test, will add later" }));
            result.Add(new Meal(10, "Parmesan Crusted Chicken", new string[] { "chicken" }, new string[] { "test, will add later" }));
            result.Add(new Meal(11, "Sesame Garlic (protien)", new string[] { "spam", "chicken","tofu" }, new string[] { "test, will add later" }));
            result.Add(new Meal(12, "Chicken Salad", new string[] {"chicken" }, new string[] { "test, will add later" }));
            result.Add(new Meal(13, "Chicken and Rice Bake", new string[] { "chicken" }, new string[] { "test, will add later" }));
            result.Add(new Meal(14, "Sweet Potato Tacos", new string[] { "chicken", "veggie", "turkey" }, new string[] { "test, will add later" }));
            return result;
        }
    }
}
// protiens involved (veggie, ham, turkey, pepperoni, lamb, beef, steak, chicken, tofu, spam