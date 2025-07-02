using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfAccounts
{
   
        public class Account
        {
            public string AccountNumber { get; private set; }
            public string Name { get; set; }
            public double Balance { get; private set; }
            public string AccountType { get; set; }

            private static Random random = new Random();

            public Account(string name, double initialBalance, string accountType, string[] existingAccountNumbers)
            {
                Name = name;
                Balance = initialBalance;
                AccountType = accountType;
                AccountNumber = GenerateUniqueAccountNumber(existingAccountNumbers);
            }

            private string GenerateUniqueAccountNumber(string[] existing)
            {
                string accNum;
                do
                {
                    accNum = "IDBI" + random.Next(10000000, 99999999);
                } while (Array.Exists(existing, e => e == accNum));
                return accNum;
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"₹{amount} deposited successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && (Balance - amount) >= 500)
                {
                    Balance -= amount;
                    Console.WriteLine($"₹{amount} withdrawn successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance or minimum ₹500 must be maintained.");
                }
            }

            public void ShowDetails()
            {
                Console.WriteLine($"Account Number: {AccountNumber}, Name: {Name}, Balance: ₹{Balance}, Type: {AccountType}");
            }
        }
    }


