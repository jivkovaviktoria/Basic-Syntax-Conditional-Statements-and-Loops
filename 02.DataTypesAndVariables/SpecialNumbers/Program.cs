using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;

                for (int j = 0; j < i.ToString().Length; j++)
                {
                    sum += num % 10;
                    num = num / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
