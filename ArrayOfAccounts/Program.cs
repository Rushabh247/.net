namespace ArrayOfAccounts
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of accounts to create (max size of array): ");
            int size = int.Parse(Console.ReadLine());
            Account[] accounts = new Account[size];
            int accountCount = 0;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (accountCount >= size)
                        {
                            Console.WriteLine("Account limit reached.");
                            break;
                        }

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Initial Balance (min ₹500): ");
                        double initial = double.Parse(Console.ReadLine());

                        if (initial < 500)
                        {
                            Console.WriteLine("Initial balance must be at least ₹500.");
                            break;
                        }

                        Console.Write("Enter Account Type (savings/current): ");
                        string type = Console.ReadLine().ToLower();

                        string[] existingAccountNumbers = new string[accountCount];
                        for (int i = 0; i < accountCount; i++)
                            existingAccountNumbers[i] = accounts[i].AccountNumber;

                        accounts[accountCount] = new Account(name, initial, type, existingAccountNumbers);
                        Console.WriteLine($"Account created successfully! Account Number: {accounts[accountCount].AccountNumber}");
                        accountCount++;
                        break;

                    case "2":
                        Console.Write("Enter Account Number: ");
                        string accNum = Console.ReadLine();
                        Account acc = FindAccount(accounts, accountCount, accNum);
                        if (acc != null)
                            acc.ShowDetails();
                        else
                            Console.WriteLine("Account not found.");
                        break;

                    case "3":
                        Console.Write("Enter Account Number: ");
                        accNum = Console.ReadLine();
                        acc = FindAccount(accounts, accountCount, accNum);
                        if (acc != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            double amt = double.Parse(Console.ReadLine());
                            acc.Deposit(amt);
                        }
                        else
                            Console.WriteLine("Account not found.");
                        break;

                    case "4":
                        Console.Write("Enter Account Number: ");
                        accNum = Console.ReadLine();
                        acc = FindAccount(accounts, accountCount, accNum);
                        if (acc != null)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            double amt = double.Parse(Console.ReadLine());
                            acc.Withdraw(amt);
                        }
                        else
                            Console.WriteLine("Account not found.");
                        break;

                    case "5":
                        Console.WriteLine("Exiting application.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static Account FindAccount(Account[] accounts, int count, string accNum)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].AccountNumber == accNum)
                    return accounts[i];
            }
            return null;
        }
    }

}
