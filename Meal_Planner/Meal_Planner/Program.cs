using System;
using MealPlanner;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Meal> soupMeals = SoupMeals.ListSoupMeals();
            List<Meal> pastaMeals = PastaMeals.ListPastaMeals();
            List<Meal> riceMeals = RiceMeals.ListRiceMeals();
            List<Meal> asianMeals = AsianMeals.ListAsianMeals();
            List<Meal> comfortMeals = ComfortMeals.ListComfortMeals();
            List<Junk> lowEffortMeals = LowEffortMeals.ListLowEffortMeals();

            Console.WriteLine("Let's figure out what to eat.");
            Console.WriteLine(" ");
            Console.WriteLine("Press 1 to look through meals.");
            Console.WriteLine("Press 0 to close the program.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != 0)
            {
                Thread.Sleep(500);
                Console.WriteLine("Press 1 for Soups.");
                Console.WriteLine("Press 2 for Pastas.");
                Console.WriteLine("Press 3 for Rice Meals.");
                Console.WriteLine("Press 4 for Asian Meals.");
                Console.WriteLine("Press 5 for Comfort Meals.");
                Console.WriteLine("Press 6 for Low Effort Options.");
                int userInput2 = Convert.ToInt32(Console.ReadLine());

                if (userInput2 == 1)
                {
                    Console.WriteLine(" ");
                    Thread.Sleep(500);
                    Console.WriteLine("What Protien would you like?");
                    Console.WriteLine("Choose only one, some dishes may\nuse multiple or can switch them out\nfor different options:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 for Vegitarian options.");
                    Console.WriteLine("Press 2 for Chicken options.");
                    Console.WriteLine("Press 3 for Turkey options.");
                    Console.WriteLine("Press 4 for Beef options.");
                    Console.WriteLine("Press 5 for Sausage options.");
                    int userInput3 = Convert.ToInt32(Console.ReadLine());

                    if (userInput3 == 1)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Veggie");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 2)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Chicken");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 3)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Turkey");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 4)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Beef");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 5)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Sausage");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Please choose a valid option!");
                        Thread.Sleep(500);
                        Console.WriteLine("Let's try again!");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                }

                else if (userInput2 == 2)
                {
                    Console.WriteLine(" ");
                    Thread.Sleep(500);
                    Console.WriteLine("What Protien would you like?");
                    Console.WriteLine("Choose only one, some dishes may\nuse multiple or can switch them out\nfor different options:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 for Vegitarian options.");
                    Console.WriteLine("Press 2 for Chicken options.");
                    Console.WriteLine("Press 3 for Turkey options.");
                    Console.WriteLine("Press 4 for Beef options.");
                    Console.WriteLine("Press 5 for Sausage options.");
                    Console.WriteLine("Press 6 for Shrimp options.");
                    int userInput3 = Convert.ToInt32(Console.ReadLine());

                    if (userInput3 == 1)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Veggie");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 2)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Chicken");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 3)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Turkey");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 4)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Beef");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 5)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Sausage");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 6)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Shrimp");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Please choose a valid option!");
                        Thread.Sleep(500);
                        Console.WriteLine("Let's try again!");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                }

                else if (userInput2 == 3)
                {
                    Console.WriteLine(" ");
                    Thread.Sleep(500);
                    Console.WriteLine("What Protien would you like?");
                    Console.WriteLine("Choose only one, some dishes may\nuse multiple or can switch them out\nfor different options:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 for Vegitarian options.");
                    Console.WriteLine("Press 2 for Chicken options.");
                    Console.WriteLine("Press 3 for Turkey options.");
                    Console.WriteLine("Press 4 for Beef options.");
                    Console.WriteLine("Press 5 for Sausage options.");
                    Console.WriteLine("Press 6 for Shrimp options.");
                    Console.WriteLine("Press 7 for Steak options.");
                    Console.WriteLine("Press 8 for Tofu options.");
                    Console.WriteLine("Press 9 for Spam options.");
                    Console.WriteLine("Press 10 for Eggs options.");
                    Console.WriteLine("Press 11 for Any leftover meat in your fridge/freezer.");
                    int userInput3 = Convert.ToInt32(Console.ReadLine());


                    if (userInput3 == 1)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Veggie");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 2)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Chicken");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 3)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Turkey");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 4)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Beef");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 5)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Sausage");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 6)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Shrimp");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 7)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Steak");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 8)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Tofu");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 9)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Spam");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 10)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Eggs");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 11)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("I Promise this one goes somewhere.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Please choose a valid option!");
                        Thread.Sleep(500);
                        Console.WriteLine("Let's try again!");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                }
                else if (userInput2 == 4)
                {
                    Console.WriteLine(" ");
                    Thread.Sleep(500);
                    Console.WriteLine("What Protien would you like?");
                    Console.WriteLine("Choose only one, some dishes may\nuse multiple or can switch them out\nfor different options:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 for Vegitarian options.");
                    Console.WriteLine("Press 2 for Chicken options.");
                    Console.WriteLine("Press 3 for Pork options.");
                    Console.WriteLine("Press 4 for Steak options.");
                    Console.WriteLine("Press 5 for Tuna options.");
                    Console.WriteLine("Press 6 for Spam options.");
                    Console.WriteLine("Press 7 for Eggs options.");
                    Console.WriteLine("Press 8 for Tofu options.");
                    int userInput3 = Convert.ToInt32(Console.ReadLine());

                    if (userInput3 == 1)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Vegitarian");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 2)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Chicken");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 3)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Pork");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 4)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Steak");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 5)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Tuna");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 6)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Spam");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 7)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Eggs");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 8)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Tofu");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Please choose a valid option!");
                        Thread.Sleep(500);
                        Console.WriteLine("Let's try again!");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                }

                else if (userInput2 == 5)
                {
                    Console.WriteLine(" ");
                    Thread.Sleep(500);
                    Console.WriteLine("What Protien would you like?");
                    Console.WriteLine("Choose only one, some dishes may\nuse multiple or can switch them out\nfor different options:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 for Vegitarian options.");
                    Console.WriteLine("Press 2 for Chicken options.");
                    Console.WriteLine("Press 3 for Turkey options.");
                    Console.WriteLine("Press 4 for Beef options.");
                    Console.WriteLine("Press 5 for Lamb options.");
                    Console.WriteLine("Press 6 for Spam options.");
                    Console.WriteLine("Press 7 for Steak options.");
                    Console.WriteLine("Press 8 for Tofu options.");
                    Console.WriteLine("Press 9 for Ham options.");
                    Console.WriteLine("Press 10 for Pepperoni options.");
                    int userInput3 = Convert.ToInt32(Console.ReadLine());

                    if (userInput3 == 1)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Vegitarian");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 2)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Chicken");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 3)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Turkey");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 4)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Beef");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 5)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Lamb");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 6)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Spam");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 7)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Steak");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 8)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Tofu");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 9)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Ham");
                        Console.ReadLine();
                    }
                    else if (userInput3 == 10)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("You chose Pepperoni");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Please choose a valid option!");
                        Thread.Sleep(500);
                        Console.WriteLine("Let's try again!");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                    }
                }

                else if (userInput2 == 6)
                {
                    foreach (Junk meal in lowEffortMeals)
                        Console.WriteLine($"Option {meal.Number}, {meal.Name}. Try: {meal.Suggestion}\n ");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Error: Please choose a valid option!");
                    Thread.Sleep(500);
                    Console.WriteLine("Let's try again!");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }

            }
        }
    }
}