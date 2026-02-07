using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal class Customer
    {
        private static int counter = 0;

        public string CustomerId { get; }
        public string FullName { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<BankAccount> Accounts { get; } = new List<BankAccount>();

        public Customer(string name, string nationalId, DateTime dob)
        {
            CustomerId = $"Customer {++counter}";
            FullName = name;
            NationalId = nationalId;
            DateOfBirth = dob;
        }

        public decimal GetTotalBalance()
        {
            return Accounts.Sum(account => account.Balance);
        }
    }
}
