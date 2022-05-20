using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicator = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine($"{multiplicator} X {number} = {multiplicator * number}");
                return;
            }
            for (int i = number; i < 11; i++)
            {
                Console.WriteLine($"{multiplicator} X {i} = {multiplicator * i}");
            }
        }
    }
}
