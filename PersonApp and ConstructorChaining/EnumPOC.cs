using System;

// Define an enum
enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        // Declare a variable of type Day
        Day today = Day.Monday;

        Console.WriteLine("Today is: " + today);

        // Use enum in a switch statement
        switch (today)
        {
            case Day.Saturday:
            case Day.Sunday:
                Console.WriteLine("It's weekend! Time to relax.");
                break;

            default:
                Console.WriteLine("It's a weekday. Time to work.");
                break;
        }

        // Loop through enum values
        Console.WriteLine("\nAll Days of the Week:");
        foreach (Day day in Enum.GetValues(typeof(Day)))
        {
            Console.WriteLine($"{(int)day} - {day}");
        }
    }
}
