using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Account
    {
        long accountNumber;
        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public double GetBalance() //protected
        {
            //code to retrieve account balance from database
            return (double)10000;
        }

        public virtual void Deposit(double amount) //public sealed override void Deposit(double amount)
        {
            {
                //Base class implementation
            }
        }
    }
        class CheckingAccount : Account //sealed class CheckingAccount : Account
        {
            double minBalance;
            public double MinBalance
            {
                get { return minBalance; }
                set { minBalance = value; }
            }
            public void Withdraw(double amount)
            {
                //code to withdraw from account
            }

            public override void Deposit(double amount)
            {
                //Derived class implementation
            }


            //abstract class Account
            //{
            //   public abstract void Deposit(double amount);
            //}
        }
}

