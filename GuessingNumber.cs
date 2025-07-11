using System;
class Program
{
    static void StartGame()
    {
        bool playAgain = true;

        while (playAgain)
        {
            PlayGame();
            Console.WriteLine("Do you want to play the game again? yes/no- ");
            string choice = Console.ReadLine();

            if(choice == "no")
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing");
            }
        }
    }

    static void PlayGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(100);
        int attempts = 0;

        Console.WriteLine("Random number generated is- " + randomNumber);

        while (attempts < 5)
        {
            Console.WriteLine("Guess a number- ");
            int guess = int.Parse(Console.ReadLine());

            attempts++;

            if (guess < randomNumber)
                Console.WriteLine("Sorry. Too Low");
            else if (guess > randomNumber)
                Console.WriteLine("Sorry. Too High");
            else
            {
                Console.WriteLine("You won: in Attempts- " + attempts);
                break;
            }
        }
    }


    public static void Main(string[] args)
    {
        StartGame();
    }
}