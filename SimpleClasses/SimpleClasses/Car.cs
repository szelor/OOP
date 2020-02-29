using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Car
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double DetermineValue()
        {
            double carValue;
            if (this.Year > 2000)
                carValue = 30000;
            else
                carValue = 10000;

            return carValue;
        }
    }
}
