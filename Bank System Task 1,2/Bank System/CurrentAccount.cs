using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Bank_System
{
    internal class CurrentAccount : Bank_Account
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string fullName, string nationalID, string phoneNumber, string address,decimal balance,decimal overDraft) 
            : base (fullName, nationalID, phoneNumber, address, balance)
        {
            OverdraftLimit = overDraft;
        }

        public override void ShowAccountDetails()
        {
            Console.WriteLine($"Bank Account Is : {BankCode} , Account Number : {Id} , Client Name : {FullName} , National Id : {NationalID} ," +
                $"Phone Number : {PhoneNumber} , Address : {Address} , Balance : {Balance} EGP , Created At : {CreatedDate} , Over Draft Limit : {OverdraftLimit}");
        }
        public override decimal CalculateInterest()
        {
            return 0;
        }
    }
}
