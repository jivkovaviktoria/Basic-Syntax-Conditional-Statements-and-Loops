using System;

namespace MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = Calculate(number);
            Console.WriteLine(result);

        }

        static int Calculate(int num)
        {
            int evenSum = 0;
            int oddSum = 0;

            while (num != 0)
            {
                int lastDigit = num % 10;

                if (lastDigit%2==0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }
                num /= 10;
            }

            int result = evenSum * oddSum;
            return result;

        }
    }
}
