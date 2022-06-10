using System;
using System.Collections.Generic;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopNumber = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] >= numbers[i])
                    {
                        isTopNumber = false;
                        break;
                    }
                }
                if (isTopNumber)
                    result.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
