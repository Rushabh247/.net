using System;

namespace BoxingUnboxingPOC
{
    class Program
    {
       public static void Main(string[] args)
        {
           
            int num = 100;

            // BOXING: Converting int(value type) to object
            object obj = num; // Implicit boxing
            Console.WriteLine("Boxing:");
            Console.WriteLine("Value Type (int): " + num);
            Console.WriteLine("Boxed Object: " + obj);

            // UNBOXING: Converting object back to int
            int unboxedNum = (int)obj; // Explicit unboxing
            Console.WriteLine("\nUnboxing:");
            Console.WriteLine("Unboxed Value: " + unboxedNum);

            
        }
    }
}
