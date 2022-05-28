using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                passengers[i] = numberOfPeople;
            }

            foreach (int element in passengers)
            {
                Console.Write(element + " ");
            }

            int sum = passengers.Sum();
            Console.WriteLine(sum);
            
        }
    }
}
