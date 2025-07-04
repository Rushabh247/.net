using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_and_hybrid_Inheritance
{
    internal class Manager : Person, IEmployee, IManager
    {
        public string Department { get; set; }
        public int TeamSize { get; set; }

        public Manager(string name, string department, int teamSize)
            : base(name)
        {
            Department = department;
            TeamSize = teamSize;
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine($"Department: {Department}");
        }

        public void ShowManagerDetails()
        {
            Console.WriteLine($"Manages a team of {TeamSize} people.");
        }

    }
}
