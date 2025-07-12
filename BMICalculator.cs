using System;

class Person
{
    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double HeightInFeet { get; set; }  // in feet
    public double Weight { get; set; }        // in pounds

    // Constructor 1: All parameters
    public Person(int id, string name, int age, double heightInFeet, double weight)
    {
        Id = id;
        Name = name;
        Age = age;
        HeightInFeet = heightInFeet;
        Weight = weight;
    }

    // Constructor 2: Default height = 5 feet, weight = 50 pounds
    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
        HeightInFeet = 5.0;
        Weight = 50.0;
    }

    // Calculate BMI using height in feet (converted to inches)
    public double CalculateBMI()
    {
        double heightInInches = HeightInFeet * 12;
        return (Weight * 703) / (heightInInches * heightInInches);
    }

    
    public string GetBodyType()
    {
        double bmi = CalculateBMI();

        if (bmi < 18.5)
            return "Underweight";
        else if (bmi < 25)
            return "Normal weight";
        else if (bmi < 30)
            return "Overweight";
        else
            return "Obese";
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
        Console.WriteLine($"Height: {HeightInFeet} feet, Weight: {Weight} pounds");
        Console.WriteLine($"BMI: {CalculateBMI():F2}, Body Type: {GetBodyType()}");
    }
}


class Program
{
    static void Main()
    {
        
        Person p1 = new Person(1, "Alice", 25); 
        Console.WriteLine("Person 1:");
        p1.DisplayInfo();

        Console.WriteLine();

        
        Person p2 = new Person(2, "Bob", 30,5.7,130);
        Console.WriteLine("Person 2:");
        p2.DisplayInfo();
    }
}
