using System;
using System.Linq;
using System.Numerics;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                BigInteger sum = 0;
                BigInteger[] numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

                BigInteger biggerNumber = BigInteger.Abs(BigInteger.Max(numbers[0], numbers[1]));
                while (biggerNumber != 0)
                {
                    sum += biggerNumber % 10;
                    biggerNumber /= 10;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
