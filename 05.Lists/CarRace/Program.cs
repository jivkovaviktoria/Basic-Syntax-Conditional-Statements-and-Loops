using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> time = Console.ReadLine().Split().Select(int.Parse).ToList();
            double sumLeft = 0;
            double sumRight = 0;

            for (int i = 0; i < time.Count / 2; i++)
            {
                sumLeft += time[i];

                if (time[i] == 0)
                    sumLeft *= 0.8;
            }

            for (int i = time.Count - 1; i > time.Count / 2; i--)
            {
                sumRight += time[i];

                if (time[i] == 0)
                    sumRight *= 0.8;
            }

            if (sumLeft < sumRight)
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            else
                Console.WriteLine($"The winner is right with total time: {sumRight}");
        }
    }
}
