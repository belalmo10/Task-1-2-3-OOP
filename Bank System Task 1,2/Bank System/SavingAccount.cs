using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Bank_System
{
    internal class SavingAccount : Bank_Account
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(string fullName, string nationalID, string phoneNumber, string address, decimal balance, decimal interestRate)
            : base(fullName, nationalID, phoneNumber, address, balance)
        {
            InterestRate = interestRate;
        }

        public override void ShowAccountDetails()
        {
            Console.WriteLine($"Bank Account Is : {BankCode} , Account Number : {Id} , Client Name : {FullName} , National Id : {NationalID} ," +
               $"Phone Number : {PhoneNumber} , Address : {Address} , Balance : {Balance} EGP , Created At : {CreatedDate} , Interest Rate : {InterestRate} %");
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate / 100;
        }
    }
}
