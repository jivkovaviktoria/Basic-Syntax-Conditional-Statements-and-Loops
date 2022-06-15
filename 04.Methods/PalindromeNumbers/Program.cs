using System;
using System.Collections.Generic;

namespace PalindromeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                IsPalindrome(command);
                command = Console.ReadLine();
            }

        }

        private static void IsPalindrome(string number)
        {
            char[] numberArr = number.ToCharArray();
            bool isEqual = true;
            for (int i = 0; i < numberArr.Length/2; i++)
            {
                if (numberArr[i] != numberArr[numberArr.Length - i - 1])
                    isEqual = false;
            }

            if(isEqual)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

        }
    }
}
