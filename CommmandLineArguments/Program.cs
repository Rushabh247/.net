namespace CommandLineArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                numbers[i] = int.Parse(args[i]);
            }

            int sum = 0, count = 0, max = numbers[0], min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];
                sum += num;
                count++;

                if (num > max)
                    max = num;

                if (num < min)
                    min = num;
            }

            double average = (double)sum / count;

            Console.WriteLine("Numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nSum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }
    }
}