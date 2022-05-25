using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i%2==0)
                {
                    headsetCount++;
                }
                if (i%3==0)
                {
                    mouseCount++;
                }
                if (i%2==0 && i%3==0)
                {
                    keyboardCount++;
                }
                if (i%12==0)
                {
                    displayCount++;
                }
            }

            double headsetExpenses = headsetCount * headsetPrice;
            double mouseExpenses = mouseCount * mousePrice;
            double keyboardExpenses = keyboardCount * keyboardPrice;
            double displayExpenses = displayCount * displayPrice;

            double total = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
