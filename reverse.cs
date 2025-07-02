using System;
class ReverseNo
{
    public static int reverse(int n)
    {
        string num = Convert.ToString(n);
        string revnum = "";
        for (int i = num.Length - 1; i >= 0; i--) {
            revnum += num[i];
        }
        return Convert.ToInt32(revnum);

    }
    public static void Main (string[] args)
    {
        Console.WriteLine("enter a number to reverse");
        int number = Convert.ToInt32( Console.ReadLine());
        int revNum = reverse(number);
        Console.WriteLine(revNum);

    }
}