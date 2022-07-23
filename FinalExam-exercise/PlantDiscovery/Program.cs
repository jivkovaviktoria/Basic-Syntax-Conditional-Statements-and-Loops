using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantsByRarity = new Dictionary<string, int>();
            Dictionary<string, double> plantsByRating = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("<->").ToArray();
                string plant = tokens[0];
                int rarity = int.Parse(tokens[1]);

                plantsByRarity.Add(plant, rarity);
                plantsByRating.Add(plant, 0.00);
            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] tokens = input.Split(": ");
                string[] arguments = tokens[1].Split(" - ");
                string plant = arguments[0];

                string command = tokens[0];
                switch (command)
                {
                    case "Rate":
                        if (plantsByRating.ContainsKey(plant))
                        {
                            double rating = double.Parse(arguments[1]);
                            if (plantsByRating[plant] == 0.00)
                                plantsByRating[plant] = rating;
                            else
                            {
                                plantsByRating[plant] += rating;
                                plantsByRating[plant] /= 2;
                            }
                        }
                        else Console.WriteLine("error");
                        break;
                    case "Update":
                        if (plantsByRating.ContainsKey(plant))
                        {
                            int rarity = int.Parse(arguments[1]);
                            plantsByRarity[plant] = rarity;
                        }
                        else Console.WriteLine("error");
                        break;
                    case "Reset":
                        if (plantsByRating.ContainsKey(plant))
                            plantsByRating[plant] = 0.00;
                        else Console.WriteLine("error");
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition: ");
            foreach (var plant in plantsByRarity)
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {plantsByRating[plant.Key]:f2}");

        }
    }
}