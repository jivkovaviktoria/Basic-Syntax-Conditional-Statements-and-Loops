using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOddNumbers = int.Parse(Console.ReadLine());
            int counterOfOddNumbers = 0;
            int sumOfOddNUmbers = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sumOfOddNUmbers += i;
                    counterOfOddNumbers++;
                }
                if (counterOfOddNumbers == numberOfOddNumbers)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sumOfOddNUmbers}");
        }
    }
}
