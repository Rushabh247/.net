namespace Multilevel_and_hybrid_Inheritance
{
    internal class Program
    {
        class Animal
        {
            public void eat()
            {
                Console.WriteLine("Animal Eats");
            }
        }
        class Mammal : Animal
        {
            public void walks()
            {
                Console.WriteLine("Mammal Walks");
            }
        }

        class Human : Mammal
        {
            public void speaks()
            {
                Console.WriteLine("Human Speaks");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Multilevel inheritance implementation");
           Human human = new Human();
            human.eat();
            human.walks();
            human.speaks();
            Console.WriteLine();
            Console.WriteLine("Multilevel inheritance implementation");

            Manager mgr = new Manager("Alice", "IT", 10);

            Console.WriteLine("Manager Info:");
            mgr.Display();               // From Person
            mgr.ShowEmployeeDetails();   // From IEmployee
            mgr.ShowManagerDetails();    // From Imanager
        }
    }
}
