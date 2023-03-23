using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class LowEffortMeals
    {
        public static List<Junk> ListLowEffortMeals()
        {
            List<Junk> result= new List<Junk>();
            result.Add(new Junk(1, "Ramen", new string[] { "Test" }));
            result.Add(new Junk(2, "Kraft Mac and Cheese", new string[] { "Test" }));
            result.Add(new Junk(3, "PizzaRolls/BagelBites", new string[] { "Test" }));
            result.Add(new Junk(4, "Chicken Tenders", new string[] { "Test" }));
            result.Add(new Junk(5, "Microwave/Frozen Dinner", new string[] { "Test" }));
            result.Add(new Junk(6, "Order Out", new string[] { "Test" }));

            return result;
        }
    }
}
