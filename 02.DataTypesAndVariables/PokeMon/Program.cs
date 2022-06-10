using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int counter = 0;

            int temp = n;
            while (temp >= m)
            {
                temp -= m;
                counter++;

                if (temp == n / 2 && y != 0)
                {
                    temp /= y;
                }

            }

            Console.WriteLine(temp);
            Console.WriteLine(counter);
        }
    }
}
