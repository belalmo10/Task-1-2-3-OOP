using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal class Bank_Account
    {
        public const string BankCode = "BNK001";

        public readonly DateTime CreatedDate;

        //private static int _accountNumber = 0;
        public string Id { get; }

        private string _fullName;

        private string _nationalID;

        private string _phoneNumber;

        private string _address;

        private decimal _balance;

        private static int idCounter = 0;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty.");
                }
                else
                {
                    _fullName = value;
                }
            }
        }

        public string NationalID
        {
            get { return _nationalID; }
            set
            {
                if (!IsValidNationalId(value))
                {
                    Console.WriteLine("National ID must be a 14 integer Numbers.");
                }
                else
                {
                    _nationalID = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!IsValidPhoneNumber(value))
                {
                    Console.WriteLine("Phone number must be a 11 integer Numbers And Start With (01).");
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Balance cannot be negative And Must Be Greater Than Or Equal Zero.");
                }
                else
                {
                    _balance = value;
                }
            }
        }

        public string Address
        {
            get { return _address ; } 
            set { _address = value ; }
        }

        public Bank_Account()
        {
            CreatedDate = DateTime.Now;
            Id = Generate();

        }

        public Bank_Account(string fullName, string nationalID, string phoneNumber, string address, decimal balance) : this()
        {
            FullName = fullName;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Address = address;
            Balance = balance;
        }

        public Bank_Account(string fullName, string nationalID, string phoneNumber, string address) : this(fullName , nationalID , phoneNumber , address , 0)
        {

        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length == 11 && phoneNumber.StartsWith("01") && long.TryParse(phoneNumber, out _);
        }

        public bool IsValidNationalId(string NationalId)
        {
            return !string.IsNullOrWhiteSpace(NationalId) && NationalId.Length == 14 &&  long.TryParse(NationalId, out _);
        }

        public virtual void ShowAccountDetails()
        {
            Console.WriteLine($"Bank Account Is : {BankCode} , Account Number : {Id} , Client Name : {_fullName} , National Id : {_nationalID} ," +
                $"Phone Number : {_phoneNumber} , Address : {_address} , Balance : {_balance} EGP , Created At : {CreatedDate}");
        }
        public static string Generate()
        {
            return $"ISBN {++idCounter}";
        }
        public virtual decimal CalculateInterest()
        {
            return 0;
        }
    }
}
