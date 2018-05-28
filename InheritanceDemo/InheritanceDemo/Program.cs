using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   class Program
   {
      static void Main(string[] args)
      {
         Employee bob = new Worker("Bob", 35.00);
         Employee joe = new Manager("Joe", true);
         Employee sally = new Worker("Sally", 27.50);

         List<Employee> employees = new List<Employee>()
         {
            joe,
            bob,
            sally
         };

         for (int i = 0; i < employees.Count; i++)
         {
            employees[i].TakeVacation();
            Console.WriteLine(employees[i]);
               
         }
            Console.ReadKey();
        }
   }
}
