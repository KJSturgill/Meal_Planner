using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    class SoupMeals
    {
        public static List<Meal> GetSoupMealsList()
        {
            List<Meal> result = new List<Meal>();
            result.Add(new Meal(1, "Chicken Noodle Soup", new string[] { "chicken" }, "Noodles\nChicken\nCelery\nCarrots\nOnion\nChicken Broth"));
            result.Add(new Meal(2, "Potato Soup", new string[] { "veggie","bacon","sausage" }, "Potatoes\nMashed Potato Mix\nOnion\nCelery\nGreen Onion\nBacon(optional)\nVeggie Stock\nVeggie Bouillon\nCheddar Cheese Shredded\nHeavy Cream"));
            result.Add(new Meal(3, "Potato Leak Soup", new string[] { "veggie","chicken" }, "Potatoes\nOnion\nLeeks\nVeggie Broth\nZucchini\nOptional Rotisserie Chicken"));
            result.Add(new Meal(4, "Cajun Potato Soup", new string[] { "bacon", "sausage" }, "Potatoes\nOnion\nGreen Onion\nBacon\nSausage\nChicken Broth\nHeavy Cream\nWhole Milk"));
            result.Add(new Meal(5, "Tomato Soup", new string[] { "veggie" }, "Onion\nCarrots\nRoasted red peppers\nSun dried tomatoes\nTomato paste\nCan of diced fire roasted tomatoes\nVeggie broth\nHeavy cream\nGrated parmesan"));
            result.Add(new Meal(6, "Pot Pie Soup", new string[] { "veggie","chicken" }, "Chicken\nCelery\nCarrots\nOnion\nChicken broth\nPotatoes\nGreen Peas\nCorn\nHeavy Cream"));
            result.Add(new Meal(7, "Chicken Dumpling Soup", new string[] { "chicken" }, "Onion\nChicken\nChicken broth\nCream of mushroom\nCarrots\nCelery\nBiscuits"));
            result.Add(new Meal(8, "Tortilla Soup", new string[] { "veggie", "chicken" }, "Chicken\nChicken stock\nRed enchilada sauce\nBlack beans\nCan of fire roasted diced tomatoes\nCorn\nDiced green chiles\nOnion\nTortilla strips"));
            result.Add(new Meal(9, "French Onion Soup", new string[] { "veggie" }, "Onions\nBeef broth\nBread of choice\nGruyere"));
            result.Add(new Meal(10, "Mushroom Soup", new string[] { "veggie" }, "Onion\nMushrooms\nCarrots\nVeggie broth\nCoconut milk\nParmesan"));
            result.Add(new Meal(11, "Stew", new string[] { "veggie", "beef" }, "Beef\nPotatoes\nOnion\nPeas\nCorn\nCarrots\nBeef Broth\nTomato soup"));
            result.Add(new Meal(12, "Egg Drop Soup", new string[] { "egg" }, "Eggs\nChicken Broth\nGreen Onions\nOptional Corn"));
            result.Add(new Meal(13, "Korean Potato Soup", new string[] { "veggie" }, "Potato\nVeggie Broth\nMushrooms\nDoenjang\nGochugaru\nGochujang\nYukon gold potatoes\nBean sprouts\nOptional noodles"));
            result.Add(new Meal(14, "Chili", new string[] { "veggie","beef","chicken","turkey" }, "Meat\nBeans\nCorn\nSpice packet\nPeppers\nOnion\nLarge can crushed tomatoes\nOptional tomato sauce"));
            return result;
        }
    }
}
// Protiens involved (chicken, sausage, bacon, veggie, beef, turkey)