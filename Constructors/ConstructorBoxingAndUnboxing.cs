
using System;
class Program
{
    static public void Main()
    {
      /*
      Boxing: It is a process that converts a Value Type variable into a Reference Type variable.
      
     Unboxing: This process extracts the original value type from an object and converts it back to the value type.
*/
        string name = "Rushabh";

        // boxing 
        object obj = name;

		// Display the value of obj
		Console.WriteLine("Value of obj is: " + obj);
		
		// Unboxing
		string unbox = (string)obj; 
		Console.WriteLine("Unboxed value: " + unbox);

    }
}