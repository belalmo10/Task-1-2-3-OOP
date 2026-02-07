namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Account bankAccount = new Bank_Account("Belal Mohamed", "30409252405135", "01010688296", "El-Minia");
            bankAccount.ShowAccountDetails();

            Console.WriteLine("----------------------------------------------");

            Bank_Account bankAccount2 = new Bank_Account("", "3040925240513", "0101068829", "Cairo", -100);
            bankAccount2.ShowAccountDetails();

            Console.WriteLine("----------------------------------------------");

            Bank_Account bankAccount3 = new Bank_Account("Mohamed Ibrahim", "30409252405133", "01010688291", "Cairo", 100);
            bankAccount3.ShowAccountDetails();

            Console.WriteLine("----------------------------------------------");

            SavingAccount saving = new SavingAccount("Ahmed Ali", "30409252405136", "01010688297", "Alexandria", 5000, 5);

            CurrentAccount current = new CurrentAccount("Sara Hassan", "30409252405137", "01010688298", "Giza", 1000, 2000);

            List<Bank_Account> accounts = new List<Bank_Account> { saving , current };

            foreach (var account in accounts)
            {
                account.ShowAccountDetails();
                Console.WriteLine(account.CalculateInterest());
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
