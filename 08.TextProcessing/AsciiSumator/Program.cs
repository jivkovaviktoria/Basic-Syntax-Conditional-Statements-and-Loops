using System;
using System.Collections.Generic;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int start = Math.Min(char1, char2);
            int end = Math.Max(char1, char2);

            int sum = 0;

            foreach (char ch in text)
            {
                int currentChar = (int)ch;
                if (currentChar > start && currentChar < end) sum += currentChar;
            }

            Console.WriteLine(sum);
        }
    }
}