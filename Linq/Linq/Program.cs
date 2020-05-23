using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>
            {
                new Car() {VIN = 1, Make ="Toyota", Model = "Auris", Year = 1999, Price = 9500},
                new Car() {VIN = 2, Make = "BMW", Model = "550", Year= 2002, Price = 10250},
                new Car() {VIN = 3, Make ="Toyota", Model = "Avensis", Year = 2001, Price = 10100}
            };

            //LINQ query
            //var toyotas = from car in myCars
            //              where car.Make == "Toyota"
            //              && car.Year >=2000
            //              select car;

            //var sortedCars = from car in myCars
            //                 orderby car.Price descending
            //                 select car;

            
            //LINQ methods

            //var toyotas = myCars.Where(p => p.Make == "Toyota" && p.Year >= 2000);

            //foreach (var item in toyotas)
            //{
            //    Console.WriteLine(item.Price.ToString());
            //}

            //var sortedCars = myCars.OrderByDescending(p => p.Price);

            //foreach (var item in sortedCars)
            //{
            //    Console.WriteLine(item.Price);
            //}

            var expensiveToyota = myCars.OrderByDescending(p => p.Price).First(p => p.Make == "Toyota");

            Console.WriteLine(expensiveToyota.Price);

            myCars.ForEach(p => p.Price -= 1500);
            myCars.ForEach(p => Console.WriteLine(p.Price));

            Console.WriteLine(myCars.Sum(p => p.Price));

            Console.Read();
        }
    }

    class Car
    {
        public int VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }
}
