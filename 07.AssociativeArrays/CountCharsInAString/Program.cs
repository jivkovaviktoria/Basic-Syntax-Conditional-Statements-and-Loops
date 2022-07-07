using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            char[] text = input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (!counts.ContainsKey(letter))
                    counts.Add(letter, 1);
                else
                    counts[letter]++;
            }

            foreach (var item in counts)
                Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
