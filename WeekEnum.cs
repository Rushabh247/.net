using System;

enum Day
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1–7) to get the corresponding day: ");

        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Day day = (Day)dayNumber;
                Console.WriteLine("Day: " + day);
            }
            else
            {
                Console.WriteLine("Error: Please enter a number between 1 and 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
