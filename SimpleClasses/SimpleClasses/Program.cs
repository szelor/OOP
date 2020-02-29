using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Color = "Czerwony";
            myCar.Make = "Skoda";
            myCar.Model = "Octavia";
            myCar.Year = 2000;

            Car mySecondCar = new Car();
            mySecondCar.Make = "Honda";
            mySecondCar.Year = 2010;

            Console.WriteLine($"Mam samochód {myCar.Make} {myCar.Model} koloru {myCar.Color} z roku {myCar.Year.ToString()} warty {myCar.DetermineValue()}");

            Console.WriteLine($"Mam samochód {mySecondCar.Make} {mySecondCar.Model} koloru {mySecondCar.Color} z roku {mySecondCar.Year.ToString()} warty {mySecondCar.DetermineValue()}");

            Console.Read();
        }
    }
}
