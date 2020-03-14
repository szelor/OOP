using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount oCheckingAccount = new CheckingAccount();
            double balance;
            oCheckingAccount.AccountNumber = 1000;
            balance = oCheckingAccount.GetBalance();
            oCheckingAccount.Withdraw(500);
            Console.WriteLine(oCheckingAccount.GetBalance());
            Console.ReadKey();
        }
    }
}
