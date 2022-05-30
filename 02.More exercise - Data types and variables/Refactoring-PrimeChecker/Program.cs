using System;

namespace Refactoring_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", number, isPrime.ToString().ToLower());
            }
        }
    }
}
