using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFull = true;
            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i] != 4)
                {
                    wagons[i]++;
                    people--;
                    if (people == 0)
                        break;
                }
                if (wagons[i] != 4)
                    isFull = false;
                if (people == 0)
                    break;
            }
            if (people != 0)
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            else if (!isFull || wagons.Contains(0))
                Console.WriteLine("The lift has empty spots!");

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}