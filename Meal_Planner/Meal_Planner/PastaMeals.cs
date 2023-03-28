using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class PastaMeals
    {
        public static List<Meal> GetPastaMealsList()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Gochujang Pasta", new string[] { "chicken","veggie","turkey" }, "Rigatoni\nOnion\nTomato paste\nGochujang paste\nHeavy cream\nVodka\nParmesan\nOptional Meat"));
            result.Add(new Meal(2, "Beat Mac and Cheese", new string[] { "veggie"}, "Rigatoni\nBeats\nParmesan"));
            result.Add(new Meal(3, "Lemon Pepper Pasta", new string[] { "veggie", "chicken","shrimp" }, "Lemons\nPasta\nMeat\nParmesan"));
            result.Add(new Meal(4, "Cream Cheese Pepper Pasta", new string[] { "veggie", "sausage","chicken", "turkey" }, "12oz Pasta\n32oz Chicken broth\nCream cheese\n5 Bell peppers\n4 Onions\nParmesan\nOptional: Italian sausage"));
            result.Add(new Meal(5, "Buffalo Chicken Pasta", new string[] { "chicken" }, "Chicken\nOnion\nFranks\nHeavy Cream\nNoodles\nParmesan"));
            result.Add(new Meal(6, "Baked Ziti", new string[] { "veggie", "chicken","turkey" }, "Penne pasta\nPart-skim ricotta\nEgg\nParmesan\nMeat\nMozzarella\nPasta sauce"));
            result.Add(new Meal(7, "Sun Dried Tomato Pasta", new string[] { "chicken","veggie" }, "Pasta\nVeggie broth\n2oz Cream cheese\nSun dried tomatoes\nCherry tomatoes\nParmesan\nOptional: Grilled chicken"));
            result.Add(new Meal(8, "Lasagna", new string[] { "veggie", "beef","turkey","sausage" }, "Lasagna noodles\nMeat\nPasta sauce\nRicotta\nOptional peppers and onions"));
            result.Add(new Meal(9, "French Onion Pasta", new string[] { "veggie", "turkey" }, "Onions\nWhite wine\nRigatoni\nBeef broth\nParmesan Cheese\nHeavy cream"));
            result.Add(new Meal(10, "Jambalaya", new string[] { "veggie","turkey","shrimp","chicken","sausage" }, "Peppers\nOnions\nCelery\nOptional:Meat\nPasta or Rice\nChicken broth\nTomato sauce\nCrushed tomatoes"));
            result.Add(new Meal(11, "Stuffed Shells", new string[] { "veggie", "beef","chicken","sausage" }, "Mozzarella\nFeta cheese\nPart-skim ricotta\nArtichoke hearts\nSpinach\nPasta sauce\nCooked jumbo pasta shells"));
            return result;
        }
    }
}
// Protiens involved (chicken, veggie, turkey, sausage, beef, shrimp