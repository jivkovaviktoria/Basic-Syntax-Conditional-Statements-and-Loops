using System;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int greaterNumber = GetGreater(firstNumber, secondNumber);
                Console.WriteLine(greaterNumber);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char greaterChar = GetGreater(firstChar, secondChar);
                Console.WriteLine(greaterChar);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string greaterString = GetGreater(firstString, secondString);
                Console.WriteLine(greaterString);
            }
        }

        static T GetGreater<T>(T firstValue, T secondValue)
            where T : IComparable<T>
        {
            var comparisonResult = firstValue.CompareTo(secondValue);
            if (comparisonResult > 0) return firstValue;
            return secondValue;
        }
    }
}
