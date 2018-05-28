using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   public class MediaInventory
   {
      public delegate bool TestMedia();

      public void TestResult(TestMedia mediaDelegate)
      {
         if (mediaDelegate() == true)
         {
            Console.WriteLine("Media works, add to inventory");
         }
         else
         {
            Console.WriteLine("Media failed. Reject");
         }
      }
   }
}
