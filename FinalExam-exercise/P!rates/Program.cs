using System;
using System.Collections.Generic;
namespace P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> citiesByPopulation = new Dictionary<string, int>();
            Dictionary<string, int> citiesByGold = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] tokens = input.Split("||");
                string city = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);


                if (citiesByPopulation.ContainsKey(city))
                {
                    citiesByPopulation[city] += population;
                    citiesByGold[city] += gold;
                }
                else
                {
                    citiesByPopulation.Add(city, population);
                    citiesByGold.Add(city, gold);
                }

                input = Console.ReadLine();
            }

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] tokens = line.Split("=>");
                string command = tokens[0];

                int killedPeople;
                int stolenGold;

                if (command == "Plunder")
                {
                    string town = tokens[1];
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    citiesByPopulation[town] -= people;
                    citiesByGold[town] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (citiesByGold[town] <= 0 || citiesByPopulation[town] <= 0)
                    {
                        citiesByPopulation.Remove(town);
                        citiesByGold.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }

                }
                else if (command == "Prosper")
                {
                    string town = tokens[1];
                    int gold = int.Parse(tokens[2]);

                    if (gold >= 0)
                    {
                        citiesByGold[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citiesByGold[town]} gold.");
                    }
                    else Console.WriteLine("Gold added cannot be a negative number!");
                }

                line = Console.ReadLine();
            }

            if (citiesByPopulation.Count > 0)
                Console.WriteLine($"Ahoy, Captain! There are {citiesByPopulation.Count} wealthy settlements to go to:");
            else
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            foreach (var city in citiesByPopulation)
            {
                Console.WriteLine($"{city.Key} -> Population: {city.Value} citizens, Gold: {citiesByGold[city.Key]} kg");
            }

        }
    }
}