using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                int nextIndex = 0;
                if (i + 1 > numbers.Count - 1)
                    break;
                else
                    nextIndex = i + 1;

                if (numbers[i] == numbers[nextIndex])
                {
                    numbers[i] += numbers[nextIndex];
                    numbers.RemoveAt(nextIndex);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
