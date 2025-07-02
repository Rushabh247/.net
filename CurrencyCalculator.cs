using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter withdrawal amount : ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int amount))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        if (amount > 50000)
        {
            Console.WriteLine("Amount should not exceed 50000.");
            return;
        }

        if (amount % 100 != 0)
        {
            Console.WriteLine("Amount should be a multiple of 100.");
            return;
        }

        int[] denominations = { 2000, 500, 200, 100 };
        string[] labels = { "Two Thousand", "Five Hundred", "Two Hundred", "Hundred" };

        for (int i = 0; i < denominations.Length; i++)
        {
            int count = amount / denominations[i];
            if (count > 0)
            {
                Console.WriteLine($"{labels[i]} : {count}");
                amount %= denominations[i];
            }
        }
    }
}
