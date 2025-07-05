using System;

namespace MagicNumberPOC
{
    class Program
    {
        
        static bool IsMagicNumber(int number)
        {
            int sum = number;

            // Keep reducing to a single digit
            while (sum > 9)
            {
                int temp = 0;
                while (sum > 0)
                {
                    temp += sum % 10;
                    sum /= 10;
                }
                sum = temp;
            }

            return sum == 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it's a Magic Number: ");
            int input = int.Parse(Console.ReadLine());

            if (IsMagicNumber(input))
            {
                Console.WriteLine($"{input} is a Magic Number!");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a Magic Number.");
            }

            
        }
    }
}
