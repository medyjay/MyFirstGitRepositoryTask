using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication
{
    class SavingsAccount : Account
    {
        private decimal interestRate;

        //create constructor SavingsAccount
        public SavingsAccount(decimal Bal, decimal intRate)
            : base(Bal)
        {
            this.interestRate = intRate;
        }

        //
        public decimal getCalculateInterest()
        {
            return interestRate;
        }

        //
        public void setInterestRate(decimal interestRate)
        {
            if (interestRate > 0)
                this.interestRate = interestRate;
            else
            {
                Console.WriteLine("Interest rate must be higher than zero");
            }
        }

        //
        public decimal calculateInterest()
        {
            return getBalance() * interestRate;
        }
    }
}
