namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(1, "Alice", 30, 5.5, 65);

            
            Person p2 = new Person(2, "Bob", 25);

            Console.WriteLine("Person 1:");
            p1.DisplayInfo();

            Console.WriteLine("\nPerson 2:");
            p2.DisplayInfo();
        }
    }
}
