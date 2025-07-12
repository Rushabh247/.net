using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
            Console.WriteLine("It's a palindrome.");
        else
            Console.WriteLine("Not a palindrome.");
    }

    static bool IsPalindrome(string str)
    {
        str = str.ToLower().Replace(" ", ""); // Convert to lowercase and remove spaces

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
