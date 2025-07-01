using System;
class Palindrome
{
    public static bool PalindromeChecker(string number)
    {
        int i = 0;
        int j = number.Length - 1;
        while (i < j) {
            if (number[i] != number[j]) {
                return false;
            }
            i++;
            j--;

        }
        return true;
    }
    public static void Main(string[] args)
    {


        Console.WriteLine("enter the number to check if it is Palindrome");
        string number = Console.ReadLine();
        bool isPalindrome = PalindromeChecker(number);
        if (isPalindrome) { 
        Console.WriteLine($"{number} is a Palindrome"); }
        else
      { 
            Console.WriteLine($"{number} is not a Palindrome");}
    }

}