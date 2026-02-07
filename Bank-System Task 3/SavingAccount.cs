using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(decimal interestRate)
        {
            InterestRate = interestRate;
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"Interest Rate Is: {InterestRate}%");
        }
    }
}
