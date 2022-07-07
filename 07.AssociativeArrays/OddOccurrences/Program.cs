using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(w => w.ToLower()).ToArray();
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!occurrences.ContainsKey(word))
                    occurrences.Add(word, 1);
                else
                    occurrences[word]++;
            }

            foreach (var item in occurrences)
            {
                if (item.Value % 2 != 0)
                    Console.Write($"{item.Key} ");
            }
        }
    }
}
