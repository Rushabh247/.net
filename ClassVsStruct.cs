using System;

public class StudentClass
{
    public string Name;
    public int Age;

    public StudentClass(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public struct StudentStruct
{
    public string Name;
    public int Age;

    public StudentStruct(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
/*
| Feature             | Class                             | Struct                                        |
| ------------------- | --------------------------------- | --------------------------------------------- |
| Type                | Reference Type                    | Value Type                                    |
| Memory Allocation   | Heap                              | Stack                                         |
| Default Constructor | Allowed                           | Not allowed (you must assign fields manually) |
| Inheritance         | Supports inheritance              | Cannot inherit                                |
| Performance         | Slightly slower due to heap usage | Faster for small data types                   |

*/


class Program
{
    static void Main()
    {
        // Class Example (Reference Type)
        StudentClass classStudent1 = new StudentClass("Alice", 20);
        StudentClass classStudent2 = classStudent1; // Reference copy

        classStudent2.Name = "Bob";

        Console.WriteLine("Class Student1 Name: " + classStudent1.Name);  // Output: Bob
        Console.WriteLine("Class Student2 Name: " + classStudent2.Name);  // Output: Bob

        Console.WriteLine();

        // Struct Example (Value Type)
        StudentStruct structStudent1 = new StudentStruct("John", 21);
        StudentStruct structStudent2 = structStudent1; // Value copy

        structStudent2.Name = "David";

        Console.WriteLine("Struct Student1 Name: " + structStudent1.Name); // Output: John
        Console.WriteLine("Struct Student2 Name: " + structStudent2.Name); // Output: David
    }
}
