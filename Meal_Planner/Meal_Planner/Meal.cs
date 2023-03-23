using MealPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    internal class Meal : Food
    {
        public string[] Protien { get; set; }
        public string[] HowToMake { get; set; }

        public Meal(int number, string name, string[] protien, string[] howToMake)
        {
            this.Number = number;
            this.Name = name;
            this.Protien= protien;
            this.HowToMake= howToMake;
        }

    }
}
