using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace BankingApplication
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            decimal totalCredit;
            decimal withdrawalAmount;
            decimal depositAmount;

            //create array
            Account[] Account = new Account[2];

            //create array of one savings account and one checking account
            Account[0] = new SavingsAccount(500.00M, .05M);
            Account[0] = new CheckingAccount(200.00M, .04M);

            //Savings account
            Console.WriteLine("Savings Account");
            Console.WriteLine();

            //Displays savings balance
            Console.WriteLine("Savings Account balance: K" + (Account[0].getBalance()));
            Console.WriteLine();

            //Amount to deposit into account
            Console.WriteLine("Enter an amount to deposit into Savings Account: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());

            //Amount withdrawn from the Account
            Console.WriteLine("Enter an amount to withdraw from Savings Account: ");
            withdrawalAmount = Convert.ToDecimal(Console.ReadLine());

            //calculate interest rates
            totalCredit = ((SavingsAccount)Account[0]).calculateInterest();
            Console.WriteLine("Adding Interest: K" + ((totalCredit)) + " (A SavingsAccount)" + "\n");

            //Updates savings Account
            Account[0].Credit(totalCredit);
            Console.WriteLine("Updated Savings Account Balance: K" + ((Account[0].getBalance())) + "\n");

            //Checking Account. Displays the CheckingAccount balance
            Console.WriteLine("Checking Account balance: K" + (Account[1].getBalance()));
            Console.ReadLine();

            //Asks for amount to deposit into the Checking Account
            Console.WriteLine("Enter an amount to deposit into Checking Account: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());

            //Asks for amount to withdraw from the Checking Account
            Console.WriteLine("Enter an amount to withdraw from the Checking Account: ");
            withdrawalAmount = Convert.ToDecimal(Console.ReadLine());


            //Keeps the screen from disappearing
            Console.ReadLine();
        }
    }
}
