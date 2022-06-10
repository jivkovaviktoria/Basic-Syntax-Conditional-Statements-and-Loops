using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool hasMinimum = false;
            BigInteger theBestValue = 0;
            int theBestSnowballSnow = 0;
            int theBestSnowballTime = 0;
            int theBestSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (!hasMinimum || snowballValue > theBestValue)
                {
                    hasMinimum = true;
                    theBestValue = snowballValue;
                    theBestSnowballSnow = snowballSnow;
                    theBestSnowballTime = snowballTime;
                    theBestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{theBestSnowballSnow} : {theBestSnowballTime} = {theBestValue} ({theBestSnowballQuality})");
        }
    }
}
