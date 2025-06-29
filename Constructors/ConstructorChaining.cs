using System;

class Person
{
    private string name;
    private int age;

    // Constructor 1: No parameters
    public Person() : this("Unknown", 0)
    {
        Console.WriteLine("Default constructor called.");
    }

    // Constructor 2: One parameter
    public Person(string name) : this(name, 0)
    {
        Console.WriteLine("Constructor with name called.");
    }

    // Constructor 3: Two parameters
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine($"Constructor with name and age called. Name: {name}, Age: {age}");
    }

    public static void Main()
    {
        Person p1 = new Person();               // Calls constructor 1, which chains to 3
        Person p2 = new Person("Alice");        // Calls constructor 2, which chains to 3
        Person p3 = new Person("Bob", 30);      // Calls constructor 3 directly
    }
}
