using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    internal class Program
    {
        static HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'u', 'i', 'o' };
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> results = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                int sum = SumEncrypted(word);
                
                results.Add(sum);
            }

            foreach (var result in results.OrderBy(x => x))
                Console.WriteLine(result);
        }

        static int SumEncrypted(string word)
        {
            int sum = 0;
            foreach (char c in word)
            {
                if (vowels.Contains(char.ToLower(c)))
                    sum += c * word.Length;
                else
                    sum += c / word.Length;
            }

            return sum;
        }
    }
}
