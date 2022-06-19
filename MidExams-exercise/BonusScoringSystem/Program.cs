using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = double.Parse(Console.ReadLine());
            var lectures = double.Parse(Console.ReadLine());

            var bonus = double.Parse(Console.ReadLine());

            var maxBonus = int.MinValue;
            int maxAtt = int.MinValue;


            if (students == 0 || lectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 0; i < students; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                double temp = Math.Ceiling(attendance / lectures * (5 + bonus));

                if (temp > maxBonus)
                {
                    maxBonus = (int)temp;
                    maxAtt = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAtt} lectures.");
        }
    }
}
