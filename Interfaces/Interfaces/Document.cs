using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public class Document : IStorable, ISpeak
   {
      public void Reformat()
      {
         Console.WriteLine("Reformatting the document");

      }

      public void Read(string nameOfFile)
      {
         Console.WriteLine($"Reading from {nameOfFile}...");
      }

      public void Write(string fileName)
      {
         Console.WriteLine($"Writing to {fileName}...");
      }

      public double DurationOfSpeach
      {
         get
         {
            return 42;
         }
      }

      public void Speak()
      {
         Console.WriteLine("Speaking...");
      }
   }

}
