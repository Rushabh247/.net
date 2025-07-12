using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudOnList
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n=== CRUD on List<Student> ===");
                Console.WriteLine("1. Create Student");
                Console.WriteLine("2. Read All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateStudent();
                        break;
                    case 2:
                        ReadStudents();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 5);
        }

        // CREATE
        static void CreateStudent()
        {
            Student student = new Student();

            Console.Write("Enter ID: ");
            student.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        // READ
        static void ReadStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\nList of Students:");
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
            }
        }

        // UPDATE
        static void UpdateStudent()
        {
            Console.Write("Enter ID of student to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                Console.Write("Enter New Name: ");
                student.Name = Console.ReadLine();

                Console.Write("Enter New Age: ");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        // DELETE
        static void DeleteStudent()
        {
            Console.Write("Enter ID of student to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
