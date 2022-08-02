using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace HeroesOfCodeAndLogicVII_with_object_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                string hero = tokens[0];
                int hp = int.Parse(tokens[1]);
                int mp = int.Parse(tokens[2]);

                heroes.Add(hero, new Hero(hp, mp));
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];
                string hero = tokens[1];

                if (command == "CastSpell") CastSpell(input, heroes);
                else if (command == "TakeDamage") TakeDamage(input, heroes);
                else if (command == "Recharge") Recharge(input, heroes);
                else if (command == "Heal") Heal(input, heroes);

                input = Console.ReadLine();
            }

            foreach (var (heroName, hero) in heroes)
            {
                Console.WriteLine(heroName);
                Console.WriteLine($"HP: {hero.HP}");
                Console.WriteLine($"MP: {hero.MP}");
            }
        }

        static void CastSpell(string input, Dictionary<string, Hero> heroes)
        {
            string[] tokens = input.Split(" - ");
            string command = tokens[0];
            string hero = tokens[1];

            int mpNeeded = int.Parse(tokens[2]);
            string spell = tokens[3];

            if (heroes[hero].MP >= mpNeeded)
            {
                int mpLeft = heroes[hero].MP - mpNeeded;
                heroes[hero].MP -= mpNeeded;
                Console.WriteLine($"{hero} has successfully cast {spell} and now has {mpLeft} MP!");
            }
            else Console.WriteLine($"{hero} does not have enough MP to cast {spell}!");
        }

        static void TakeDamage(string input, Dictionary<string, Hero> heroes)
        {
            string[] tokens = input.Split(" - ");
            string command = tokens[0];
            string hero = tokens[1];

            int damage = int.Parse(tokens[2]);
            string attacker = tokens[3];

            if (heroes[hero].HP - damage > 0)
            {
                int hpLeft = heroes[hero].HP - damage;
                heroes[hero].HP -= damage;
                Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {hpLeft} HP left!");
            }
            else
            {
                Console.WriteLine($"{hero} has been killed by {attacker}!");
                heroes.Remove(hero);
            }
        }

        static void Recharge(string input, Dictionary<string, Hero> heroes)
        {
            const int hpMax = 100;
            const int mpMax = 200;

            string[] tokens = input.Split(" - ");
            string command = tokens[0];
            string hero = tokens[1];

            int amount = int.Parse(tokens[2]);
            if (heroes[hero].MP + amount > mpMax) amount = mpMax - heroes[hero].MP;
            Console.WriteLine($"{hero} recharged for {amount} MP!");
            heroes[hero].MP += amount;
        }

        static void Heal(string input, Dictionary<string, Hero> heroes)
        {
            const int hpMax = 100;
            const int mpMax = 200;

            string[] tokens = input.Split(" - ");
            string command = tokens[0];
            string hero = tokens[1];

            int amount = int.Parse(tokens[2]);
            if (heroes[hero].HP + amount > hpMax) amount = hpMax - heroes[hero].HP;
            Console.WriteLine($"{hero} healed for {amount} HP!");
            heroes[hero].HP += amount;
        }
    }

    class Hero
    {
        public Hero(int hp, int mp)
        {
            HP = hp;
            MP = mp;
        }
        public int HP { get; set; }
        public int MP { get; set; }
    }
}