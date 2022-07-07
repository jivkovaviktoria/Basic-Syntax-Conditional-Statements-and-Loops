using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!counts.ContainsKey(number))
                    counts.Add(number, 1);
                else
                    counts[number] += 1;
            }

            foreach (var item in counts)
                Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
