namespace StudentProffessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student
            Student student = new Student
            {
                Id = 1,
                Address = "Nerul Navi Mumbai",
                Name = "Rushabh",
                DOB = new DateTime(2003, 5, 21),
                Branch = "Computer Science"
            };
            student.DisplayStudentInfo();

            Console.WriteLine();
            // Professor
            Professor professor = new Professor
            {
                Id = 101,
                Name = "Sameera mam",
                Address = "Faculty Quarters",
                DOB = new DateTime(1986, 3, 15),
                Designation = ".Net Professor",
                YearsOfExperience = 10,
                BaseSalary = 50000
            };
            professor.DisplayProfessorInfo();
        }
    }
}
