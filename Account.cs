using System;
using System.Collections.Generic;
using System.Text;


namespace BankingApp
{
    //Naming the class Account
    class Account
    {
        //declare public variables
        public decimal balance;
        public decimal depositAmount;
        public decimal withdrawalAmount;

        public Account(decimal Balance)
        {
            this.balance = Balance;
        }

        //create a constructor that receives deposit and withdrawal amount
        public Account(decimal dAmount, decimal wAmount)
        {
            this.depositAmount = dAmount;
            this.withdrawalAmount = wAmount;
        }

        public decimal getBalance()
        {
            return balance;
        }

        //set the initial balance
        public void setBalance(decimal balance)
        {
            if (balance > 0)
            {
                balance = this.balance;
            }

            else
            {
                Console.WriteLine("Balance cannot be negative");

            }
        }

        //create a method Credit that should add an amount to the current balance
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                this.balance += amount;
        }

        //create method Debit that should subtract an amount from the current balance
        public virtual bool Debit(decimal amount)
        {
            if (this.balance - amount > +0)
            {
                this.balance -= amount;
                return true;
            }

            else
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
        }//end method
    }//
}//end class Account

