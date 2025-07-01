using System;

class Student
{
    private string name;
    private int marks;
    private char grade;

    // Constructor 1: Only Name
    public Student(string name)
    {
        this.name = name;
        this.marks = 0;
        this.grade = 'N'; // 'N' for Not assigned yet
    }

    // Constructor 2: Name and Marks
    public Student(string name, int marks)
    {
        this.name = name;
        this.marks = marks;
        this.grade = 'N';
    }

    // Constructor 3: Name, Marks, and Grade
    public Student(string name, int marks, char grade)
    {
        this.name = name;
        this.marks = marks;
        this.grade = grade;
    }

    
    public void AssignGrade()
    {
        if (marks >= 90)
        {
            grade = 'A';
        }
        else if (marks >= 80)
        {
            grade = 'B';
        }
        else if (marks >= 70)
        {
            grade = 'C';
        }
        else
        {
            grade = 'D';
        }
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Marks: {marks}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine();
    }

   
    public static void Main(string[] args)
    {
      
        Student student1 = new Student("Alice");
        student1.AssignGrade(); 
        student1.DisplayInfo();

        
        Student student2 = new Student("Bob", 85);
        student2.AssignGrade(); 
        student2.DisplayInfo();

        
        Student student3 = new Student("Charlie", 92, 'X'); 
        student3.AssignGrade(); 
        student3.DisplayInfo();
    }
}
