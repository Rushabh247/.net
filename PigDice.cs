using System;

namespace PigGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;
            int turnCount = 0;
            Random random = new Random();

            Console.WriteLine("Let's Play PIG DICE Game!");
            Console.WriteLine("Get to 20 points. Roll or hold. Roll a 1 and lose turn points!");

            while (totalScore < 20)
            {
                turnCount++;
                int turnScore = 0;
                bool turnOver = false;

                Console.WriteLine($"\n--- Turn {turnCount} ---");

                while (!turnOver)
                {
                    Console.Write("Roll or Hold? (r/h): ");
                    string choice = Console.ReadLine()?.ToLower();

                    if (choice == "r")
                    {
                        int roll = random.Next(1, 7); // 1 to 6
                        Console.WriteLine($"You rolled: {roll}");

                        if (roll == 1)
                        {
                            Console.WriteLine("Oops! You rolled a 1. Turn over, no points added.");
                            turnScore = 0;
                            turnOver = true;
                        }
                        else
                        {
                            turnScore += roll;
                            Console.WriteLine($"Turn total: {turnScore}, Overall score if held: {totalScore + turnScore}");
                        }
                    }
                    else if (choice == "h")
                    {
                        totalScore += turnScore;
                        Console.WriteLine($"you held. Total score is now: {totalScore}");
                        turnOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Type 'r' to roll or 'h' to hold.");
                    }
                }
            }

            Console.WriteLine($"\n You reached 20 points in {turnCount} turns!");
        }
    }
}
