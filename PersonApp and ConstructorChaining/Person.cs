using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; } 
        public double Weight { get; set; } 

        // Constructor with all parameters
        public Person(int id, string name, int age, double height, double weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        // Constructor with default height and weight
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = 5.0; 
            Weight = 50.0;   
        }

        // Calculate BMI (Body Mass Index)
        public double CalculateBMI()
        {
            double heightInMeters = Height * 0.3048; 
            return Math.Round(Weight / (heightInMeters * heightInMeters), 2);
        }

        // Determine body type based on BMI
        public string GetBodyType()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normal";
            else if (bmi >= 25 && bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Height: {Height} ft, Weight: {Weight} kg");
            Console.WriteLine($"BMI: {CalculateBMI()}, Body Type: {GetBodyType()}");
        }
    }
}
