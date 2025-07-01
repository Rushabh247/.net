using System;
class FibbonacciSeries
{
   public static void fibonacci(int length)
    {
        int firstNo = 1;
        int secondNo = 1;
        for (int i = 0; i < length; i++) {
            Console.Write(firstNo + " ");
            int temp = firstNo;
             firstNo = secondNo;
            secondNo +=  temp;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the length of Fibonacci series");
        int length = Convert.ToInt32(Console.ReadLine());
        fibonacci(length);

    }
    }