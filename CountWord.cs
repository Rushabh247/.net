using System;

namespace WordCountApp
{
    class CountWord
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Trim and check for empty input
            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("No words found.");
            }
            else
            {
                // Split the sentence into words using space 
                string[] words = sentence.Split(new char[] { ' ' });

                Console.WriteLine("Number of words: " + words.Length);
            }

    
        }
    }
}
