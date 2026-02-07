using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal class Bank
    {
        public string BankName { get; }
        public string BranchCode { get; }

        public List<Customer> Customers { get; } = new List<Customer>();

        public Bank(string name, string code)
        {
            BankName = name;
            BranchCode = code;
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public Customer FindCustomer(string value)
        {
            return Customers.FirstOrDefault(customer =>
                customer.FullName == value || customer.NationalId == value);
        }

        public bool RemoveCustomer(Customer customer)
        {
            if (customer.GetTotalBalance() == 0)
            {
                Customers.Remove(customer);
                return true;
            }
            return false;
        }

        public void ShowBankReport()
        {
            foreach (var customer in Customers)
            {
                Console.WriteLine($"Customer Info: {customer.FullName} And Total Balance Is: {customer.GetTotalBalance()}");
                foreach (var account in customer.Accounts)
                {
                    account.ShowAccountDetails();
                }
            }
        }
    }
}
