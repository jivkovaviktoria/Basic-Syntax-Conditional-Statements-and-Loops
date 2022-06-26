using System;

namespace TheBiscuitsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            double biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double competingFactory = int.Parse(Console.ReadLine());

            double result = 0;
            double difference = 0;
            double biscuitsPerMonth = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                    biscuitsPerMonth += Math.Floor((biscuitsPerDay * workers) - (biscuitsPerDay / 4) * workers);
                else
                    biscuitsPerMonth += biscuitsPerDay * workers;
            }
            if (biscuitsPerMonth > competingFactory)
            {
                difference = biscuitsPerMonth - competingFactory;
                result = (difference / competingFactory) * 100;
            }
            else
            {
                difference = competingFactory - biscuitsPerMonth;
                result = (difference / competingFactory) * 100;
            }

            Console.WriteLine($"You have produced {biscuitsPerMonth} biscuits for the past month.");

            if (biscuitsPerMonth > competingFactory)
                Console.WriteLine($"You produce {result:f2} percent more biscuits.");
            else
                Console.WriteLine($"You produce {result:f2} percent less biscuits.");
        }

    }
}


