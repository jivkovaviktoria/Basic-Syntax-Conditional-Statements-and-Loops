using System;

namespace Counter_strike
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int initialEnergy = int.Parse(input);
            int distance = 0;
            int battlesCount = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "End of battle") break;

                distance = int.Parse(input);
                if (initialEnergy - distance < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesCount} won battles and {initialEnergy} energy");
                    break;
                }

                initialEnergy -= distance;
                battlesCount++;

                if (battlesCount % 3 == 0)
                    initialEnergy += battlesCount;

                
            }

            if (input == "End of battle")
                Console.WriteLine($"Won battles: {battlesCount}. Energy left: {initialEnergy}");
        }
    }
}
