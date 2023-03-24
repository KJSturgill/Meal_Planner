using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class RiceMeals
    {
        public static List<Meal> ListRiceMeals()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Chicken and Rice Bake", new string[] { "chicken" }, new string[] { "test, will add later" }));
            result.Add(new Meal(2, "Onigiri", new string[] { "egg", "spam" }, new string[] { "test, will add later" }));
            result.Add(new Meal(3, "Hibachi", new string[] { "veggie", "chicken", "steak","tofu" }, new string[] { "test, will add later" }));
            result.Add(new Meal(4, "Masubi", new string[] { "spam" }, new string[] { "test, will add later" }));
            result.Add(new Meal(5, "Rissoto", new string[] { "veggie" }, new string[] { "test, will add later" }));
            result.Add(new Meal(6, "Tex Mex", new string[] { "veggie", "chicken", "turkey", "steak" }, new string[] { "test, will add later" }));
            result.Add(new Meal(7, "Jumbalaya", new string[] { "veggie", "turkey", "shrimp", "chicken", "sausage" }, new string[] { "test, will add later" }));
            result.Add(new Meal(8, "Gumbo", new string[] { "veggie", "turkey", "shrimp", "chicken", "sausage" }, new string[] { "test, will add later" }));
            result.Add(new Meal(9, "Sweet Potato Tacos", new string[] { "veggie","chicken", "turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(10, "RoadKill (I did not give it this name)", new string[] {"beef", "turkey", "shrimp", "chicken", "sausage","steak","spam", "leftover" }, new string[] { "Lets be honest, I came up with this when I was 10, my friends all called it road kill because its a BBQ rice with essentially any meat you have, usually leftover meat in the freezer that id use before it got frostbitten, hence where my friends came up with the name" }));
            return result;
        }
    }
}
// Protiens involved (chicken, veggie, egg, spam, steak, shrimp, sausage, beef, turkey,  tofu,  Leftover Meat )
