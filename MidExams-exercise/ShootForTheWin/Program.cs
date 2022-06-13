using System;
using System.Linq;

namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int counter = 0;

            while (command != "End")
            {
                int index = int.Parse(command);
                if (Shoot(targets, index)) counter++;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {counter} -> {String.Join(" ", targets)}");
        }

        static bool Shoot(int[] targets, int index)
        {
            if (index < 0 || index >= targets.Length || targets[index] == -1)
                return false;
            
            int indexValue = targets[index];
            targets[index] = -1;

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }

                if (targets[i] > indexValue)
                {
                    targets[i] -= indexValue;
                }
                else
                {
                    targets[i] += indexValue;
                }
            }

            return true;
        }
    }
}
