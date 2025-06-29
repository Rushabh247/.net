
using System;
class Sum
{
    // Constructor
    public Sum(int a,int b){
        Console.WriteLine($"The sum is : {a+b}");
    }
    // Consructor overloading
    // constructor with different signature or no of parameters
     public Sum(double a,double b){
        Console.WriteLine($"The sum is : {a+b}");
    }
     public static void Main()
    {
    Sum obj1 = new Sum(5,6); 
    Sum obj2 = new Sum(4.5,6.5);

    }
}