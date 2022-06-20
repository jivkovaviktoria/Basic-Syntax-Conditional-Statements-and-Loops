using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> biggerNumbers = new List<int>();
            double sum = 0;
            double averageNumber = 0;

            foreach (var num in integers)
                sum += num;

            averageNumber = sum / integers.Count;

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] > averageNumber)
                    biggerNumbers.Add(integers[i]);
            }

            biggerNumbers.Sort();
            biggerNumbers.Reverse();

            var lastIndex = biggerNumbers.Count - 1;
            while(biggerNumbers.Count>5)
            {
                biggerNumbers.RemoveAt(lastIndex);
                lastIndex--;
            }

            if (biggerNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(" ", biggerNumbers));
        }
    }
}
