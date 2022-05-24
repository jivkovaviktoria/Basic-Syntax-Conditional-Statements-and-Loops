using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters * 0.001;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
