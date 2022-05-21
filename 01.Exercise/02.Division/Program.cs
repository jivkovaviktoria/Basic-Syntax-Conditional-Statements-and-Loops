using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int[] divisible = new int[] { 2, 3, 6, 7, 10 };
            int res = 0;

            if (num % 2 == 0)
            {
                res = divisible[0];
            }

            if (num % 3 == 0)
            {
                res = divisible[1];
            }

            if (num % 6 == 0)
            {
                res = divisible[2];
            }
            if (num % 7 == 0)
            {
                res = divisible[3];
            }
            if (num % 10 == 0)
            {
                res = divisible[4];
            }

            if (num % 2 != 0 && num % 3 != 0 && num % 6 != 0 && num % 7 != 0 && num % 10 != 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {res}");
        }
    }
}
