using Bank_System;

namespace Accounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("National Bank", "BNK001");

            Customer c1 = new Customer("Ahmed Ali", "30409252405136", new DateTime(1998, 5, 10));

            SavingAccount sa = new SavingAccount(5);
            sa.Deposit(5000);

            CurrentAccount ca = new CurrentAccount(2000);
            ca.Deposit(1000);

            c1.Accounts.Add(sa);
            c1.Accounts.Add(ca);

            bank.AddCustomer(c1);

            bank.ShowBankReport();

            Console.WriteLine("Monthly Interest:");
            Console.WriteLine(sa.CalculateInterest());
        }
    }
    
}
