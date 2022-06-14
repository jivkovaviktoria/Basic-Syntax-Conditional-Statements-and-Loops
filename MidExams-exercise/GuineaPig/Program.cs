using System;

namespace GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            isEnoughForMonth(food, hay, cover, weight);
        }

        static void isEnoughForMonth(double food, double hay, double cover, double weight)
        {
            double foodGr = food * 1000;
            double hayGr = hay * 1000;
            double coverGr = cover * 1000;
            double weightGr = weight * 1000;

            for (int i = 1; i <= 30; i++)
            {
                foodGr -= 300;
                if (i % 2 == 0)
                    hayGr -= foodGr * 0.05;
                if (i % 3 == 0)
                    coverGr -= weightGr / 3;
            }

            if (foodGr > 0 && hayGr > 0 && coverGr > 0)
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodGr / 1000):f2}, Hay: {(hayGr / 1000):f2}, Cover: {(coverGr / 1000):f2}.");
            else
                Console.WriteLine("Merry must go to the pet store!");
        }
    }
}
