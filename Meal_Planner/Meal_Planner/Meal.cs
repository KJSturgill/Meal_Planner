using MealPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    public class Meal : Food
    {
        public string[] Protein { get; set; }
        public string HowToMake { get; set; }

        public Meal(int number, string name, string[] protein, string howToMake)
        {
            this.Number = number;
            this.Name = name;
            this.Protein= protein;
            this.HowToMake= howToMake;
        }

    }
}
