using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication
{
    class CheckingAccount : Account
    {
        private decimal fee;

        //create a constructor CheckingAccount
        public CheckingAccount(decimal balance, decimal f)
            : base(balance)
        {
            this.fee = f;
        }

        //
        public decimal getFee()
        {
            return fee;
        }

        //
        public void setFee(decimal fee)
        {
            if (fee > 0)
                this.fee = fee;
            else
            {
                Console.WriteLine("Fee cannot be less than zero");
            }
        }

        //
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            this.balance -= this.fee;
        }

        //
        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                this.balance -= this.fee;
                return true;
            }
            else
                return false;

        }


    }
}
