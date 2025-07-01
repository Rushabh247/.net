namespace AssignGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 78, 85, 90, 88, 76 };
            Student student = new Student("Swapnil Kulkarni", "R102", marks);
            student.PrintReport();
        }
    }
}
