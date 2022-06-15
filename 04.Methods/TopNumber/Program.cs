using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumbers(n);
        }
        static void TopNumbers(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                bool hasOddDigits = false;
                bool isDividibleByEight = false;
                int lastDigit = 0;
                int sumOfDigits = 0;
                int number = i;

                while(number!=0)
                {
                    lastDigit = number % 10;
                    if (lastDigit % 2 != 0)
                        hasOddDigits = true;

                    sumOfDigits += lastDigit;
                    number /= 10;
                }
                if (sumOfDigits % 8 == 0)
                    isDividibleByEight = true;

                if (hasOddDigits && isDividibleByEight)
                    Console.WriteLine(i);
            }
        }
    }
}
