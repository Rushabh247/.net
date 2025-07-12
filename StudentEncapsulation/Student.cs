using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulation
{
    internal class Student
    {
        private int rollNo;
        private string name;
        private double cgpa;

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Roll number must be greater than zero.");
                }
                rollNo = value;

            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 5)
                    name = value;
                else
                    name = "";
            }
        }

        public double Gpa
        {
            get { return cgpa; }
            set
            {
                if (value < 1.0 || value > 10.0)
                {
                    throw new ArgumentException("CGPA must be between 1.0 and 10.0.");
                }
                cgpa = value;
            }
        }

        public double GetPercentage()
        {
            return cgpa * 9.5;
        }

        public override string ToString()
        {
            return $"Roll No           : {RollNo}\n" +
                   $"Name:             : {name}\n" +
                   $"CGPA              : {cgpa}\n" +
                   $"Percentage        : {GetPercentage()}";
        }
    }
}