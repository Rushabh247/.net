using System;

namespace ArrayTestApp
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Mango", "Orange" };

            Console.WriteLine("Using FOR loop:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"Fruit[{i}] = {fruits[i]}");
            }

            Console.WriteLine("\nUsing FOREACH loop:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit = " + fruit);
            }

           
        }
    }
}
