using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   public class RecordPlayer
   {
      private bool status;
      // other methods
      public bool PlayRecord()
      {
         Console.WriteLine("Testing record. Works.");
         status = true;
         return status;
      }
   }
}
