using System;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Random random = new Random();
            int index = random.Next(0, words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                words[i] = words[index];
                words[index] = currentWord;
            }

            foreach (var word in words)
                Console.WriteLine(word);

        }
    }
}
