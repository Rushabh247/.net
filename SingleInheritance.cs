using System;


class Person
{
    public string Name;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}


class Student : Person
{
    public int RollNumber;

    public void ShowStudentInfo()
    {
        DisplayInfo(); 
        Console.WriteLine($"Roll Number: {RollNumber}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = "Rahul";
        s.Age = 20;
        s.RollNumber = 101;

        s.ShowStudentInfo();
    }
}
