using System;
using System.Collections.Generic;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();
                string name = tokens[0];
                int HP = int.Parse(tokens[1]);
                int MP = int.Parse(tokens[2]);

                heroes.Add(name, new List<int>());
                heroes[name].Add(HP);
                heroes[name].Add(MP);
            }

            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];
                string hero = tokens[1];

                if (command == "CastSpell")
                {
                    int manaNeeded = int.Parse(tokens[2]);
                    string spell = tokens[3];

                    if (heroes[hero][1] >= manaNeeded)
                    {
                       int mana = heroes[hero][1] -= manaNeeded;
                       Console.WriteLine($"{hero} has successfully cast {spell} and now has {mana} MP!");
                    }
                    else
                       Console.WriteLine($"{hero} does not have enough MP to cast {spell}!");
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];

                    heroes[hero][0] -= damage;

                    if (heroes[hero][0] <= 0)
                    {
                       Console.WriteLine($"{hero} has been killed by {attacker}!");
                       heroes.Remove(hero);
                    }
                    else
                       Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero][0]} HP left!");
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(tokens[2]);

                    heroes[hero][1] += amount;

                    int amountRecovered = amount;

                    if (heroes[hero][1] > 200)
                    {
                       amountRecovered = Math.Abs(200 - (heroes[hero][1]-amount));
                        heroes[hero][1] = 200;
                    }

                    Console.WriteLine($"{hero} recharged for {amountRecovered} MP!");
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(tokens[2]);
                    int amountRecovered = amount;

                    heroes[hero][0] += amount;
                    if (heroes[hero][0] > 100)
                    {
                       amountRecovered = Math.Abs(100 - (heroes[hero][0]-amount));
                       heroes[hero][0] = 100;
                    }

                    Console.WriteLine($"{hero} healed for {amountRecovered} HP!");
                }

                input = Console.ReadLine();

            }

            foreach (var (hero, points) in heroes)
            {
                var hp = heroes[hero][0];
                var mp = heroes[hero][1];

                Console.WriteLine(hero);
                Console.WriteLine($"  HP: {hp}");
                Console.WriteLine($"  MP: {mp}");
            }
        }
    }
}
