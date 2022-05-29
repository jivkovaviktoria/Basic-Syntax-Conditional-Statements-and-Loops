using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            long total = 0;
            int counter = 0;

            while (startingYield >= 100)
            {
                total += startingYield;
                startingYield -= 10;
                total -= 26;
                counter++;
            }

            if (total >= 26)
            {
                total -= 26;
            }
            else
            {
                total = 0;
            }

            Console.WriteLine(counter);
            Console.WriteLine(total);
        }
    }
}
