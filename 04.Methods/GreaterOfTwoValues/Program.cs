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
                GetGreater(firstNumber, secondNumber);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                GetGreater(firstChar, secondChar);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                GetGreater(firstString, secondString);
            }
        }

        static int GetGreater(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }

        static char GetGreater(char firstChar, char secondChar)
        {
            return firstChar > secondChar ? firstChar : secondChar;
        }

        static string GetGreater(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);
            if (result > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
