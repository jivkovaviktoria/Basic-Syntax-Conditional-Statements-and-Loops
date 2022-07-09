using System;
using System.Text;

namespace DigitsLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var letters = new StringBuilder();
            var digits = new StringBuilder();
            var others = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var currentSymbol = input[i];

                if (char.IsLetter(currentSymbol))
                    letters.Append(currentSymbol);
                else if (char.IsDigit(currentSymbol))
                    digits.Append(currentSymbol);
                else
                    others.Append(currentSymbol);
            }

            Console.WriteLine($"{digits}\n{letters}\n{others}");
        }
    }
}
