using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class RiceMeals
    {
        public static List<Meal> GetRiceMealsList()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Chicken and Rice Bake", new string[] { "chicken" }, "Green peppers\nOnion\nLong grain rice\nChicken rice\nParmesan\nFranks Red Hot"));
            result.Add(new Meal(2, "Onigiri", new string[] { "tuna", "spam" }, "Rice\nFilling\nSeaweed\nSpicy Mayo"));
            result.Add(new Meal(3, "Hibachi", new string[] { "veggie", "chicken", "steak","tofu" }, "Meat or Tofu\nRice\nOnion\nZucchini\nMushroom"));
            result.Add(new Meal(4, "Masubi", new string[] { "spam" }, "Rice\nSpam\nOyster sauce\nSeaweed"));
            result.Add(new Meal(5, "Risotto", new string[] { "veggie" }, "Chicken broth\nMushrooms\nArborio rice\nWhite wine\nParmesan"));
            result.Add(new Meal(6, "Tex Mex", new string[] { "veggie", "chicken", "turkey", "steak" }, "Mexican rice\nOptional:Meat\nPeppers\nOnion\nMexican Cheese\nSalsa\nCorn\nBlack beans"));
            result.Add(new Meal(7, "Jambalaya", new string[] { "veggie", "turkey", "shrimp", "chicken", "sausage" }, "Peppers\nOnions\nCelery\nOptional:Meat\nPasta or Rice\nChicken broth\nTomato sauce\nCrushed tomatoes"));
            result.Add(new Meal(8, "Gumbo", new string[] { "veggie", "turkey", "shrimp", "chicken", "sausage" }, "Peppers\nOnions\nCelery\nChicken broth\nOptional: Meat\nChicken bouillon\nRice\nLarge can crushed tomatoes\nHot sauce\nGreen onion"));
            result.Add(new Meal(9, "Sweet Potato Tacos", new string[] { "veggie","chicken", "turkey" }, "Mexican rice\nSweet potatoes\nOnion\nPeppers\nBlack beans\nCorn\nMexican cheese mix\nSeasoning powder\nTortilla"));
            result.Add(new Meal(10, "RoadKill (I did not give it this name)", new string[] {"beef", "turkey", "shrimp", "chicken", "sausage","steak","spam", "leftover" }, "Lets be honest, I came up with this when\nI was 10, my friends all called it road\nkill because its a BBQ rice with essentially\nany meat you have, usually leftover meat\nin the freezer that id use before it got\nfrostbitten, hence where my friends\ncame up with the name" ));
            return result;
        }
    }
}
// Protiens involved (chicken, veggie, egg, spam, steak, shrimp, sausage, beef, turkey,  tofu,  Leftover Meat )
