using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int counterRooms = 0;
            int bitcoins = 0;

            string[] dungeousRooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            string[] currentRoom = new string[dungeousRooms.Length];
            for (int i = 0; i < dungeousRooms.Length; i++)
            {
                currentRoom = dungeousRooms[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = currentRoom[0];

                int numberFromInput = int.Parse(currentRoom[1]);


                switch (command)
                {
                    case "potion":
                        if (initialHealth == 100)
                        {
                            counterRooms++;
                            continue;
                        }
                        else if (initialHealth < 100)
                        {
                            bool isEnoughHealing = numberFromInput + initialHealth > 100;
                            if (isEnoughHealing == false)
                            {
                                int healthPoint = numberFromInput;
                                initialHealth += numberFromInput;
                                Console.WriteLine($"You healed for {healthPoint} hp.");
                                Console.WriteLine($"Current health: {initialHealth} hp.");
                                counterRooms++;
                            }
                            else
                            {
                                int difference = 100 - initialHealth;
                                initialHealth += difference;
                                Console.WriteLine($"You healed for {difference} hp.");
                                Console.WriteLine($"Current health: {initialHealth} hp.");
                                counterRooms++;
                            }
                        }
                        break;
                    case "chest":
                        int currentBitcoin = numberFromInput;
                        Console.WriteLine($"You found {numberFromInput} bitcoins.");
                        bitcoins += currentBitcoin;
                        counterRooms++;
                        break;
                    default:
                        bool isHealthZero = initialHealth - numberFromInput <= 0;

                        if (isHealthZero == true)
                        {
                            counterRooms++;
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {counterRooms}");
                            return;
                        }
                        string monster = command;
                        int monsterDamage = numberFromInput;
                        Console.WriteLine($"You slayed {monster}.");
                        initialHealth -= monsterDamage;
                        counterRooms++;
                        break;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
