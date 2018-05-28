using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   class Worker
   {
      public Worker()
      {
         Work();
      }
      public void Work()
      {
         var mediaInventory = new MediaInventory();
         var recordPlayer = new RecordPlayer();
         var cassettePlayer = new CasettePlayer();

         MediaInventory.TestMedia testRecordDelegate =
            new MediaInventory.TestMedia(recordPlayer.PlayRecord);
         MediaInventory.TestMedia testCasssetteDelegate =
            new MediaInventory.TestMedia(cassettePlayer.TestCassette);

         mediaInventory.TestResult( testRecordDelegate );
         mediaInventory.TestResult( testCasssetteDelegate);
      }
   }
}
