using BankApp.Services;

namespace AccountAppSerializationDeserialization
{
    internal class Program
    {
    
            static void Main(string[] args)
            {
                var repo = new JsonAccountRepository("C:\\Users\\rushabh.gunjal\\OneDrive - Aurionpro Solutions Limited\\Documents\\.net assignments mithril\\AccountAppSerializationDeserialization\\accounts.json");
                var bankService = new BankService(repo);

                int choice;
                do
                {
                    Console.WriteLine("\n===== BANK SYSTEM MENU =====");
                    Console.WriteLine("1. Create New Account");
                    Console.WriteLine("2. Select Account");
                    Console.WriteLine("3. View All Accounts");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                        Console.Write("Enter Account Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int accountNumber))
                        {
                            Console.WriteLine("Invalid account number.");
                            break;
                        }

                        Console.Write("Enter Holder Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Initial Balance: ");
                        if (!double.TryParse(Console.ReadLine(), out double balance))
                        {
                            Console.WriteLine("Invalid balance input.");
                            break;
                        }

                        try
                        {
                            bankService.CreateAccount(accountNumber, name, balance);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                        case 2:
                            Console.Write("Enter Account Number: ");
                            if (!int.TryParse(Console.ReadLine(), out int accNo))
                            {
                                Console.WriteLine("Invalid account number.");
                                break;
                            }

                            var account = bankService.GetAccount(accNo);
                            if (account == null)
                            {
                                Console.WriteLine("Account not found.");
                                break;
                            }

                            int subChoice;
                            do
                            {
                                Console.WriteLine($"\n--- Account: {account.AccountNumber} ({account.HolderName}) ---");
                                Console.WriteLine("1. Deposit");
                                Console.WriteLine("2. Withdraw");
                                Console.WriteLine("3. View Balance");
                                Console.WriteLine("4. Back to Main Menu");
                                Console.Write("Enter choice: ");

                                if (!int.TryParse(Console.ReadLine(), out subChoice))
                                {
                                    Console.WriteLine("Invalid input.");
                                    continue;
                                }

                                switch (subChoice)
                                {
                                    case 1:
                                        Console.Write("Enter deposit amount: ");
                                        if (double.TryParse(Console.ReadLine(), out double depAmt))
                                            bankService.Deposit(accNo, depAmt);
                                        else Console.WriteLine("Invalid amount.");
                                        break;

                                    case 2:
                                        Console.Write("Enter withdrawal amount: ");
                                        if (double.TryParse(Console.ReadLine(), out double wdAmt))
                                            bankService.Withdraw(accNo, wdAmt);
                                        else Console.WriteLine("Invalid amount.");
                                        break;

                                    case 3:
                                        bankService.ViewBalance(accNo);
                                        break;

                                    case 4:
                                        Console.WriteLine("Returning to main menu...");
                                        break;

                                    default:
                                        Console.WriteLine("Invalid choice.");
                                        break;
                                }

                            } while (subChoice != 4);
                            break;

                        case 3:
                            bankService.ViewAllAccounts();
                            break;

                        case 4:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                } while (choice != 4);
            }
        }
    }



