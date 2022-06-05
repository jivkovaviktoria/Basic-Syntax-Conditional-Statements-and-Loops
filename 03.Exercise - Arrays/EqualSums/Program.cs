using System;
using System.Linq;

namespace EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    isEqual = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (isEqual == false)
                Console.WriteLine("no");

        }
    }
}
