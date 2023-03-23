using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class PastaMeals
    {
        public static List<Meal> ListPastaMeals()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Gochujang Pasta", new string[] { "chicken","veggie","turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(2, "Beat Mac and Cheese", new string[] { "veggie"}, new string[] { "test, will add later" }));
            result.Add(new Meal(3, "Lemon Pepper Pasta", new string[] { "veggie", "chicken","shrimp" }, new string[] { "test, will add later" }));
            result.Add(new Meal(4, "Cream Cheese Pepper Pasta", new string[] { "veggie", "sausage","chicken", "turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(5, "Buffalo Chicken Pasta", new string[] { "chicken" }, new string[] { "test, will add later" }));
            result.Add(new Meal(6, "Baked Ziti", new string[] { "veggie", "chicken","turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(7, "Sun Dried Tomato Pasta", new string[] { "chicken","veggie" }, new string[] { "test, will add later" }));
            result.Add(new Meal(8, "Lasagna", new string[] { "veggie", "beef","turkey","sausage" }, new string[] { "test, will add later" }));
            result.Add(new Meal(9, "French Onion Pasta", new string[] { "veggie", "turkey" }, new string[] { "test, will add later" }));
            result.Add(new Meal(10, "Jumbalaya", new string[] { "veggie","turkey","shrimp","chicken","sausage" }, new string[] { "test, will add later" }));
            result.Add(new Meal(11, "Stuffed Shells", new string[] { "veggie", "beef","chicken","sausage" }, new string[] { "test, will add later" }));
            return result;
        }
    }
}
// Protiens involved (chicken, veggie, turkey, sausage, beef, shrimp