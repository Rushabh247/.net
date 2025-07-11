

using AccountClassLib;
namespace AccountConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Account ac = new Account("ICICI2424","Rushabh",7000);
            ac.Deposit(5000);
            ac.Deposit(3000);
            ac.Withdraw(2000);
           Console.WriteLine(ac.ToString());

        }
    }
}
