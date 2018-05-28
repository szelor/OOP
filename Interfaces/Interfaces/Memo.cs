using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public class Memo : Document
   {
      public string MemoTo { get; set; }
      public string MemoFrom { get; set; }
      public DateTime Date { get; set; }
      public string Subject { get; set; }

   }
}
