using System;
using System.Collections.Generic;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(VowelsCount(word));
        }

        static int VowelsCount(string word)
        {

            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            word = word.ToLower();
            int vowelsCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                    vowelsCount++;
            }
            return vowelsCount;
        }
    }
}
