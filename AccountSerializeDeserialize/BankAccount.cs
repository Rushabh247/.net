using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAppSerializationDeserialization
{
   
    
        public class BankAccount
        {
            public int AccountNumber { get; set; }
            public string HolderName { get;  set; }
            public double Balance { get;set; }
        public BankAccount() { }


        public BankAccount(int accountNumber, string holderName, double initialBalance)
            {
                AccountNumber = accountNumber;
                HolderName = holderName;
                Balance = initialBalance;
            }

            public void Deposit(double amount)
            {
                if (amount <= 0) throw new ArgumentException("Amount must be positive.");
                Balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= 0) throw new ArgumentException("Amount must be positive.");
                if (amount > Balance) throw new InvalidOperationException("Insufficient balance.");
                Balance -= amount;
            }

            public override string ToString()
            {
                return $"Account No: {AccountNumber} | Name: {HolderName} | Balance: {Balance:0.00}";
            }
        }
    }


