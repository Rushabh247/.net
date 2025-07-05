using System;

namespace InOutParamsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 1. IN and OUT Demo ---
            Console.WriteLine("=== IN and OUT POC ===");
            int a = 10;
            int result;
            AddFive(in a, out result);
            Console.WriteLine($"Original value (in): {a}");
            Console.WriteLine($"Result after adding 5 (out): {result}\n");

            // --- 2. TryParse Demo ---
            Console.WriteLine("=== TryParse POC ===");
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int parsedNumber);
            if (success)
            {
                Console.WriteLine($"Valid number entered: {parsedNumber}\n");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
            }

            // --- 3. Params Array Demo ---
            Console.WriteLine("=== Params Array POC ===");
            PrintNames("Alice", "Bob", "Charlie");
            PrintNames(); 

            // Demonstrating that Console.WriteLine uses params
            Console.WriteLine("\nConsole.WriteLine using params:");
            Console.WriteLine("Mixing types: {0}, {1}, {2}", 42, "hello", 3.14);
        }

        // --- Method using 'in' and 'out' ---
        static void AddFive(in int x, out int res)
        {
            res = x + 5;
        }

        // --- Method using 'params' ---
        static void PrintNames(params string[] names)
        {
            if (names.Length == 0)
            {
                Console.WriteLine("No names were provided.");
            }
            else
            {
                Console.WriteLine("Names:");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
