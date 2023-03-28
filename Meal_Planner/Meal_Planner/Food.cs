using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner
{
    public class Food
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public Food()
        {
            Name = string.Empty;
        }
    }
}
