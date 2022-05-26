using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(" ").ToArray();

            Array.Reverse(arrayOfStrings);

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.Write(arrayOfStrings[i] + " ");
            }
        }
    }
}
