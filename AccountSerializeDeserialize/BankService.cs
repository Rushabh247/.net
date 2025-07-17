using System;
using System.Collections.Generic;
using System.Linq;
using AccountAppSerializationDeserialization;


namespace BankApp.Services
{
    public class BankService
    {
        private readonly IAccountRepository _repository;
        private readonly List<BankAccount> _accounts;

        public BankService(IAccountRepository repository)
        {
            _repository = repository;
            _accounts = _repository.Load();
        }

        public void CreateAccount(int accountNumber, string name, double initialBalance)
        {
            if (_accounts.Any(a => a.AccountNumber == accountNumber))
            {
                throw new Exception("Account number already exists.");
            }

            var acc = new BankAccount(accountNumber, name, initialBalance);
            _accounts.Add(acc);
            _repository.Save(_accounts);
            Console.WriteLine($"Account created successfully. Account Number: {accountNumber}");
        }
        public BankAccount GetAccount(int accNo)
        {
            return _accounts.FirstOrDefault(a => a.AccountNumber == accNo);
        }

        public void Deposit(int accNo, double amount)
        {
            var account = GetAccount(accNo) ?? throw new Exception("Account not found.");
            account.Deposit(amount);
            _repository.Save(_accounts);
        }

        public void Withdraw(int accNo, double amount)
        {
            var account = GetAccount(accNo) ?? throw new Exception("Account not found.");
            account.Withdraw(amount);
            _repository.Save(_accounts);
        }

        public void ViewBalance(int accNo)
        {
            var account = GetAccount(accNo) ?? throw new Exception("Account not found.");
            Console.WriteLine(account);
        }

        public void ViewAllAccounts()
        {
            if (!_accounts.Any())
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            foreach (var acc in _accounts)
                Console.WriteLine(acc);
        }
    }
}
