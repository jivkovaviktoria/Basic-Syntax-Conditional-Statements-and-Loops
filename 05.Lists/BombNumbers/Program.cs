using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            string[] command = input.Split();

            int bomb = int.Parse(command[0]);
            int power = int.Parse(command[1]);

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);
                int leftIndex = Math.Max(bombIndex - power, 0);
                int rightIndex = Math.Min(bombIndex + power, numbers.Count - 1);
                int count = 1 + rightIndex - leftIndex;

                numbers.RemoveRange(leftIndex, count);
            }

            int sum = 0;
            foreach (var number in numbers)
                sum += number;

            Console.WriteLine(sum);

        }
    }
}
