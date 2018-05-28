using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   public class Employee
   {
      public string Name { get; set; }
      protected double vacationDays;
      public virtual void TakeVacation() { }

      public Employee(string name)
      {
         Name = name;
      }

      public override string ToString()
      {
         return $"[Employee: Name = {Name}]";
      }

      
   }
}
