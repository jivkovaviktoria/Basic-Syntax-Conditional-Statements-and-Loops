using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string firstWord = strings[0];
            string secondWord = strings[1];
            int sum = 0;

            int minLength = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLength; i++)
                sum += MultiplyCharacters(firstWord[i], secondWord[i]);

            string longerWord = (firstWord.Length > secondWord.Length ? firstWord : secondWord);

            for (int i = minLength; i < longerWord.Length; i++)
                sum += longerWord[i];

            Console.WriteLine(sum);
        }

        static int MultiplyCharacters(char str1, char str2)
        {
            int sum = str1 * str2;
            return sum;

        }
    }
}
