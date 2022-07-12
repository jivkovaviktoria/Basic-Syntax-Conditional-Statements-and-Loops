using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(@|#)(?<word>[A-za-z]{3,})\1\1(?<reversedWord>[A-za-z]{3,})\1";
            var input = Console.ReadLine();

            List<string> validPairs = new List<string>();

            MatchCollection matchedWords = Regex.Matches(input, pattern);

            foreach (Match match in matchedWords)
            {
                if (match.Groups["word"].Value == Reverse(match.Groups["reversedWord"].Value))
                {
                    validPairs.Add($"{match.Groups["word"].Value} <=> {match.Groups["reversedWord"].Value}");
                }
            }

            if (matchedWords.Count > 0) Console.WriteLine($"{matchedWords.Count} word pairs found!");
            else Console.WriteLine("No word pairs found!");

            if (validPairs.Count > 0)
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", validPairs));
            }
            else Console.WriteLine($"No mirror words!");


        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
