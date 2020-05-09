using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car();
            myFirstCar.VIN = 12345;
            myFirstCar.Make = "Toyota";
            myFirstCar.Model = "Auris";

            Car mySecondCar = new Car();
            mySecondCar.VIN = 21456;
            mySecondCar.Make = "BWM";
            mySecondCar.Model = "X5";

            Bike myBike = new Bike();
            myBike.Color = "Blue";

            //Object Initializer
            Car myLastCar = new Car() { VIN = 4444, Make = "Fiat", Model = "Punto" };

            //Collection Initializer

            List<Car> myCars = new List<Car>()
            {
                new Car() {VIN = 4444, Make = "Fiat", Model = "Punto" },
                new Car() {VIN = 333, Make = "Skoda", Model = "Octavia" }
            };

            foreach (Car item in myCars)
            {
                Console.WriteLine(item.Make);
            }

            //ArrayLists
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(myFirstCar);
            myArrayList.Add(mySecondCar);
            myArrayList.Add(myBike);
            myArrayList.Remove(myBike);

            Console.WriteLine(myArrayList.Count);

            foreach (Car item in myArrayList)
            {
                Console.WriteLine(item.Make);
            }

            //List<T>
            List<Car> myList = new List<Car>();
            myList.Add(myFirstCar);
            myList.Add(mySecondCar);
            myList.Add(myLastCar);
            //myList.Add(myBike);

            foreach (Car item in myList)
            {
                Console.WriteLine(item.Model);
            }

            Console.ReadLine();
        }
    }
}
