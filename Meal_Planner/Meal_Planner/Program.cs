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
            Console.WriteLine(" ");

            while (userInput != 0)
            {
                //Console.WriteLine(" ");
                //Console.WriteLine("Press 1 to look through meals.");
                //Console.WriteLine("Press 0 to close the program.");
                //int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            { 
                Console.WriteLine(" ");
                Console.WriteLine("Press 1 for Soups.");
                Console.WriteLine("Press 2 for Pastas.");
                Console.WriteLine("Press 3 for Rice Meals.");
                Console.WriteLine("Press 4 for Asian Meals.");
                Console.WriteLine("Press 5 for Comfort Meals.");
                Console.WriteLine("Press 6 for Low Effort Options.");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");

                    if (userInput2 == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("What Protien would you like?");
                    Console.WriteLine("Choose only one, some dishes may\nuse multiple or can switch them out\nfor different options:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 for Vegitarian options.");
                    Console.WriteLine("Press 2 for Chicken options.");
                    Console.WriteLine("Press 3 for Turkey options.");
                    Console.WriteLine("Press 4 for Beef options.");
                    Console.WriteLine("Press 5 for Sausage options.");
                    Console.WriteLine("Press 6 for Egg options");
                    int userInput3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        if (userInput3 == 1)
                    {
                            Console.WriteLine("You chose Vegitarian");
                            Console.WriteLine(" ");
                            var linqSoupMeals = from Meal in soupMeals
                                                where Meal.Protien.Contains("veggie")
                                                select Meal;

                            foreach (var Meal in linqSoupMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var soupMealList = from Meal in linqSoupMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in soupMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);

                        }
                    else if (userInput3 == 2)
                    {
                            Console.WriteLine("You chose Chicken");
                            Console.WriteLine(" ");
                            var linqSoupMeals = from Meal in soupMeals
                                                where Meal.Protien.Contains("chicken")
                                                select Meal;

                            foreach (var Meal in linqSoupMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var soupMealList = from Meal in linqSoupMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in soupMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);

                        }
                    else if (userInput3 == 3)
                    {
                            Console.WriteLine("You chose Turkey");
                            Console.WriteLine(" ");
                            var linqSoupMeals = from Meal in soupMeals
                                                where Meal.Protien.Contains("turkey")
                                                select Meal;

                            foreach (var Meal in linqSoupMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var soupMealList = from Meal in linqSoupMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in soupMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);

                        }
                    else if (userInput3 == 4)
                    {
                        Console.WriteLine("You chose Beef");
                            Console.WriteLine(" ");
                            var linqSoupMeals = from Meal in soupMeals
                                                where Meal.Protien.Contains("beef")
                                                select Meal;

                            foreach (var Meal in linqSoupMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var soupMealList = from Meal in linqSoupMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in soupMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);

                        }
                    else if (userInput3 == 5)
                    {
                        Console.WriteLine("You chose Sausage");
                            Console.WriteLine(" ");
                            var linqSoupMeals = from Meal in soupMeals
                                                where Meal.Protien.Contains("sausage")
                                                select Meal;

                            foreach (var Meal in linqSoupMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var soupMealList = from Meal in linqSoupMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in soupMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);

                        }
                        else if (userInput3 == 6)
                        {
                            Console.WriteLine("You chose Eggs");
                            Console.WriteLine(" ");
                            var linqSoupMeals = from Meal in soupMeals
                                                 where Meal.Protien.Contains("egg")
                                                 select Meal;

                            foreach (var Meal in linqSoupMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var soupMealList = from Meal in linqSoupMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in soupMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


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
                    Console.WriteLine(" ");

                    if (userInput3 == 1)
                    {
                        Console.WriteLine("You chose Vegitarian");
                            Console.WriteLine(" ");
                            var linqPastaMeals = from Meal in pastaMeals
                                                 where Meal.Protien.Contains("veggie")
                                                 select Meal;

                            foreach (var Meal in linqPastaMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var pastaMealList = from Meal in linqPastaMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in pastaMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);

                        }
                        else if (userInput3 == 2)
                    {
                        Console.WriteLine("You chose Chicken");
                            Console.WriteLine(" ");
                            var linqPastaMeals = from Meal in pastaMeals
                                                 where Meal.Protien.Contains("chicken")
                                                 select Meal;

                            foreach (var Meal in linqPastaMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var pastaMealList = from Meal in linqPastaMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in pastaMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 3)
                    {
                        Console.WriteLine("You chose Turkey");
                            Console.WriteLine(" ");
                            var linqPastaMeals = from Meal in pastaMeals
                                                 where Meal.Protien.Contains("turkey")
                                                 select Meal;

                            foreach (var Meal in linqPastaMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var pastaMealList = from Meal in linqPastaMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in pastaMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 4)
                    {
                        Console.WriteLine("You chose Beef");
                            Console.WriteLine(" ");
                            var linqPastaMeals = from Meal in pastaMeals
                                                 where Meal.Protien.Contains("beef")
                                                 select Meal;

                            foreach (var Meal in linqPastaMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var pastaMealList = from Meal in linqPastaMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in pastaMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 5)
                    {
                        Console.WriteLine("You chose Sausage");
                            Console.WriteLine(" ");
                            var linqPastaMeals = from Meal in pastaMeals
                                                 where Meal.Protien.Contains("sausage")
                                                 select Meal;

                            foreach (var Meal in linqPastaMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var pastaMealList = from Meal in linqPastaMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in pastaMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 6)
                    {
                        Console.WriteLine("You chose Shrimp");
                            Console.WriteLine(" ");
                            var linqPastaMeals = from Meal in pastaMeals
                                                 where Meal.Protien.Contains("shrimp")
                                                 select Meal;

                            foreach (var Meal in linqPastaMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var pastaMealList = from Meal in linqPastaMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in pastaMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


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
                    Console.WriteLine("Press 10 for Tuna options.");
                    Console.WriteLine("Press 11 for Any leftover meat in your fridge/freezer.");
                    int userInput3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");

                    if (userInput3 == 1)
                    {
                        Console.WriteLine("You chose Vegitarian");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("veggie")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 2)
                    {
                        Console.WriteLine("You chose Chicken");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("chicken")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 3)
                    {
                        Console.WriteLine("You chose Turkey");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("turkey")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 4)
                    {
                        Console.WriteLine("You chose Beef");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("beef")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 5)
                    {
                        Console.WriteLine("You chose Sausage");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("sausage")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 6)
                    {
                        Console.WriteLine("You chose Shrimp");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("shrimp")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 7)
                    {
                        Console.WriteLine("You chose Steak");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("steak")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 8)
                    {
                        Console.WriteLine("You chose Tofu");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("tofu")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 9)
                    {
                        Console.WriteLine("You chose Spam");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("spam")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 10)
                    {
                        Console.WriteLine("You chose Tuna");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("tuna")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 11)
                    {
                        Console.WriteLine("I Promise this one goes somewhere.");
                            Console.WriteLine(" ");
                            var linqRiceMeals = from Meal in riceMeals
                                                where Meal.Protien.Contains("leftover")
                                                select Meal;

                            foreach (var Meal in linqRiceMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var riceMealList = from Meal in linqRiceMeals
                                               where Meal.Number == ingredientsList
                                               select Meal;

                            foreach (var Meal in riceMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


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
                    Console.WriteLine(" ");

                    if (userInput3 == 1)
                    {
                        Console.WriteLine("You chose Vegitarian");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("veggie")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
                        }
                    else if (userInput3 == 2)
                    {
                        Console.WriteLine("You chose Chicken");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("chicken")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
                        }
                    else if (userInput3 == 3)
                    {
                        Console.WriteLine("You chose Pork");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("pork")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
                        }
                    else if (userInput3 == 4)
                    {
                        Console.WriteLine("You chose Steak");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("steak")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
                        }
                    else if (userInput3 == 5)
                    {
                        Console.WriteLine("You chose Tuna");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("tuna")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
                        }
                    else if (userInput3 == 6)
                    {
                        Console.WriteLine("You chose Spam");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("spam")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
                        }
                    else if (userInput3 == 7)
                    {
                        Console.WriteLine("You chose Eggs");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("egg")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
                        }
                    else if (userInput3 == 8)
                    {
                        Console.WriteLine("You chose Tofu");
                            Console.WriteLine(" ");
                            var linqAsianMeals = from Meal in asianMeals
                                                 where Meal.Protien.Contains("tofu")
                                                 select Meal;

                            foreach (var Meal in linqAsianMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var asianMealList = from Meal in linqAsianMeals
                                                where Meal.Number == ingredientsList
                                                select Meal;

                            foreach (var Meal in asianMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);
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
                    Console.WriteLine(" ");

                    if (userInput3 == 1)
                    {
                        Console.WriteLine("You chose Vegitarian");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("veggie")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 2)
                    {
                        Console.WriteLine("You chose Chicken");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("chicken")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 3)
                    {
                        Console.WriteLine("You chose Turkey");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("turkey")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 4)
                    {
                        Console.WriteLine("You chose Beef");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("beef")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 5)
                    {
                        Console.WriteLine("You chose Lamb");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("lamb")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 6)
                    {
                        Console.WriteLine("You chose Spam");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("spam")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 7)
                    {
                        Console.WriteLine("You chose Steak");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("steak")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 8)
                    {
                        Console.WriteLine("You chose Tofu");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("tofu")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 9)
                    {
                        Console.WriteLine("You chose Ham");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("ham")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


                        }
                        else if (userInput3 == 10)
                    {
                        Console.WriteLine("You chose Pepperoni");
                            Console.WriteLine(" ");
                            var linqComfortMeals = from Meal in comfortMeals
                                                   where Meal.Protien.Contains("pepperoni")
                                                   select Meal;

                            foreach (var Meal in linqComfortMeals)
                            {
                                Console.WriteLine($"Option {Meal.Number}: {Meal.Name}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine("Press the number of the meal\nyou would like ingredients for.");
                            int ingredientsList = Convert.ToInt32(Console.ReadLine());
                            var comfortMealList = from Meal in linqComfortMeals
                                                  where Meal.Number == ingredientsList
                                                  select Meal;

                            foreach (var Meal in comfortMealList)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine($"{Meal.HowToMake}");
                            }

                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Press 0 to close the program.");
                            Console.WriteLine("Press any other number to go back to the beginning.");
                            int finalInput = Convert.ToInt32(Console.ReadLine());
                            while (finalInput == 0)
                                Environment.Exit(0);


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
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press 0 to close the program.");
                        Console.WriteLine("Press any other number to go back to the beginning.");
                        int finalInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                        while (finalInput == 0)
                            Environment.Exit(0); 
                   
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
}