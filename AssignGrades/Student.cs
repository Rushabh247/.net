using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignGrade
{
    internal class Student
    {
        private string studentName;
        private string rollNumber;
        private int[] marks;

        public Student(string name, string roll, int[] marksArray)
        {
            if (marksArray.Length != 5)
                throw new ArgumentException("Exactly 5 marks must be provided.");

            studentName = name;
            rollNumber = roll;
            marks = marksArray;
        }

        // Method to calculate average marks
        public double CalculateAverage()
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return Math.Round((double)total / marks.Length, 1);
        }

        // Method to determine grade
        public string CalculateGrade()
        {
            double average = CalculateAverage();

            if (average >= 90) return "A+";
            else if (average >= 80) return "A";
            else if (average >= 70) return "B";
            else if (average >= 60) return "C";
            else if (average >= 50) return "D";
            else return "Fail";
        }

        // Method to print the report
        public void PrintReport()
        {
            Console.WriteLine("Student Report Card");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name        : {studentName}");
            Console.WriteLine($"Roll No     : {rollNumber}");
            Console.WriteLine($"Marks       : [{string.Join(", ", marks)}]");
            Console.WriteLine($"Average     : {CalculateAverage()}");
            Console.WriteLine($"Grade       : {CalculateGrade()}");
        }
    }


}
