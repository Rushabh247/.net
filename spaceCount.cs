using System;
class CountSpaces
{

    public static void spaceCount(string sentence)
    {
        int count = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                count++;
            }
        }
        Console.WriteLine($" the number of spaces are {count}");
    }
    public static void Main(string[] args) {
        Console.WriteLine("enter the sentence");
        string sentence = Console.ReadLine();
        spaceCount(sentence);
    }
}