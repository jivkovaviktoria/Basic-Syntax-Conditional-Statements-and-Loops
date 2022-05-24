using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int strongNumber = int.Parse(Console.ReadLine());

            int strongNumberCopy = strongNumber;
            int sum = 0;

            while (strongNumber > 0)
            {
                int factorialNumber = 1;
                int currentNumber = strongNumber % 10;
                strongNumber /= 10;

                for (int i = 2; i <= currentNumber; i++)
                {
                    factorialNumber *= i;
                }

                sum += factorialNumber;
            }

            Console.WriteLine(sum == strongNumberCopy ? "yes" : "no");
        }
    }
}
