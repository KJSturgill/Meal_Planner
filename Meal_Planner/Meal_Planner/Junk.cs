using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    internal class Junk : Food
    {
        public string[] Suggestion { get; set; }

        public Junk(int number, string name, string[] suggestion)
        {
            this.Number = number;
            this.Name = name;
            this.Suggestion = suggestion;
        }
    }
}
