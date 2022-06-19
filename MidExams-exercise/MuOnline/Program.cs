using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|', ' ').ToArray();
            int initialHealth = 100;
            int initialBitcoins = 0;

            for (int i = 0; i < rooms.Length; i += 2)
            {
                if (rooms[i] == "potion")
                {
                    int amout = int.Parse(rooms[i + 1]);

                    if (initialHealth+amout > 100)
                    {
                        amout = 100 - initialHealth;
                        initialHealth = 100;
                    }
                    else
                    {
                        initialHealth += amout;
                    }
                    Console.WriteLine($"You healed for {amout} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");

                }
                else if (rooms[i] == "chest")
                {
                    int bitcoins = int.Parse(rooms[i + 1]);
                    Console.WriteLine($"You found {bitcoins} bitcoins.");
                    initialBitcoins += bitcoins;

                }
                else if (rooms[i] != "potion" || rooms[i] != "chest")
                {
                    int attack = int.Parse(rooms[i + 1]);
                    string monster = rooms[i];

                    initialHealth -= attack;

                    if (initialHealth > 0)
                        Console.WriteLine($"You slayed {monster}.");
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i-4}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {initialBitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
