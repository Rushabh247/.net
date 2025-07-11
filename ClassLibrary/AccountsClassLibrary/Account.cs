namespace AccountClassLib
{
    
        public class Account
        {
            public string AccountNumber { get; set; }
            public string AccountHolder { get; set; }
            public decimal Balance { get; private set; }

            public Account(string accountNumber, string accountHolder, decimal initialBalance)
            {
                AccountNumber = accountNumber;
                AccountHolder = accountHolder;
                Balance = initialBalance;
            }

            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                }
            }

            public bool Withdraw(decimal amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                    return true;
                }
                return false;
            }

            public override string ToString()
            {
                return $"Account: {AccountNumber}, Holder: {AccountHolder}, Balance: {Balance:C}";
            }
        }
    }


