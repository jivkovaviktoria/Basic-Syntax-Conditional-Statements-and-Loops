using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());

                if (sum+quantity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                 sum += quantity;
            }

            Console.WriteLine(sum);
        }
    }
}
