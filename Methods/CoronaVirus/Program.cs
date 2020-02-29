using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaVirus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją temperaturę w stopniach Fahrenheita: ");
            double temperature = double.Parse(Console.ReadLine());

            temperature = FahrenheitToCelsius(temperature);
            Console.WriteLine($"Temperatura w stopniach Celsiusa wynosi {temperature}");

            if (IsHealthy(temperature))
            {
                Console.WriteLine("Jesteś zdrowy :)");
            }
            else
            {
                Console.WriteLine("Poddaj się kwarantannie");
            }

            Console.Read();
        }

        static double FahrenheitToCelsius(double degress)
        {
            return (degress - 32) * 5 / 9;
        }

        static bool IsHealthy (double celsiusDegrees)
        {
            if (celsiusDegrees >= 37.5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
