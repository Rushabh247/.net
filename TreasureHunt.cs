using System;
 
class TreasureIslandGame
{
   public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Treasure Island.");
        
 
        Console.Write("Left or Right? ");
        string choice1 = Console.ReadLine().ToLower();
 
        if (choice1 == "left")
        {
            Console.Write("Swim or Wait? ");
            string choice2 = Console.ReadLine().ToLower();
 
            if (choice2 == "wait")
            {
                Console.Write("Which door? (Red, Blue, Yellow): ");
                string choice3 = Console.ReadLine().ToLower();
 
                if (choice3 == "yellow")
                {
                    Console.WriteLine("You Win!");
                }
                else if (choice3 == "red")
                {
                    Console.WriteLine("Burned by fire. Game Over.");
                }
                else if (choice3 == "blue")
                {
                    Console.WriteLine("Eaten by beasts. Game Over.");
                }
                else
                {
                    Console.WriteLine("Game Over.");
                }
            }
            else
            {
                Console.WriteLine("Attacked by trout. Game Over.");
            }
        }
        else
        {
            Console.WriteLine("Fall into a hole. Game Over.");
        }
    }
}