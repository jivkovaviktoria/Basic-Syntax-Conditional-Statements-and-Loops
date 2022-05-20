using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine($"{n} X {a} = {n * a}");
                return;
            }
            for (int i = a; i < 11; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
