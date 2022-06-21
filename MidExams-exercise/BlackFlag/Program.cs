using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double gainedPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                gainedPlunder += dailyPlunder;

                if (i % 3 == 0)
                    gainedPlunder += dailyPlunder * 0.5;

                if (i % 5 == 0)
                    gainedPlunder -= gainedPlunder * 0.3;
            }

            if (gainedPlunder >= expectedPlunder)
                Console.WriteLine($"Ahoy! {gainedPlunder:f2} plunder gained.");
            else
            {
                double percentage = gainedPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }

        }
    }
}
