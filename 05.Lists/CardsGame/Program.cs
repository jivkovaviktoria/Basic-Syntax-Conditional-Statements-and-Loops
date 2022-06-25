using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerCards.Count>0 && secondPlayerCards.Count>0)
            {
                int firstPlayer = firstPlayerCards[0];
                int secondPlayer = secondPlayerCards[0];

                firstPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);

                if(firstPlayer>secondPlayer)
                {
                    firstPlayerCards.Add(firstPlayer);
                    firstPlayerCards.Add(secondPlayer);
                }
                else if(secondPlayer>firstPlayer)
                {
                    secondPlayerCards.Add(secondPlayer);
                    secondPlayerCards.Add(firstPlayer);
                }
            }

            int sum = firstPlayerCards.Sum() + secondPlayerCards.Sum();
            if(firstPlayerCards.Count>secondPlayerCards.Count)
                Console.WriteLine($"First player wins! Sum: {sum}");
            else
                Console.WriteLine($"Second player wins! Sum: {sum}");



        }
    }
}
