using System;
using System.Collections;

enum Planet
{
    MERCURY,
    VENUS,
     MARS,
    JUPITER,
    SATURN,
    URANUS,
    NEPTUNE
}

class Program
{
    static Hashtable Gravity = new Hashtable
    {
        { Planet.MERCURY, 0.38 },
        { Planet.VENUS,   0.91 },
        { Planet.MARS,    0.38 },
        { Planet.JUPITER, 2.37 },
        { Planet.SATURN,  0.92 },
        { Planet.URANUS,  0.89 },
        { Planet.NEPTUNE, 1.12 }
    };

    static void Main()
    {
        Console.Write("Enter Earth weight (in kg): ");
        if (double.TryParse(Console.ReadLine(), out double earthWeight))
        {
            foreach (Planet planet in Enum.GetValues(typeof(Planet)))
            {
        

                double gravity = (double)Gravity[planet];
                double weightOnPlanet = Math.Round(earthWeight * gravity, 1);
                Console.WriteLine($"Weight on {planet}: {weightOnPlanet} kg");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
