using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal class BankAccount
    {
        private static int counter = 0;

        public string AccountNumber { get; }
        public decimal Balance { get; set; }
        public DateTime DateOpened { get; }

        protected List<Transaction> Transactions = new List<Transaction>();

        public BankAccount()
        {
            AccountNumber = $"Account {++counter}";
            DateOpened = DateTime.Now;
            Balance = 0;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0) return;

            Balance += amount;
            Transactions.Add(new Transaction("Deposit", amount));
        }

        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
                return false;

            Balance -= amount;
            Transactions.Add(new Transaction("Withdraw", amount));
            return true;
        }

        public virtual void ShowAccountDetails()
        {
            Console.WriteLine($"Account: {AccountNumber} , Balance: {Balance} , Opened: {DateOpened}");
        }

        public void ShowTransactions()
        {
            foreach (var transact in Transactions)
            {
                Console.WriteLine($"{transact.Date} , {transact.Type} , {transact.Amount}");
            }
        }

        public virtual decimal CalculateInterest()
        {
            return 0;
        }
    }
}
