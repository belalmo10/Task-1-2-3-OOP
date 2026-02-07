using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(decimal overdraftLimit)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance + OverdraftLimit)
                return false;

            Balance -= amount;
            return true;
        }

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine($"Overdraft Limit Is: {OverdraftLimit}");
        }
    }
}
