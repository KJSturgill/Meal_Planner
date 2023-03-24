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
            result.Add(new Junk(1, "Ramen", "I'd recommend Shin Ramen (maybe mixed wiht mac n cheese)" ));
            result.Add(new Junk(2, "Kraft Mac and Cheese", "It doesnt have to be Kraft, whatever you have in the pantry works" ));
            result.Add(new Junk(3, "PizzaRolls/BagelBites", "If you have a bit of energy, cook the pizza rolls in the air fryer, toss in buffalo sauce, and dust with parmesean."));
            result.Add(new Junk(4, "Chicken Tenders", "We like Just Bare, and Tyson air fryer tenders"));
            result.Add(new Junk(5, "Microwave/Frozen Dinner", "No tips here, most suck but so does executive dysfunction. drown in hot sauce if it doesnt taste good"));
            result.Add(new Junk(6, "Order Out", "Why am I using this if I want to eat out, I have a list for that"));

            return result;
        }
    }
}
