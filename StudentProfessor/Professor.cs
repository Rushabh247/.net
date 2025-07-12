using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentProffessor
{
    internal class Professor : Person
    {
        public string Designation { get; set; }
        public int YearsOfExperience { get; set; }
        public double BaseSalary { get; set; }

        // Logic for salary: base + bonus per year of experience
        public double CalculateSalary()
        {
            double experienceBonus = 1000; // Bonus per year of experience
            return BaseSalary + (YearsOfExperience * experienceBonus);
        }

        public void DisplayProfessorInfo()
        {
            Console.WriteLine($"Professor ID: {Id}, Name : {Name} , DOB: {DOB.ToShortDateString()},  Address: {Address}");
            Console.WriteLine($"Designation: {Designation}, Experience: {YearsOfExperience} years, Total Salary: {CalculateSalary()}");
        }
    }
}
