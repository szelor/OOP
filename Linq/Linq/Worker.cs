using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Linq
{
   public class Worker
   {
      public Worker()
      {
         Work();
      }
      public void Work()
      {
         var listOfInt = new List<int>
         {
            2,
            7,
            3,
            13,
            5,
            18,
            16
         };

         var smallerNumbers = from num in listOfInt
                              where num < 8
                              select num;

         foreach (int number in smallerNumbers)
         {
            Console.WriteLine($"Value: {number}");
         }
         Console.WriteLine("\n-----------------\n");

         var smallerNumbers2 = listOfInt
            .Where(n => n < 8)
            .Select(n => n);

         foreach (int number2 in smallerNumbers2)
         {
            Console.WriteLine($"Value: {number2}");
         }
         Console.WriteLine( "\n-----------------\n" );
         var methods = from method in typeof(int).GetMethods()
                       orderby method.Name
                       group method by method.Name
                       into groups
                       select new
                       {
                          MethodName = groups.Key,
                          MethodOverloads = groups.Count()
                       };
         foreach (var item in methods)
         {
            Console.WriteLine(item);
         }

         Console.WriteLine( "\n-----------------\n" );

         var million = Enumerable.Range(0, 1000000)
            .Select(x =>
            {
               Thread.Sleep(500);
               return x*x;
            });

         foreach (var number in million)
         {
            Console.Write(number + " ");
         }
      }
   }
}
