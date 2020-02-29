using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer 1. miesiąca: ");
            int firstMonth = int.Parse(Console.ReadLine());

            SayMonth(firstMonth);

            Console.WriteLine("Podaj numer 2. miesiąca: ");
            int secondMonth = int.Parse(Console.ReadLine());

            SayMonth(secondMonth);

            SayPeriod(firstMonth, secondMonth);

            Console.ReadKey();

        }

        static void SayMonth(int month)
        {
            string[] monthNames = new string[]
            {
                "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec",
                "Lipiec", "Sierpień", "Wrzesień", "Paźdiernik", "Listopad", "Grudzień"
            };
            Console.WriteLine(monthNames[month - 1]);
        }

        static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                period = period + 12;
            }
            Console.WriteLine($"Jest {period} miesięcy różnicy");
        }
    }
}
