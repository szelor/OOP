using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
   public class Worker
   {
      public Worker()
      {
         Work();
      }

      public int Multiply(int x, int y)
      {
         return x*y;
      }

      public void Work()
      {
         int a = 10;
         int b = 20;

         Func<int, int, int> MultiplyDelegate;
         MultiplyDelegate = Multiply;
         int product = MultiplyDelegate(a, b);
         Console.WriteLine($"Product = {product}");

         Func<int, int, int> MultiplyDelegate2 = (x, y) => (x*y);
         int product2 = MultiplyDelegate2(a, b);
         Console.WriteLine($"Product2 = {product2}");

      }

   }
}
